using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BarcodeModel.MODEL.Barcode.FG.Operation
{
    /// <summary>
    /// 成品入库操作
    /// </summary>
    public class InWarehouseFGModel : BaseSearchModel
    {
        public string Warehouse { get; set; }
        public string Bin { get; set; }
        public string Remark { get; set; }
        public string[] Barcodes { get; set; }

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

                ModelAdo<FGBarcodeModel> adoRW = new ModelAdo<FGBarcodeModel>();
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
select @RC=count(FG01001) from FG01 where FG01001 IN ([BIDS]) and FG01032>1
if @RC>0
begin
	set @result=N'不能对已入库的料进行入库操作'
end
set @RC=0
select @RC=count(distinct(FG01033)) from FG01 where FG01001 IN ([BIDS])
if @RC>1
begin
	set @result=N'请对同一工单号进行入库操作'
end
if @result='YES'
begin
    exec PROC_GETID 'FG03',@dj output
	
    insert into FG03(FG03001,FG03002,FG03003,FG03004,FG03005,FG03006,FG03007,FG03008)
    values(@dj,getdate(),@userid,@username,'','','',@Remark)

    insert into FG02(FG02002,FG02003,FG02004,FG02005,FG02010,FG02011)
    select FG01001,getdate(),@userid,@username,@dj,N'入库到'+@whstr from FG01 where FG01001 IN ([BIDS])

    insert into FG04(FG04002,FG04003,FG04004,FG04005)
    select getdate(),@dj,FG01001,N'入库到'+@whstr from FG01 where FG01001 IN ([BIDS])
	
    update FG01 set FG01008=@wh,FG01009=@sh,FG01010=getdate(),FG01024=@userid,FG01025=@username,FG01027=@dj,FG01032=2 where FG01001 IN ([BIDS])	
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
select FG01002,SUM(FG01006) FG01006,FG01033,FG01034,FG01008,FG01009,FG01037,FG01007 from FG01 where FG01001 IN ([BIDS]) 
group by FG01002,FG01033,FG01034,FG01008,FG01009,FG01037,FG01007
select SUM(FG01006) FG01006 from FG01 where FG01001 IN ([BIDS])";

            BaseAdo ba = new BaseAdo();
            DataSet ds = ba.GetDataSet(sql.Replace("[BIDS]", bids));
            if (ds.Tables[0].Rows.Count > 0)
            {
                string company = ds.Tables[0].Rows[0]["FG01037"] + "";
                string ordernum = ds.Tables[0].Rows[0]["FG01033"] + "";

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
                export.Replace("[WH]", ds.Tables[0].Rows[0]["FG01008"] + "");
                export.Replace("[SUMQTY]", ds.Tables[1].Rows[0]["FG01006"] + "");
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
						</dta:ReceiptLine>";
                int i = 0;
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    export.Append(string.Format(receTemp, item["FG01007"], item["FG01008"], DateTime.Now.ToString("yyyy-MM-dd"), item["FG01006"], item["FG01009"]));
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
                string filename = DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(1000, 9999) + ".xml";
                System.IO.File.WriteAllText(path[0] + filename, export.ToString(), Encoding.Unicode);
                System.IO.File.WriteAllText(path[1] + "bak" + filename, export.ToString(), Encoding.Unicode);
            }
        }
    }
}
