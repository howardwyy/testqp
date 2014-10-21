using BarcodeModel.ADO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BarcodeModel.MODEL
{
    public class StockTransactionXml
    {
        /// <summary>
        /// 导出移库xml文件，数据结构Qty,StockCode,WhCodeFrom,BinCodeFrom,WhCodeTo,BinCodeTo,Company,SupplierBatch
        /// </summary>
        /// <param name="data"></param>
        public static string ExportMoveXML(List<Hashtable> data)
        {
            string result = "[YES]";
            string company = data[0]["Company"] + "";

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
		<msg:Req msg-type=""Stock Transaction"" action=""Process"">
			<msg:Dta>
				<dta:StockTransaction xsi:schemaLocation=""http://www.scala.net/StockTransaction/1.1 http://scshost/schemas/Scala/1.1/StockTransaction.xsd"" xmlns:msg=""http://Epicor.com/InternalMessage/1.1"" xmlns:dta=""http://www.scala.net/StockTransaction/1.1"">");
            export.Replace("[COM]", company);
            string transTemp = @"
					<dta:Movement>
						<dta:TransDate>{0}</dta:TransDate>
						<dta:Qty>{1}</dta:Qty>
						<dta:StockCode>{2}</dta:StockCode>
						<dta:WhCodeFrom>{3}</dta:WhCodeFrom>
						<dta:BinCodeFrom>{4}</dta:BinCodeFrom>
						<dta:WhCodeTo>{5}</dta:WhCodeTo>
						<dta:BinCodeTo>{6}</dta:BinCodeTo>
						<dta:BatchCode BatchHandlingMethod=""0"">{7}</dta:BatchCode>
					</dta:Movement>";
            string msg = "";
            foreach (Hashtable item in data)
            {
                string stock = item["StockCode"] + "";
                string whfrom = item["WhCodeFrom"] + "";
                string BinCodeFrom = item["BinCodeFrom"] + "";
                string WhCodeTo = item["WhCodeTo"] + "";
                string BinCodeTo = item["BinCodeTo"] + "";
                string SupplierBatch = item["SupplierBatch"] + "";
                double qty = double.Parse(item["Qty"] + "");
                List<KeyValuePair<string, double>> list = StockTransactionXml.GetScalaBatch(stock, whfrom, BinCodeFrom, SupplierBatch, qty, company);
                foreach (KeyValuePair<string, double> batch in list)
                {
                    export.Append(string.Format(transTemp, DateTime.Now.ToString("yyyy-MM-dd"), batch.Value, stock, whfrom, BinCodeFrom, WhCodeTo, BinCodeTo, batch.Key));
                }
            }

            export.Append(@"
				</dta:StockTransaction>
			</msg:Dta>
		</msg:Req>
	</msg:Body>
</msg:Msg>
");
            string[] path = SysConfig.GetXMLExportPath(company);
            string filename = "TRANSFER" + DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(1000, 9999) + ".xml";
            System.IO.File.WriteAllText(path[0] + filename, export.ToString(), Encoding.Unicode);
            System.IO.File.WriteAllText(path[1] + "bak" + filename, export.ToString(), Encoding.Unicode);

            return result;
        }



        /// <summary>
        /// 导出移库xml文件，数据结构Qty,ReportNumber,LineNumber,StockCode,Bin,Company,SupplierBatch,WorkOrder,WH
        /// </summary>
        /// <param name="data"></param>
        public static string ExportWOReportXML(List<Hashtable> data)
        {
            string result = "[YES]";
            string company = data[0]["Company"] + "";

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
		<msg:Req msg-type=""Work Order Material Issue"" action=""Process"">
			<msg:Dta>
				<dta:WorkOrderMtrlIssueRequest xsi:schemaLocation=""http://www.scala.net/WorkOrderMtrlIssueRequest/1.1 http://scshost/schemas/Scala/1.1/WorkOrderMtrlIssueRequest.xsd "" xmlns:msg=""http://Epicor.com/InternalMessage/1.1"" xmlns:dta=""http://www.scala.net/WorkOrderMtrlIssueRequest/1.1"">
					<dta:WorkorderNumber>[WO]</dta:WorkorderNumber>
					<dta:IssueLines>
						<dta:IssueLine>
							<dta:ReportingNumber>[RN]</dta:ReportingNumber>
							<dta:LineNumber>[LN]</dta:LineNumber>
							<dta:StockCode>[STOCK]</dta:StockCode>
							<dta:IssueDate>[DATE]</dta:IssueDate>
							<dta:IssuedQuantity>[QTY]</dta:IssuedQuantity>
							<dta:BatchIssueLines>");
            string stock = data[0]["StockCode"] + "";
            string whfrom = data[0]["Warehouse"] + "";
            string BinCodeFrom = data[0]["Bin"] + "";
            string SupplierBatch = data[0]["SupplierBatch"] + "";
            double qty = double.Parse(data[0]["Qty"] + "");
            export.Replace("[COM]", company);
            export.Replace("[WO]", data[0]["WorkOrder"] + "");
            export.Replace("[RN]", data[0]["ReportNumber"] + "");
            export.Replace("[LN]", data[0]["LineNumber"] + "");
            export.Replace("[STOCK]", data[0]["StockCode"] + "");
            export.Replace("[DATE]", DateTime.Now.ToString("yyyy-MM-dd"));
            export.Replace("[QTY]", data[0]["Qty"] + "");
            string transTemp = @"
								<dta:BatchIssueLine>
									<dta:BatchNumber>{0}</dta:BatchNumber>
									<dta:BinNumber>{1}</dta:BinNumber>
									<dta:BatchIssuedQuantity>{2}</dta:BatchIssuedQuantity>
								</dta:BatchIssueLine>";
            string msg = "";
            List<KeyValuePair<string, double>> list = StockTransactionXml.GetScalaBatch(stock, whfrom, BinCodeFrom, SupplierBatch, qty, company);
            foreach (KeyValuePair<string, double> batch in list)
            {
                export.Append(string.Format(transTemp, batch.Key, BinCodeFrom, batch.Value));
            }

            export.Append(@"
							</dta:BatchIssueLines>
						</dta:IssueLine>
					</dta:IssueLines>
				</dta:WorkOrderMtrlIssueRequest>
			</msg:Dta>
		</msg:Req>
	</msg:Body>
</msg:Msg>
");
            string[] path = SysConfig.GetXMLExportPath(company);
            string filename = "MISSUE" + DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(1000, 9999) + ".xml";
            System.IO.File.WriteAllText(path[0] + filename, export.ToString(), Encoding.Unicode);
            System.IO.File.WriteAllText(path[1] + "bak" + filename, export.ToString(), Encoding.Unicode);

            return result;
        }


        /// <summary>
        /// 导出移库xml文件，数据结构Qty,StockCode,Warehouse,Bin,Company,SupplierBatch,FRNUMBER
        /// </summary>
        /// <param name="data"></param>
        public static string ExportStockIssueXML(List<Hashtable> data)
        {
            string result = "[YES]";
            string company = data[0]["Company"] + "";

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
		<msg:Req msg-type=""Stock Transaction"" action=""Process"">
			<msg:Dta>
				<dta:StockTransaction xsi:schemaLocation=""http://www.scala.net/StockTransaction/1.1 http://scshost/schemas/Scala/1.1/StockTransaction.xsd"" xmlns:msg=""http://Epicor.com/InternalMessage/1.1"" xmlns:dta=""http://www.scala.net/StockTransaction/1.1"">");
            export.Replace("[COM]", company);
            string transTemp = @"
					<dta:Issue>
						<dta:TransDate>{0}</dta:TransDate>
						<dta:Qty>{1}</dta:Qty>
						<dta:StockCode>{2}</dta:StockCode>
						<dta:WhCode>{3}</dta:WhCode>
						<dta:BinCode>{4}</dta:BinCode>
						<dta:SellingPrice>0</dta:SellingPrice>
						<dta:CurrCode>CNY</dta:CurrCode>
						<dta:BatchCode BatchHandlingMethod=""0"">{5}</dta:BatchCode>
						<dta:Ref>{6}</dta:Ref>
					</dta:Issue>";
            string msg = "";
            foreach (Hashtable item in data)
            {
                string stock = item["StockCode"] + "";
                string warehouse = item["Warehouse"] + "";
                string bin = item["Bin"] + "";
                string SupplierBatch = item["SupplierBatch"] + "";
                double qty = double.Parse(item["Qty"] + "");
                List<KeyValuePair<string, double>> list = StockTransactionXml.GetScalaBatch(stock, warehouse, bin, SupplierBatch, qty, company);
                foreach (KeyValuePair<string, double> batch in list)
                {
                    export.Append(string.Format(transTemp, DateTime.Now.ToString("yyyy-MM-dd"), batch.Value, stock, warehouse, bin, batch.Key, item["FRNUMBER"]));
                }
            }

            export.Append(@"
				</dta:StockTransaction>
			</msg:Dta>
		</msg:Req>
	</msg:Body>
</msg:Msg>
");
            string[] path = SysConfig.GetXMLExportPath(company);
            string filename = "TRANSFER" + DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(1000, 9999) + ".xml";
            System.IO.File.WriteAllText(path[0] + filename, export.ToString(), Encoding.Unicode);
            System.IO.File.WriteAllText(path[1] + "bak" + filename, export.ToString(), Encoding.Unicode);

            return result;
        }


        /// <summary>
        /// 导出移库xml文件，数据结构Qty,StockCode,Warehouse,Bin,Company,SupplierBatch,FRNUMBER
        /// </summary>
        /// <param name="data"></param>
        public static string ExportStockReceiptXML(List<Hashtable> data)
        {
            string result = "[YES]";
            string company = data[0]["Company"] + "";

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
		<msg:Req msg-type=""Stock Transaction"" action=""Process"">
			<msg:Dta>
				<dta:StockTransaction xsi:schemaLocation=""http://www.scala.net/StockTransaction/1.1 http://scshost/schemas/Scala/1.1/StockTransaction.xsd"" xmlns:msg=""http://Epicor.com/InternalMessage/1.1"" xmlns:dta=""http://www.scala.net/StockTransaction/1.1"">");
            export.Replace("[COM]", company);
            string transTemp = @"
					<dta:Receipt>
						<dta:TransDate>{0}</dta:TransDate>
						<dta:Qty>{1}</dta:Qty>
						<dta:StockCode>{2}</dta:StockCode>
						<dta:WhCode>{3}</dta:WhCode>
						<dta:BinCode>{4}</dta:BinCode>
						<dta:PurchPrice>0</dta:PurchPrice>
						<dta:CurrCode>CNY</dta:CurrCode>
						<dta:BatchCode BatchHandlingMethod=""1""></dta:BatchCode>
						<dta:SuppBatchCode>{5}</dta:SuppBatchCode>
						<dta:Ref>{6}</dta:Ref>
					</dta:Receipt>";
            string msg = "";
            foreach (Hashtable item in data)
            {
                string stock = item["StockCode"] + "";
                string warehouse = item["Warehouse"] + "";
                string bin = item["Bin"] + "";
                string SupplierBatch = item["SupplierBatch"] + "";
                double qty = double.Parse(item["Qty"] + "");
                export.Append(string.Format(transTemp, DateTime.Now.ToString("yyyy-MM-dd"), qty, stock, warehouse, bin, SupplierBatch, item["FRNUMBER"]));
            }

            export.Append(@"
				</dta:StockTransaction>
			</msg:Dta>
		</msg:Req>
	</msg:Body>
</msg:Msg>
");
            string[] path = SysConfig.GetXMLExportPath(company);
            string filename = "STOCKRECEIVE" + DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(1000, 9999) + ".xml";
            System.IO.File.WriteAllText(path[0] + filename, export.ToString(), Encoding.Unicode);
            System.IO.File.WriteAllText(path[1] + "bak" + filename, export.ToString(), Encoding.Unicode);

            return result;
        }


        /// <summary>
        /// 导出盘点xml文件，数据结构Qty,StockCode,Warehouse,Bin,Company,SupplierBatch
        /// </summary>
        /// <param name="data"></param>
        public static string ExportStockTakenXML(List<Hashtable> data)
        {
            string result = "[YES]";
            string company = data[0]["Company"] + "";

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
		<msg:Req msg-type=""Stock Transaction"" action=""Process"">
			<msg:Dta>
				<dta:StockTransaction xsi:schemaLocation=""http://www.scala.net/StockTransaction/1.1 http://scshost/schemas/Scala/1.1/StockTransaction.xsd"" xmlns:msg=""http://Epicor.com/InternalMessage/1.1"" xmlns:dta=""http://www.scala.net/StockTransaction/1.1"">");
            export.Replace("[COM]", company);
            string transTemp = @"
					<dta:Taking>
						<dta:TransDate>{0}</dta:TransDate>
						<dta:Qty>{1}</dta:Qty>
						<dta:StockCode>{2}</dta:StockCode>
						<dta:WhCode>{3}</dta:WhCode>
						<dta:BinCode>{4}</dta:BinCode>
						<dta:BatchCode BatchHandlingMethod=""1"">{5}</dta:BatchCode>
						<dta:SuppBatchCode>{5}</dta:SuppBatchCode>
					</dta:Taking>";
            string msg = "";
            foreach (Hashtable item in data)
            {
                string stock = item["StockCode"] + "";
                string warehouse = item["Warehouse"] + "";
                string bin = item["Bin"] + "";
                string SupplierBatch = item["SupplierBatch"] + "";
                double qty = double.Parse(item["Qty"] + "");
                export.Append(string.Format(transTemp, DateTime.Now.ToString("yyyy-MM-dd"), qty, stock, warehouse, bin, SupplierBatch));
            }

            export.Append(@"
				</dta:StockTransaction>
			</msg:Dta>
		</msg:Req>
	</msg:Body>
</msg:Msg>
");
            string[] path = SysConfig.GetXMLExportPath(company);
            string filename = "STOCKRECEIVE" + DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(1000, 9999) + ".xml";
            System.IO.File.WriteAllText(path[0] + filename, export.ToString(), Encoding.Unicode);
            System.IO.File.WriteAllText(path[1] + "bak" + filename, export.ToString(), Encoding.Unicode);

            return result;
        }

        public static List<KeyValuePair<string, double>> GetScalaBatch(string stock, string warehouse, string bin, string supplierbatch, double qty, string company)
        {
            List<KeyValuePair<string, double>> list = new List<KeyValuePair<string, double>>();
            string sql = @"SELECT SC33001,SC33002,SC33003,SC33004,SUM(SC33005) SC33005,SC33022,SC33010 FROM SC33[COM]00 WHERE  SC33005<>0 
and SC33001=@stock and SC33002=@wh and SC33004=@sh and (SC33022=@supbatch or SC33009=@supbatch) 
GROUP BY SC33001,SC33002,SC33003,SC33004,SC33022,SC33010 ORDER BY SC33003
select SC01002 FROM SC01[COM]00 WHERE SC01001=@stock";
            sql = sql.Replace("[COM]", company);
            double qtytemp = 0;
            double blockqty = 0;
            BaseAdo ba = new BaseAdo();
            ba.ConnectionStr = SysConfig.DBScalaConnection;
            DataSet ds = ba.GetDataSet(sql, new SqlParameter("@stock", stock), new SqlParameter("@wh", warehouse), new SqlParameter("@sh", bin), new SqlParameter("@supbatch", supplierbatch));
            string stockname = "";
            if (ds.Tables[1].Rows.Count > 0)
                stockname = ds.Tables[1].Rows[0][0] + "";
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                double q = double.Parse(item["SC33005"] + "");
                //if (item["SC33010"] + "" == "0")
                //{
                if (qtytemp + q >= qty)
                {
                    list.Add(new KeyValuePair<string, double>(item["SC33003"] + "", qty - qtytemp));
                    qtytemp = qty;
                    break;
                }
                else
                {
                    list.Add(new KeyValuePair<string, double>(item["SC33003"] + "", q));
                    qtytemp = qtytemp + q;
                }
                //}
                //else
                //    blockqty += q;
            }
            if (qtytemp < qty)
                throw new Exception("物料" + stock + " " + stockname + " 批次" + supplierbatch + " " + warehouse + "_" + bin + " SCALA可移库存仅有" + qtytemp + ",锁住库存" + blockqty);
            return list;
        }
    }

}
