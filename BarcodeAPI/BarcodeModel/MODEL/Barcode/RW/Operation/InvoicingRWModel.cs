using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BarcodeModel.MODEL.Barcode.RW.Operation
{
    /// <summary>
    /// 发货单，发货动作
    /// </summary>
    public class InvoicingRWModel : BaseSearchModel
    {
        //单据号备注
        public string Remark { get; set; }
        //发货单ID
        public string InvoiceID { get; set; }
        //发货单状态
        public string InvoiceStatus { get; set; }
        //发货单行ID
        public string InvoiceLine { get; set; }
        //发货单行已领数量
        public decimal InvoicedCount { set; get; }
        //发货单行剩余数量
        public decimal InvoiceSurplusCount { set; get; }
        //发货单行关联条码信息
        public string[] Barcodes { get; set; }

        public override BarcodeModel.MODEL.BaseSearchModel Insert()
        {
            if (Barcodes == null || Barcodes.Length == 0)
                throw new Exception("请扫描或输入待出库的条码标签");

            //①：修改成品发货单单RW18状态 ：RW18008	int		状态(1已申请 2部分发货 3关闭)
            //②：修改成品发货单单ITEMRW19已领和剩余数量
            //③：插入RW20	成品发货单单BARCODE	中间表

            //④：修改条码信息表：
            //⑤：插入RW03成品单据表
            //⑥：插入RW04成品单据明细表
            //⑦：插入RW02	成品历史记录
            using (TransactionScope ts = new TransactionScope())
            {
                ModelAdo<RWBarcodeModel> adoRW = new ModelAdo<RWBarcodeModel>();
                List<SqlParameter> parameters = new List<SqlParameter>();
                StringBuilder sb = new StringBuilder();
                foreach (string item in Barcodes)
                {
                    sb.Append(",'" + item + "'");
                }
                sb.Remove(0, 1);

                string sql = @"
declare @RC int
declare @so varchar(20）
declare @lineno varchar(10)
declare @result nvarchar(200)
declare @dj varchar(30)
set @RC=0
set @result=N'YES'
select @RC=count(RW01001) from RW01 where RW01001 IN ([BIDS]) and RW01032 <> 2
if @RC>0
begin
	set @result=N'存在不能做发货操作的信息，不能进行发货操作'
end

if @result='YES'
begin
    Update RW19 set RW19005=@userid,RW19006=@username,RW19011=@InvoicedCount, RW19012=@InvoiceSurplusCount where RW19001=@InvoiceLine

    select @lineno=RW19002,@so=RW18008 from RW19 inner join RW18 ON RW18001=RW19003 where RW19001=@InvoiceLine    
    declare @calcstatus int
    set @calcstatus=2
    select @calcstatus=SUM(RW19012) from RW19 where RW19003=@InvoiceID
    if @calcstatus>0
    begin
	    set @InvoiceStatus=2
    end
    else
    begin
	    set @InvoiceStatus=3
    end
    Update RW18 set RW18005=@InvoiceStatus where RW18001=@InvoiceID

    insert into RW20(RW20002,RW20003,RW20004,RW20005,RW20006,RW20007)
    select getdate(),@userid,@username,@InvoiceID,@InvoiceLine,RW01001 from RW01 where RW01001 IN ([BIDS])

    exec PROC_GETID 'RW03',@dj output
	
    insert into RW03(RW03001,RW03002,RW03003,RW03004,RW03005,RW03006,RW03007,RW03008)
    values(@dj,getdate(),@userid,@username,'','',@InvoiceID,@Remark)

    insert into RW02(RW02002,RW02003,RW02004,RW02005,RW02010,RW02011)
    select RW01001,getdate(),@userid,@username,@dj,N'发货单['+ @InvoiceID +']' from RW01 where RW01001 IN ([BIDS])

    insert into RW04(RW04002,RW04003,RW04004,RW04005)
    select getdate(),@dj,RW01001,N'发货单['+ @InvoiceID +']' from RW01 where RW01001 IN ([BIDS])
	
    update RW01 set RW01016 =RW01008 ,RW01017 = RW01009,RW01024=@userid,RW01025=@username,RW01027=@dj,RW01032=3,RW01030=@so,RW01039=@lineno where RW01001 IN ([BIDS])	

end
select @result MSG
";

                parameters.Add(new SqlParameter("@userid", this.LoginUserID));
                parameters.Add(new SqlParameter("@username", this.LoginUserName));
                parameters.Add(new SqlParameter("@Remark", this.Remark));
                parameters.Add(new SqlParameter("@InvoiceID", this.InvoiceID));
                parameters.Add(new SqlParameter("@InvoiceStatus", this.InvoiceStatus));
                parameters.Add(new SqlParameter("@InvoiceLine", this.InvoiceLine));
                parameters.Add(new SqlParameter("@InvoicedCount", this.InvoicedCount));
                parameters.Add(new SqlParameter("@InvoiceSurplusCount", this.InvoiceSurplusCount));



                sql = sql.Replace("[BIDS]", sb.ToString());
                DataSet ds = adoRW.GetDataSet(sql, parameters.ToArray());
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
select RW01030,RW01039,RW01002,RW01007,RW01008,RW01009,sum(RW01006) RW01006,RW01034,RW01035 from RW01 where RW01001 IN (SELECT RW20007 FROM RW20 INNER JOIN RW19 ON RW19001=RW20006 WHERE RW20007 IN ([BIDS]) and RW19013 NOT LIKE 'CW%') 
GROUP BY RW01030,RW01039,RW01002,RW01007,RW01034,RW01035,RW01008,RW01009";

            BaseAdo ba = new BaseAdo();
            DataSet ds = ba.GetDataSet(sql.Replace("[BIDS]", bids));
            if (ds.Tables[0].Rows.Count > 0)
            {
                string company = ds.Tables[0].Rows[0]["RW01034"] + "";
                string ordernum = ds.Tables[0].Rows[0]["RW01030"] + "";

                StringBuilder export = new StringBuilder();
                export.Append(@"
<msg:Msg xsi:schemaLocation=""http://Epicor.com/Message/2.0 http://scshost/schemas/epicor/ScalaMessage.xsd"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:msg=""http://Epicor.com/Message/2.0"">
	<msg:Hdr>
		<msg:Sender>
			<msg:Name>Generic Sender</msg:Name>
			<msg:Subname>[COM]-Scala</msg:Subname>
		</msg:Sender>
	</msg:Hdr>
	<msg:Body>
		<msg:Req msg-type=""Sales Order Delivery"" action=""Process"">
			<msg:Dta>
				<dta:SalesOrderDelivery xsi:schemaLocation=""http://www.scala.net/SalesOrderDelivery/1.1 http://scshost/schemas/Scala/1.1/SalesOrderDelivery.xsd"" xmlns:msg=""http://Epicor.com/InternalMessage/1.1"" xmlns:dta=""http://www.scala.net/SalesOrderDelivery/1.1"">
					<dta:OrderHeader>
						<dta:OrdNum>[SO]</dta:OrdNum>
					</dta:OrderHeader>
					<dta:OrderLineList>");
                export.Replace("[COM]", company);
                export.Replace("[SO]", ordernum);
                string delLine = @"
						<dta:OrderLine>
							<dta:LineNum>{0}</dta:LineNum>
							<dta:StockCode>{1}</dta:StockCode>
							<dta:DelivLineList>
								<dta:DelivLine>
									<dta:DelivLineNum></dta:DelivLineNum>
									<dta:QtyDeliv>{2}</dta:QtyDeliv>
									<dta:BatchCode>{4}</dta:BatchCode>
									<dta:DelivDateAct>{3}</dta:DelivDateAct>
								</dta:DelivLine>
							</dta:DelivLineList>
						</dta:OrderLine>";
                foreach (DataRow item in ds.Tables[0].Rows)
                {


                    string stock = item["RW01002"] + "";
                    string warehouse = item["RW01008"] + "";
                    string bin = item["RW01009"] + "";
                    string SupplierBatch = item["SupplierBatch"] + "";
                    double qty = double.Parse(item["Qty"] + "");
                    List<KeyValuePair<string, double>> list = StockTransactionXml.GetScalaBatch(stock, warehouse, bin, SupplierBatch, qty, company);
                    foreach (KeyValuePair<string, double> batch in list)
                    {
                        export.Append(string.Format(delLine, item["RW01039"], stock, batch.Value, DateTime.Now.ToString("yyyy-MM-dd"), batch.Key));
                    }
                }

                export.Append(@"
					</dta:OrderLineList>
				</dta:SalesOrderDelivery>
			</msg:Dta>
		</msg:Req>
	</msg:Body>
</msg:Msg>
");
                string[] path = SysConfig.GetXMLExportPath(company);
                string filename = DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(1000, 9999) + ".xml";
                System.IO.File.WriteAllText(path[0] + filename, export.ToString(), Encoding.Unicode);
                System.IO.File.WriteAllText(path[1] + "bak" + filename, export.ToString(), Encoding.Unicode);
            }
        }
    }
}
