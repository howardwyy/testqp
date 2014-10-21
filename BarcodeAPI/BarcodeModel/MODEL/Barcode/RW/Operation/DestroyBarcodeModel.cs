using BarcodeModel.ADO;
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
    public class DestroyBarcodeModel : BaseSearchModel
    {
        public string Remark { get; set; }
        public string[] Barcodes { get; set; }

        public bool isExportFile { get; set; }

        public string FRNumber { get; set; }

        public override BaseSearchModel Insert()
        {

            if (Barcodes == null || Barcodes.Length == 0)
                throw new Exception("请扫描或输入待销毁的条码标签");
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


if @result='YES'
begin
	  
    insert into RW02(RW02002,RW02003,RW02004,RW02005,RW02011)
    select RW01001,getdate(),@userid,@username,@Remark from RW01 where RW01001 IN ([BIDS]) 
	
    update RW01 set RW01024=@userid,RW01025=@username,RW01032=5 where RW01001 IN ([BIDS])	
end
select @result MSG
";
                sql = sql.Replace("[BIDS]", sb.ToString());
                DataSet ds = adoRW.GetDataSet(sql, new SqlParameter("@Remark", this.Remark), new SqlParameter("@userid", this.LoginUserID), new SqlParameter("@username", this.LoginUserName));
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    string msg = ds.Tables[0].Rows[0][0] + "";
                    if (msg != "YES")
                        throw new Exception(msg);
                    else if (this.isExportFile)
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
                    h["Warehouse"] = item["RW01008"];
                    h["Bin"] = item["RW01009"];
                    h["Company"] = item["RW01034"];
                    h["SupplierBatch"] = item["RW01035"];
                    h["FRNUMBER"] = this.FRNumber;
                    list.Add(h);
                }
                StockTransactionXml.ExportStockIssueXML(list);
            }
        }
    }
}
