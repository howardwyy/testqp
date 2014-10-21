using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeModel.ADO;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using System.Collections;

namespace BarcodeModel.MODEL.Barcode.RW.Operation
{
    public class EnterWarehouseModel : BaseSearchModel
    {
        public string Warehouse { get; set; }
        public string Bin { get; set; }
        public string Remark { get; set; }
        public string[] Barcodes { get; set; }
        public string FRNumber { get; set; }

        public override BaseSearchModel Insert()
        {

            if (Barcodes == null || Barcodes.Length == 0)
                throw new Exception("请扫描或输入待入库的条码标签");
            ModelAdo<LocationModel> adoLoc = new ModelAdo<LocationModel>();
            List<LocationModel> lm = adoLoc.GetList("SC36001=@wh and SC36002=@bin", "", "", new SqlParameter("@wh", this.Warehouse), new SqlParameter("@bin", this.Bin));

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
select @RC=count(RW01001) from RW01 where RW01001 IN ([BIDS]) and RW01032>1
if @RC>0
begin
	set @result=N'已入库的料不可再入库'
end
set @RC=0 
select @RC=count(distinct(RW01014)) from RW01 where RW01001 IN ([BIDS])
if @RC>1
begin
	set @result=N'多张采购单请分批收货'
end
set @RC=0 
select @RC=count(distinct(RW01043)) from RW01 where RW01001 IN ([BIDS])
if @RC>1
begin
	set @result=N'PO收货、WO收货以及STOCK RECEIVE请分开操作'
end
if @result='YES'
begin
    exec PROC_GETID 'RW03',@dj output
	
    insert into RW03(RW03001,RW03002,RW03003,RW03004,RW03005,RW03006,RW03007,RW03008)
    values(@dj,getdate(),@userid,@username,'','','',@Remark)

    insert into RW02(RW02002,RW02003,RW02004,RW02005,RW02010,RW02011)
    select RW01001,getdate(),@userid,@username,@dj,N'入库到'+@whstr from RW01 where RW01001 IN ([BIDS])

    insert into RW04(RW04002,RW04003,RW04004,RW04005)
    select getdate(),@dj,RW01001,N'入库到'+@whstr from RW01 where RW01001 IN ([BIDS])
	
    update RW01 set RW01008=@wh,RW01009=@sh,RW01010=getdate(),RW01024=@userid,RW01025=@username,RW01027=@dj,RW01032=2 where RW01001 IN ([BIDS])	

    UPDATE WK01 SET WK01006=getdate() where WK01006 is null and WK01004<= (select sum(RW01006) FROM RW01 WHERE RW01032=2 and RW01033=WK01001 and RW01002=WK01002 GROUP BY RW01033,RW01002)
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
                        this.ExportXMLPO(sb.ToString());
                    }
                }
                ts.Complete();
                return this;
            }
        }


        private void ExportXMLPO(string bids)
        {
            string sql = @"
select RW01014,RW01015,RW01002,SUM(RW01006) RW01006,RW01035,RW01008,RW01009,convert(varchar(10),RW01037,121) RW01037,convert(varchar(10),RW01038,121) RW01038,RW01034,RW01043,RW01033 from RW01 where RW01001 IN ([BIDS]) 
group by RW01014,RW01015,RW01002,RW01035,RW01037,RW01038,RW01034,RW01008,RW01009,RW01043,RW01033
order by RW01014,RW01015,RW01035
select SUM(RW01006) RW01006 FROM RW01 where RW01001 IN ([BIDS]) ";

            BaseAdo ba = new BaseAdo();
            DataSet ds = ba.GetDataSet(sql.Replace("[BIDS]", bids));
            if (ds.Tables[0].Rows.Count > 0)
            {
                string company = ds.Tables[0].Rows[0]["RW01034"] + "";
                string receivetype = ds.Tables[0].Rows[0]["RW01043"] + "";
                if (receivetype == "WO")//WO收货入库
                {
                    string ordernum = ds.Tables[0].Rows[0]["RW01033"] + "";
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
		<msg:Req msg-type=""Work Order Receipt"" action=""Process"">
			<msg:Dta>
				<dta:WorkOrderReceiptRequest xsi:schemaLocation=""http://www.scala.net/WorkOrderReceiptRequest/1.1 http://scshost/schemas/Scala/1.1/WorkOrderReceiptRequest.xsd   "" xmlns:msg=""http://Epicor.com/InternalMessage/1.1"" xmlns:dta=""http://www.scala.net/WorkOrderReceiptRequest/1.1"">
					<dta:WorkorderNumber>[WO]</dta:WorkorderNumber>
					<dta:ReceiptDate>[DATE]</dta:ReceiptDate>
					<dta:ReceiptWarehouse>[WH]</dta:ReceiptWarehouse>
					<dta:ReceiptQuantity>[SUMQTY]</dta:ReceiptQuantity>
					<dta:CloseWorkorder>1</dta:CloseWorkorder>
					<dta:ReceiptLines>");
                    export.Replace("[COM]", company);
                    export.Replace("[WO]", ordernum);
                    export.Replace("[WH]", ds.Tables[0].Rows[0]["RW01008"] + "");
                    export.Replace("[SUMQTY]", ds.Tables[1].Rows[0]["RW01006"] + "");
                    export.Replace("[DATE]", DateTime.Now.ToString("yyyy-MM-dd"));
                    string receTemp = @"
						<dta:ReceiptLine>
							<dta:Batch>
								<dta:BatchCode>{0}</dta:BatchCode>
							</dta:Batch>
							<dta:ReceiptWarehouse>{1}</dta:ReceiptWarehouse>
							<dta:ReceiptDate>{2}</dta:ReceiptDate>
							<dta:ReceiptQuantity>{3}</dta:ReceiptQuantity>
							<dta:BinCode>{4}</dta:BinCode>
							<dta:ManufDate>{5}</dta:ManufDate>
							<dta:ExpiryDate>{6}</dta:ExpiryDate>
							<dta:SuppBatchCode>{0}</dta:SuppBatchCode>
						</dta:ReceiptLine>";
                    int i = 0;
                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        export.Append(string.Format(receTemp, item["RW01035"], item["RW01008"], DateTime.Now.ToString("yyyy-MM-dd"), item["RW01006"], item["RW01009"], item["RW01037"], item["RW01038"]));
                    }

                    export.Append(@"
					</dta:ReceiptLines>
				</dta:WorkOrderReceiptRequest>
			</msg:Dta>
		</msg:Req>
	</msg:Body>
</msg:Msg>
");
                    string[] path = SysConfig.GetXMLExportPath(company);
                    string filename = "WORECEIVE" + DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(1000, 9999) + ".xml";
                    System.IO.File.WriteAllText(path[0] + filename, export.ToString(), Encoding.Unicode);
                    System.IO.File.WriteAllText(path[1] + "bak" + filename, export.ToString(), Encoding.Unicode);
                }
                else if (receivetype == "REC")//Receive收货
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
                    StockTransactionXml.ExportStockReceiptXML(list);
                }
                else if (receivetype == "PO")//PO收货
                {
                    string ordernum = ds.Tables[0].Rows[0]["RW01014"] + "";
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
		<msg:Req msg-type=""Goods Receive Note"" action=""Process"">
			<msg:Dta>
				<dta:PurchaseOrderDelivery xsi:schemaLocation=""http://www.scala.net/PurchaseOrderDelivery/1.1 http://scshost/schemas/Scala/1.1/PurchaseOrderDelivery.xsd"" xmlns:msg=""http://Epicor.com/InternalMessage/1.1"" xmlns:dta=""http://www.scala.net/PurchaseOrderDelivery/1.1"">
					<dta:OrderHeader>
						<dta:OrdNum>[ORDERNO]</dta:OrdNum>
						<dta:GoodsReceivedNoteNum>[NOTENUM]</dta:GoodsReceivedNoteNum>
					</dta:OrderHeader>
					<dta:OrderLineList>");
                    export.Replace("[COM]", company);
                    export.Replace("[ORDERNO]", ordernum);
                    export.Replace("[NOTENUM]", "");
                    string lineno = "";
                    string lineBegin = @"
						<dta:OrderLine>
							<dta:LineNum>{0}</dta:LineNum>
							<dta:StructLineNum/>
							<dta:StockCode>{1}</dta:StockCode>
							<dta:DelivLineList>";
                    string delLine = @"
								<dta:DelivLine>
									<dta:DelivLineNum>{0}</dta:DelivLineNum>
									<dta:QtyDeliv>{1}</dta:QtyDeliv>
									<dta:BatchCode></dta:BatchCode>
									<dta:SuppBatchCode>{2}</dta:SuppBatchCode>
									<dta:DelivDateAct>{3}</dta:DelivDateAct>
									<dta:ManufDate>{4}</dta:ManufDate>
									<dta:ExpiryDate>{5}</dta:ExpiryDate>
									<dta:BinCode>{6}</dta:BinCode>
								</dta:DelivLine>";
                    int i = 0;
                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        string line = item["RW01015"] + "";
                        if (line.Length == 0)
                            line = this.GetLineNO(ordernum, item["RW01002"] + "", company);
                        if (lineno != line)
                        {
                            if (i != 0)//行结束
                            {
                                export.Append(@"
							</dta:DelivLineList>
						</dta:OrderLine>");
                            }
                            i = 0;
                            export.Append(string.Format(lineBegin, line, item["RW01002"]));
                        }
                        i = i + 10;
                        export.Append(string.Format(delLine, "", item["RW01006"], item["RW01035"], DateTime.Now.ToString("yyyy-MM-dd"), item["RW01037"], item["RW01038"], item["RW01009"]));
                    }

                    export.Append(@"</dta:DelivLineList>
						</dta:OrderLine>
					</dta:OrderLineList>
				</dta:PurchaseOrderDelivery>
			</msg:Dta>
		</msg:Req>
	</msg:Body>
</msg:Msg>
");
                    string[] path = SysConfig.GetXMLExportPath(company);
                    string filename = "PORECEV" + DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(1000, 9999) + ".xml";
                    System.IO.File.WriteAllText(path[0] + filename, export.ToString(), Encoding.Unicode);
                    System.IO.File.WriteAllText(path[1] + "bak" + filename, export.ToString(), Encoding.Unicode);
                }
            }
        }

        private string GetLineNO(string po, string stock, string company)
        {
            BaseAdo ba = new BaseAdo();
            ba.ConnectionStr = SysConfig.DBScalaConnection;
            string sql = "select PC03002 from PC03[COM]00 where PC03001=@po and PC03005=@stock";
            DataSet ds = ba.GetDataSet(sql.Replace("[COM]", company), new SqlParameter("@po", po), new SqlParameter("@stock", stock));
            if (ds.Tables[0].Rows.Count > 0)
                return ds.Tables[0].Rows[0][0] + "";
            else
                return "";
        }
    }
}
