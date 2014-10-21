using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BarcodeModel.ADO;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace BarcodeModel.MODEL.Barcode.WORP.Operation
{
    [Tablename(TableName="ID")]
    public class WK05ReportModel : BaseSearchModel
    {
        public string[] WK05ReportIDs { get; set; }
        public override BaseSearchModel Insert()
        {
            string sql = @"
declare @RC int
declare @result nvarchar(200)
declare @number varchar(2)
set @RC=0
set @result=N'YES'
select @RC=count(distinct(substring(WK05002,4,1))) from WK05 where WK05001 IN ([BIDS])
if @RC>0
begin
	set @result=N'请对同一批工单进行ISSUE'
end
select @number=distinct(substring(WK05002,4,1)) from WK05 where WK05001 IN ([BIDS])
set @RC=0 
select @RC=count(WK05001) from WK05 where substring(WK05002,4,1)<@number
if @RC>0
begin
	set @result=N'请先将之前的工单ISSUE'
end
set @RC=0 
select @RC=count(distinct(RW01034)) from WK05 inner join RW01 ON RW01001=WK05004 where WK05001 IN ([BIDS])
if @RC>1
begin
	set @result=N'请一次对同一个公司的工单做ISSUE'
end
if @result='YES'
begin
    update WK05 set WK05009=1 where WK05001 IN ([BIDS])
end
select @result MSG";
            string bids = "";
            foreach (string item in this.WK05ReportIDs)
            {
                bids += "," + item;
            }
            bids = bids.Substring(1);
            DataSet ds = this.GetADO().GetDataSet(sql.Replace("[BIDS]", bids));
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string msg = ds.Tables[0].Rows[0][0] + "";
                if (msg != "YES")
                    throw new Exception(msg);
                else
                {
                    sql = @"
select WK05002,WK02012,WK02013,RW01017,RW01008,RW01009,RW01002,sum(WK05006) WK05006,RW01007,RW01034,RW01035,RW01041 from WK05 
inner join RW01 ON RW01001=WK05004 
inner join WK02 ON WK02001=WK05010 where WK05001 IN ([BIDS])
group by WK05002,WK02012,WK02013,RW01017,RW01008,RW01009,RW01002,RW01007,RW01034,RW01035,RW01041";
                    ds = this.GetADO().GetDataSet(sql.Replace("[BIDS]", bids));
                    List<Hashtable> list = new List<Hashtable>();
                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        Hashtable h = new Hashtable();
                        h["Qty"] = item["WK05006"];
                        h["StockCode"] = item["RW01002"];
                        h["ReportNumber"] = item["WK02012"];
                        h["LineNumber"] = item["WK02013"];
                        h["Bin"] = item["RW01009"];
                        h["Company"] = item["RW01034"];
                        h["SupplierBatch"] = item["RW01035"];
                        h["WorkOrder"] = item["WK05002"];
                        h["Warehouse"] = item["RW01008"];
                        list.Add(h);
                    }
                    StockTransactionXml.ExportWOReportXML(list);
                }
            }
            return this;
        }
    }
}
