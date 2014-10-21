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
    //stockreceive
    public class RWStockReceiveModel : BaseSearchModel
    {
        public string StockCode { get; set; }

        public string StockUnit { get; set; }

        public decimal StockUnitQty { get; set; }

        public string SupplierBatch { get; set; }

        public string SupplierCode { get; set; }

        public string SupplierName { get; set; }

        public string PO { get; set; }

        public string POLine { get; set; }

        public string Remark1 { get; set; }

        public string WO { get; set; }

        public string CompanyCode { get; set; }

        public string BatchID { get; set; }

        public DateTime ProductDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string Type { set; get; }

        //打印数量
        public int PrintCount { set; get; }

        public override BaseSearchModel Insert()
        {
            using (TransactionScope ts = new TransactionScope())
            {
                if (PrintCount == 0)
                {
                    throw new Exception("打印数量不能为空！");
                }
                string sqlStr = @"
declare @bid varchar(30)
declare @hid int
declare @i int
declare @dj varchar(30)

exec PROC_GETID 'RW03',@dj output
insert into RW03(RW03001,RW03002,RW03003,RW03004,RW03005,RW03006,RW03007,RW03008)
values(@dj,getdate(),@userid,@username,'','','',N'创建条码')

set @i=0
while @i<@printcount
begin
exec PROC_GETID 'RW01',@bid output
insert into RW02(RW02002,RW02003,RW02004,RW02005,RW02010,RW02011)
values(@bid,getdate(),@userid,@username,@dj,N'创建条码标签')

insert into RW01(RW01001,RW01002,RW01003,RW01004,RW01005,RW01006,RW01012,RW01013,RW01014,RW01015,RW01018,RW01024,RW01025,RW01027,RW01032,RW01034,RW01035,RW01037,RW01038,RW01040,RW01041,RW01043)
values(@bid,@stock,@stockname,@stockspec,@unit,@qty,@sup,@supname,@po,@poline,@remark,@userid,@username,@dj,1,@company,@SupplierBatch,@ProductionTime ,@ValidityTime,@tqty,@type,'REC')

insert into RW04(RW04002,RW04003,RW04004,RW04005) values(getdate(),@dj,@bid,N'创建条码')

set @i=@i+1
end
select top [COUNT] RW01001 from RW01 order by RW01001 desc
";
                sqlStr = sqlStr.Replace("[COUNT]", this.PrintCount + "");
                ModelAdo<StockModel> adoStock = new ModelAdo<StockModel>();
                StockModel sm = adoStock.GetModelByID(this.StockCode);
                BaseAdo ba = new BaseAdo();
                DataSet ds = ba.GetDataSet(sqlStr, new SqlParameter("@userid", this.LoginUserID),
                                  new SqlParameter("@username", this.LoginUserName),
                                  new SqlParameter("@stock", this.StockCode),
                                  new SqlParameter("@stockname", sm.StockName),
                                  new SqlParameter("@stockspec", sm.StockSpec),
                                  new SqlParameter("@unit", this.StockUnit),
                                  new SqlParameter("@qty", this.StockUnitQty),
                                  new SqlParameter("@tqty", sm.StockType == "02" ? 1 : sm.UQTY),
                                  new SqlParameter("@po", this.PO),
                                  new SqlParameter("@poline", this.POLine),
                                  new SqlParameter("@sup", this.SupplierCode),
                                  new SqlParameter("@supname", this.SupplierName),
                                  new SqlParameter("@remark", this.Remark1),
                                  new SqlParameter("@company", this.CompanyCode),
                                  new SqlParameter("@SupplierBatch", this.SupplierBatch),
                                  new SqlParameter("@printcount", this.PrintCount),
                                  new SqlParameter("@type", sm.StockType),
                                  new SqlParameter("@ProductionTime", this.ProductDate),
                                  new SqlParameter("@ValidityTime", this.ExpirationDate)
                                  );
                //StringBuilder sb = new StringBuilder();
                //foreach (DataRow item in ds.Tables[0].Rows)
                //{
                //    sb.Append(",'" + item[0] + "'");
                //}
                //sb.Remove(0, 1);
                //ExportXML(sb.ToString());
                ts.Complete();
            }
            return this;
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
                    list.Add(h);
                }
                StockTransactionXml.ExportStockReceiptXML(list);
            }
        }

    }
}
