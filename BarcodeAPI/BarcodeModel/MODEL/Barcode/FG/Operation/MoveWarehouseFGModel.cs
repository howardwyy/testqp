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
    /// 成品 移库操作
    /// </summary>
    public class MoveWarehouseFGModel : BaseSearchModel
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
select @RC=count(FG01001) from FG01 where FG01001 IN ([BIDS]) and FG01032 <> 2
if @RC>0
begin
	set @result=N'请仅对已入库的料进行移库操作'
end

if @result='YES'
begin
    exec PROC_GETID 'FG03',@dj output
	
    insert into FG03(FG03001,FG03002,FG03003,FG03004,FG03005,FG03006,FG03007,FG03008)
    values(@dj,getdate(),@userid,@username,'','','',@Remark)

    insert into FG02(FG02002,FG02003,FG02004,FG02005,FG02010,FG02011)
    select FG01001,getdate(),@userid,@username,@dj,N'移库到'+@whstr from FG01 where FG01001 IN ([BIDS])

    insert into FG04(FG04002,FG04003,FG04004,FG04005)
    select getdate(),@dj,FG01001,N'移库到'+@whstr from FG01 where FG01001 IN ([BIDS])
	
    update FG01 set FG01016 =FG01008 ,FG01017 = FG01009,FG01008=@wh,FG01009=@sh,FG01024=@userid,FG01025=@username,FG01027=@dj,FG01032=2 where FG01001 IN ([BIDS])	
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
select FG01016,FG01017,FG01008,FG01009,FG01002,SUM(FG01006) FG01006,FG01007,FG01037 from FG01 where FG01001 IN ([BIDS]) 
group by FG01016,FG01017,FG01008,FG01009,FG01002,FG01007,FG01034
";

            BaseAdo ba = new BaseAdo();
            DataSet ds = ba.GetDataSet(sql.Replace("[BIDS]", bids));
            if (ds.Tables[0].Rows.Count > 0)
            {
                string company = ds.Tables[0].Rows[0]["FG01037"] + "";

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
						<dta:BinCodeTo>{4}</dta:BinCodeTo>
						<dta:WhCodeTo>{5}</dta:WhCodeTo>
						<dta:BinCodeFrom>{6}</dta:BinCodeFrom>
						<dta:BatchCode BatchHandlingMethod=""1"">{7}</dta:BatchCode>
					</dta:Movement>";
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    export.Append(string.Format(transTemp, DateTime.Now.ToString("yyyy-MM-dd"), item["FG01006"], item["FG01002"], item["FG01016"], item["FG01008"], item["FG01009"], item["FG01017"], item["FG01007"]));
                }

                export.Append(@"
				</dta:StockTransaction>
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

