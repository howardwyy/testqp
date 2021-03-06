﻿using BarcodeModel.ADO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BarcodeModel.MODEL.Barcode.RW.Operation
{
    
   public class MoveWarehouseModel: BaseSearchModel
    {
        public string Warehouse { get; set; }
        public string Bin { get; set; }
        public string Remark { get; set; }
        public string[] Barcodes { get; set; }

        public override BaseSearchModel Insert()
        {

            if (Barcodes == null || Barcodes.Length == 0)
                throw new Exception("请扫描或输入待移库的条码标签");
            ModelAdo<LocationModel> adoLoc = new ModelAdo<LocationModel>();
            List<LocationModel> lm = adoLoc.GetList("SC36001=@wh and SC36002=@bin ", "", "", new SqlParameter("@wh", this.Warehouse), new SqlParameter("@bin", this.Bin));

            if (lm.Count == 0)
                throw new Exception("仓库或库位不存在");
            using (TransactionScope ts = new TransactionScope())
            {

                ModelAdo<RWBarcodeModel> adoRW = new ModelAdo<RWBarcodeModel>();
                StringBuilder sb = new StringBuilder();
                foreach (string item in Barcodes)
                {
                    sb.Append(",'" + item + "'");
                }
                sb.Remove(0, 1);

                string sql = @"
declare @RC int
declare @result nvarchar(200)
declare @dj varchar(30)
set @RC=0
set @result=N'YES'
select @RC=count(RW01001) from RW01 where RW01001 IN ([BIDS]) and RW01032 <> 2
if @RC>0
begin
	set @result=N'请仅对已入库的料进行移库操作'
end

if @result='YES'
begin
    exec PROC_GETID 'RW03',@dj output
	
    insert into RW03(RW03001,RW03002,RW03003,RW03004,RW03005,RW03006,RW03007,RW03008)
    values(@dj,getdate(),@userid,@username,'','','',@Remark)

    insert into RW02(RW02002,RW02003,RW02004,RW02005,RW02010,RW02011)
    select RW01001,getdate(),@userid,@username,@dj,N'移库到'+@whstr from RW01 where RW01001 IN ([BIDS])

    insert into RW04(RW04002,RW04003,RW04004,RW04005)
    select getdate(),@dj,RW01001,N'移库到'+@whstr from RW01 where RW01001 IN ([BIDS])
	
    update RW01 set RW01016 =RW01008 ,RW01017 = RW01009,RW01008=@wh,RW01009=@sh,RW01024=@userid,RW01025=@username,RW01027=@dj,RW01032=2 where RW01001 IN ([BIDS])	
end
select @result MSG
";
                sql = sql.Replace("[BIDS]", sb.ToString());
                DataSet ds = adoRW.GetDataSet(sql, new SqlParameter("@Remark", this.Remark), new SqlParameter("@userid", this.LoginUserID), new SqlParameter("@username", this.LoginUserName),
                    new SqlParameter("@wh", this.Warehouse), new SqlParameter("@sh", this.Bin), new SqlParameter("@whstr", this.Warehouse + "[" + this.Bin + "]"));
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    string msg = ds.Tables[0].Rows[0][0] + "";
                    if (msg != "YES")
                        throw new Exception(msg);
                    else
                    {
                        this.ExportXML(sb.ToString());
                    }
                }
                ts.Complete();
                return this;
            }
        }



        private void ExportXML(string bids)
        {
            string sql = @"
select RW01016,RW01017,RW01008,RW01009,RW01002,SUM(RW01006/RW01040) RW01006,RW01007,RW01034,RW01035 from RW01 where RW01001 IN ([BIDS]) 
group by RW01016,RW01017,RW01008,RW01009,RW01002,RW01007,RW01034,RW01035
";

            BaseAdo ba = new BaseAdo();
            DataSet ds = ba.GetDataSet(sql.Replace("[BIDS]", bids));
            if (ds.Tables[0].Rows.Count > 0)
            {
                List<Hashtable> list = new List<Hashtable>();
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    Hashtable h = new Hashtable();
                    h["Qty"] = item["RW01006"];
                    h["StockCode"] = item["RW01002"];
                    h["WhCodeFrom"] = item["RW01016"];
                    h["BinCodeFrom"] = item["RW01017"];
                    h["WhCodeTo"] = item["RW01008"];
                    h["BinCodeTo"] = item["RW01009"];
                    h["Company"] = item["RW01034"];
                    h["SupplierBatch"] = item["RW01035"];
                    list.Add(h);
                }
                StockTransactionXml.ExportMoveXML(list);
            }
        }
    }
}
