using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeModel.ADO;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using System.Transactions;
using BarcodeModel.MODEL.Barcode.FG;
using BarcodeModel.MODEL.Barcode.RW;

namespace BarcodeModel.MODEL.Barcode.WORP.Operation
{
    public class WOLineReportModel : BaseSearchModel
    {
        public int ReportLineID { get; set; }
        public string RWID { get; set; }
        public float DeQTY { get; set; }
        public string WorkOrder { get; set; }
        public string WorkCenter { get; set; }
        public override BarcodeModel.MODEL.BaseSearchModel Insert()
        {
            using (TransactionScope ts = new TransactionScope())
            {
                ModelAdo<RWBarcodeModel> adoRW = new ModelAdo<RWBarcodeModel>();
                RWBarcodeModel barcode = adoRW.GetModelByID(this.RWID);
                ModelAdo<ReportModel> adoRM = new ModelAdo<ReportModel>();
                ReportModel rm = adoRM.GetModelByID(this.ReportLineID + "");
                if (barcode.Warehouse != rm.Warehouse)
                {
                    throw new Exception("此工单需汇报" + rm.Warehouse + "仓库的料");
                }
                string sql = @"
declare @lineno varchar(30)
declare @reportnumber varchar(30)
declare @stock varchar(40)
declare @stocktype varchar(40)
declare @barcodeQTY numeric(15,3)

select @wo=WK02002,@lineno=WK02012,@reportnumber=WK02013 from WK02 where WK02001=@rlid
select @stock=RW01002,@stocktype=RW01041,@barcodeQTY=RW01006 from RW01 where RW01001=@bid
if(@barcodeQTY=@deqty)
update RW01 set RW01032=3 where RW01001=@bid
else
update RW01 set RW01006=RW01006-@deqty where RW01001=@bid


insert into RW02(RW02002,RW02003,RW02004,RW02005,RW02011)
select RW01001,getdate(),@userid,@username,N'扣料 工单号'+@wo+' 数量'+convert(varchar(10),@deqty) from RW01 where RW01001=@bid

update WK02 set WK02008=case when WK02008 is null then getdate() else WK02008 end,WK02009=WK02009+@deqty,WK02010=@wc where WK02001=@rlid
update WK01 set WK01005=getdate() where WK01001=@wo and WK01005 is null and WK01006 is null

if not exists(select * from WK04 where WK04001=@wo and WK04002=@wc and WK04004 is null)
insert into WK04(WK04001,WK04002,WK04003)
values(@wo,@wc,getdate())

if not exists(select * from WK02 where WK02002=@wo and WK02009<WK02005)
update WK01 set WK01008=3 where WK01001=@wo
else
update WK01 set WK01008=2 where WK01001=@wo

insert into WK05(WK05002,WK05003,WK05004,WK05005,WK05006,WK05007,WK05008,WK05009,WK05010)
values(@wc,@wo,@bid,@stock,@deqty,@stocktype,getdate(),case @stocktype when '02' then 1 else 0 end,@rlid)

select @wo WO,@reportnumber RN,@lineno LN,RW01017,RW01008,RW01009,RW01002,RW01006/RW01040 RW01006,RW01007,RW01034,RW01035,RW01041 from RW01 where RW01001=@bid
";
                BaseAdo ba = new BaseAdo();
                DataSet ds = ba.GetDataSet(sql,
                        new SqlParameter("@userid", this.LoginUserID),
                        new SqlParameter("@username", this.LoginUserName),
                        new SqlParameter("@wo", this.WorkOrder),
                        new SqlParameter("@bid", this.RWID),
                        new SqlParameter("@deqty", this.DeQTY),
                        new SqlParameter("@rlid", this.ReportLineID),
                        new SqlParameter("@wc", this.WorkCenter));

                if (ds.Tables[0].Rows[0]["RW01041"] + "" != "04" && ds.Tables[0].Rows[0]["RW01041"] + "" != "00")
                {
                    List<Hashtable> list = new List<Hashtable>();
                    Hashtable h = new Hashtable();
                    //h["Qty"] = ds.Tables[0].Rows[0]["RW01006"];
                    h["Qty"] = this.DeQTY;
                    h["StockCode"] = ds.Tables[0].Rows[0]["RW01002"];
                    h["ReportNumber"] = ds.Tables[0].Rows[0]["RN"];
                    h["LineNumber"] = ds.Tables[0].Rows[0]["LN"];
                    h["Bin"] = ds.Tables[0].Rows[0]["RW01009"];
                    h["Company"] = ds.Tables[0].Rows[0]["RW01034"];
                    h["SupplierBatch"] = ds.Tables[0].Rows[0]["RW01035"];
                    h["WorkOrder"] = ds.Tables[0].Rows[0]["WO"];
                    h["Warehouse"] = ds.Tables[0].Rows[0]["RW01008"];
                    list.Add(h);
                    StockTransactionXml.ExportWOReportXML(list);
                }
                ts.Complete();
                return this;
            }
        }
    }
}
