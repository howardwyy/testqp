using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BarcodeModel.ADO;
using System.Transactions;
using System.Data;
using System.Data.SqlClient;

namespace BarcodeModel.MODEL.Barcode.RW.Operation
{
    public class USBarcodeImportModel : BaseSearchModel
    {
        private static Object objLock = new object();
        public Byte[] Bytes { get; set; }
        public string FileName { get; set; }
        public List<USBarcodeModel> ReturnUSBarcodes { get; set; }
        public List<USBarcodeGroup> ReturnUSBarcodeGroups { get; set; }
        public string IMPNO { get; set; }
        public override BarcodeModel.MODEL.BaseSearchModel Insert()
        {
            lock (objLock)
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    BaseAdo ba = new BaseAdo();
                    BaseAdo bascala = new BaseAdo() { ConnectionStr = SysConfig.DBScalaConnection };
                    string sqlpo = @"
select * from view_poline where PC01001=@po and SC01003=@stockspec and Company=@company
select * from view_Stock where SC01003=@stockspec and Company=@company
";
                    string sql = @"
insert into RW13(RW13002,RW13003,RW13004,RW13005,RW13006,RW13007,RW13008,RW13009,RW13010,RW13011,RW13012,RW13013,RW13014,RW13015,RW13016,RW13017,RW13018,RW13019,RW13020,RW13021,RW13022)
values(getdate(),@IMPNO,@userid,@po,@poline,@stockcode,@stockname,@stockspec,@lpn,@supplierbatch,@productdate,@exdate,@qty,@unit,@company,@boxid,@supcode,@supname,@pounit,@saleunit,@stocktype)";

                    string strImport = System.Text.Encoding.ASCII.GetString(this.Bytes);
                    string[] strImportLine = strImport.Replace("\r", " ").Split('\n');
                    IMPNO = Guid.NewGuid().ToString();
                    for (int i = 1; i < strImportLine.Length; i++)
                    {
                        string BarcodeId = "";//导入文件中获取
                        string PackageId = "";//导入文件中获取
                        string StockCode = "";
                        string StockName = "";
                        string StockSpec = "";//导入文件中获取
                        string StockUnit = "";//导入文件中获取
                        string PO = "";//导入文件中获取
                        decimal StockUnitQty = 0;//导入文件中获取
                        string Company = "";//导入文件中获取
                        string SupplierBatch = "";//导入文件中获取
                        string supplierCode = "";
                        string supplierName = "";
                        double purunit = 1;
                        double saleunit = 1;
                        string stockType = "02";
                        string poline = "";
                        DateTime ProductionTime = DateTime.Now;//导入文件中获取
                        DateTime ValidityTime = DateTime.Now;//导入文件中获取

                        string[] strImprotLineItem = strImportLine[i].Split(';');
                        switch (strImprotLineItem[0])
                        {
                            case "11117": Company = "31"; break;
                            case "11116": Company = "32"; break;
                            default: Company = "-"; break;
                        }
                        PO = strImprotLineItem[2];
                        StockSpec = strImprotLineItem[3];
                        PackageId = strImprotLineItem[5];
                        BarcodeId = strImprotLineItem[6];
                        SupplierBatch = strImprotLineItem[7];
                        StockUnitQty = decimal.Parse(strImprotLineItem[10]);
                        DateTime.TryParse(strImprotLineItem[15], out ProductionTime);
                        DateTime.TryParse(strImprotLineItem[16], out ValidityTime);

                        DataSet ds = bascala.GetDataSet(sqlpo, new SqlParameter("@Company", Company), new SqlParameter("@stockspec", StockSpec), new SqlParameter("@po", PO));
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            poline = ds.Tables[0].Rows[0]["PC03002"] + "";
                            supplierCode = ds.Tables[0].Rows[0]["PL01001"] + "";
                            supplierName = ds.Tables[0].Rows[0]["PL01002"] + "";
                        }
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            double.TryParse(ds.Tables[1].Rows[0]["SC01072"] + "", out purunit);
                            double.TryParse(ds.Tables[1].Rows[0]["SC01073"] + "", out saleunit);
                            stockType = ds.Tables[1].Rows[0]["SC01035"] + "";
                            StockCode = ds.Tables[1].Rows[0]["SC01001"] + "";
                            StockName = ds.Tables[1].Rows[0]["SC01002"] + "";
                            StockUnit = ds.Tables[1].Rows[0]["UNIT"] + "";
                        }
                        ba.ExecuteSql(sql, new SqlParameter("@IMPNO", IMPNO),
                            new SqlParameter("@userid", this.LoginUserID),
                            new SqlParameter("@po", PO),
                            new SqlParameter("@poline", poline),
                            new SqlParameter("@stockcode", StockCode),
                            new SqlParameter("@stockname", StockName),
                            new SqlParameter("@stockspec", StockSpec),
                            new SqlParameter("@lpn", BarcodeId),
                            new SqlParameter("@supplierbatch", SupplierBatch),
                            new SqlParameter("@productdate", ProductionTime),
                            new SqlParameter("@exdate", ValidityTime),
                            new SqlParameter("@qty", StockUnitQty),
                            new SqlParameter("@unit", StockUnit),
                            new SqlParameter("@company", Company),
                            new SqlParameter("@boxid", PackageId),
                            new SqlParameter("@supcode", supplierCode),
                            new SqlParameter("@supname", supplierName),
                            new SqlParameter("@pounit", purunit),
                            new SqlParameter("@saleunit", saleunit),
                            new SqlParameter("@stocktype", stockType));


                    }
                    ModelAdo<USBarcodeModel> adoUB = new ModelAdo<USBarcodeModel>();
                    this.ReturnUSBarcodes = adoUB.GetList("RW13003=@impno", "", "", new SqlParameter("@impno", IMPNO));
                    ModelAdo<USBarcodeGroup> adoUBG = new ModelAdo<USBarcodeGroup>();
                    this.ReturnUSBarcodeGroups = adoUBG.GetList("RW13003=@impno", "", "", new SqlParameter("@impno", IMPNO));
                    ts.Complete();

                }
            }
            return this;
        }
    }
    [Tablename(TableName = "RW13", PrimaryKey = "RW13001")]
    public class USBarcodeModel : BaseSearchModel
    {
        [Columname(Name = "RW13001")]
        public int ID { get; set; }

        [Columname(Name = "RW13003")]
        public int IMPNO { get; set; }

        [Columname(Name = "RW13005")]
        public string PO { get; set; }

        [Columname(Name = "RW13006")]
        public string POLine { get; set; }

        [Columname(Name = "RW13007")]
        public string StockCode { get; set; }

        [Columname(Name = "RW13008")]
        public string StockName { get; set; }

        [Columname(Name = "RW13014")]
        public string QTY { get; set; }

        [Columname(Name = "RW13018")]
        public string SupplierCode { get; set; }

        [Columname(Name = "RW13019")]
        public string SupplierName { get; set; }

        [Columname(Name = "RW13010")]
        public string LPN { get; set; }

        [Columname(Name = "RW13011")]
        public string SupplierBatch { get; set; }
        //生产日期

        [Columname(Name = "RW13012")]
        public DateTime ProductionTime { get; set; }

        //有效期

        [Columname(Name = "RW13013")]
        public DateTime ValidityTime { set; get; }


        [Columname(Name = "RW13015")]
        public string Unit { get; set; }
    }

    [Tablename(TableName = "view_USBarcodeGroup", PrimaryKey = "RW13011")]
    public class USBarcodeGroup : BaseSearchModel
    {
        [Columname(Name = "RW13003")]
        public int IMPNO { get; set; }

        [Columname(Name = "RW13005")]
        public string PO { get; set; }

        [Columname(Name = "RW13006")]
        public string POLine { get; set; }

        [Columname(Name = "RW13007")]
        public string StockCode { get; set; }

        [Columname(Name = "RW13008")]
        public string StockName { get; set; }

        [Columname(Name = "RW13014")]
        public string QTY { get; set; }

        [Columname(Name = "RW13018")]
        public string SupplierCode { get; set; }

        [Columname(Name = "RW13019")]
        public string SupplierName { get; set; }

        [Columname(Name = "RW13011")]
        public string SupplierBatch { get; set; }

        [Columname(Name = "RW13015")]
        public string Unit { get; set; }
    }

    public class USBarcodeSubmitModel : BaseSearchModel
    {
        public string IMPNO { get; set; }
        public List<USBarcodeModel> ReturnUSBarcodes { get; set; }
        public List<USBarcodeGroup> ReturnUSBarcodeGroups { get; set; }
        public override BaseSearchModel Insert()
        {
            using (TransactionScope ts = new TransactionScope())
            {
                string sql = @"
declare @dj varchar(30)
exec PROC_GETID 'RW03',@dj output
--单据头
insert into RW03(RW03001,RW03002,RW03003,RW03004,RW03005,RW03006,RW03007,RW03008)
values(@dj,getdate(),@userid,@username,'','','',N'US导入创建条码')
--装箱标签
insert into RW07(RW07001,RW07002,RW07003,RW07004,RW07005,RW07006,RW07007,RW07008)
select RW13017,getdate(),@userid,@username,0,'',0,2 from RW13 where RW13003=@impno and isnull(RW13006,'')<>'' and isnull(RW13017,'')<>'' and isnull(RW13007,'')<>'' and RW13010 not in (select RW01001 from RW01) group by RW13017
--单据明细
insert into RW04(RW04002,RW04003,RW04004,RW04005)
select getdate(),@dj,RW13010,N'US导入创建条码' from RW13 where RW13003=@impno and isnull(RW13006,'')<>'' and isnull(RW13007,'')<>'' and RW13010 not in (select RW01001 from RW01)
--历史记录
insert into RW02(RW02002,RW02003,RW02004,RW02005,RW02010,RW02011) 
select RW13010,getdate(),@userid,@username,@dj,N'US导入创建条码' from RW13 where RW13003=@impno and isnull(RW13006,'')<>'' and isnull(RW13007,'')<>'' and RW13010 not in (select RW01001 from RW01)
--原材料
insert into RW01(RW01001,RW01002,RW01003,RW01004,RW01005,RW01006,RW01012,RW01013,RW01014,RW01015,RW01024,RW01025,RW01027,RW01031,RW01032,RW01034,RW01035,RW01037,RW01038,RW01041,RW01043,RW01044,RW01045)
select RW13010,RW13007,RW13008,RW13009,RW13015,RW13014,RW13018,RW13019,RW13005,RW13006,@userid,@username,@dj,RW13017,1,RW13016,RW13011,RW13012,RW13013,RW13022,'PO',RW13020,RW13021
from RW13 where RW13003=@impno and isnull(RW13006,'')<>'' and isnull(RW13007,'')<>'' and RW13010 not in (select RW01001 from RW01)
--删除成功的
delete from RW13 where RW13010 in (select RW01001 from RW01)
";
                BaseAdo ba = new BaseAdo();
                ba.ExecuteSql(sql, new SqlParameter("@userid", this.LoginUserID), new SqlParameter("@username", this.LoginUserName), new SqlParameter("@impno", IMPNO));

                ModelAdo<USBarcodeModel> adoUB = new ModelAdo<USBarcodeModel>();
                this.ReturnUSBarcodes = adoUB.GetList("RW13003=@impno", "", "", new SqlParameter("@impno", IMPNO));
                ModelAdo<USBarcodeGroup> adoUBG = new ModelAdo<USBarcodeGroup>();
                this.ReturnUSBarcodeGroups = adoUBG.GetList("RW13003=@impno", "", "", new SqlParameter("@impno", IMPNO));
                ts.Complete();
                return this;
            }
        }
    }
}
