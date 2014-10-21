using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Transactions;
using BarcodeModel.ADO;
using System.Data;
using System.Data.SqlClient;

namespace BarcodeModel.MODEL.Barcode.RW.Operation
{
    public class BarcodeCreateImportModel : BaseSearchModel
    {
        private static Object objLock = new object();
        public Byte[] Bytes { get; set; }
        public string FileName { get; set; }
        public string test { get; set; }
        public override BarcodeModel.MODEL.BaseSearchModel Insert()
        {
            //①：解析获取的文件数据，依据每行来读取。
            //②：替换对应公司，17-31,16-32[[不存在回滚]]
            //③：替换PART_CODE，通过SC01003，找到对应的StockName，StockCode[不存在回滚]
            //④：条码编号：[存在回滚]
            //⑤：是否存在装箱号条码。有：判断装箱条码中是否存在，如果存在：直接并入该装箱号条码。如果不存在：新建
            //⑥：插入原材料：   1：插入，父单据号表；
            //                   2：插入，子单据号明细表；
            //                   3：插入，原材料条码表；
            //                   4：插入，条码历史记录表； 


            lock (objLock)
            {

                using (TransactionScope ts = new TransactionScope())
                {
                    try
                    {

                        BaseAdo ba = new BaseAdo();
                        string sql = @"
declare @billid varchar(30)
exec PROC_GETID 'RW03',@billid output
--单据头
insert into RW03(RW03001,RW03002,RW03003,RW03004,RW03005,RW03006,RW03007,RW03008)
values(@billid,getdate(),@userid,@username,'','','',N'创建条码')
select @billid t";
                        DataSet dsBillId = ba.GetDataSet(sql, new SqlParameter("@userid", this.LoginUserID),
                                new SqlParameter("@username", this.LoginUserName));
                        string BillId = ""; //总单据号
                        if (dsBillId != null && dsBillId.Tables[0].Rows.Count > 0)
                        {
                            BillId = dsBillId.Tables[0].Rows[0][0] + "";
                        }

                        string strImport = System.Text.Encoding.ASCII.GetString(this.Bytes);
                        string[] strImportLine = strImport.Replace("\r", " ").Split('\n');
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
                            DateTime ProductionTime = DateTime.Now;//导入文件中获取
                            DateTime ValidityTime = DateTime.Now;//导入文件中获取


                            string[] strImprotLineItem = strImportLine[i].Split(';');
                            if (strImprotLineItem[0].Contains("17"))
                            {
                                Company = "31";
                            }
                            else if (strImprotLineItem[0].Contains("16"))
                            {
                                Company = "32";
                            }
                            else
                            {
                                throw new Exception("未找到相对应的公司信息！");
                            }
                            PO = strImprotLineItem[2];
                            StockSpec = strImprotLineItem[3];
                            PackageId = strImprotLineItem[5];
                            BarcodeId = strImprotLineItem[6];
                            SupplierBatch = strImprotLineItem[7];
                            StockUnitQty = decimal.Parse(strImprotLineItem[10]);
                            DateTime.TryParse(strImprotLineItem[15], out ProductionTime);
                            DateTime.TryParse(strImprotLineItem[16], out ValidityTime);

                            ModelAdo<RWBarcodeModel> adoBarcode = new ModelAdo<RWBarcodeModel>();
                            RWBarcodeModel rwModel = adoBarcode.GetModelByID(BarcodeId);
                            if (rwModel != null && rwModel.ID.Length >= 1)
                            {
                                throw new Exception(BarcodeId + "已存在于条码系统中！");
                            }
                            if (!string.IsNullOrEmpty(PackageId))
                            {
                                ModelAdo<PackingModel> adoPackage = new ModelAdo<PackingModel>();
                                PackingModel packageModel = adoPackage.GetModelByID(PackageId);
                                if (packageModel != null)
                                {

                                }
                                else
                                {
                                    string sqlPackage = @" 
--装箱单
insert into RW07(RW07001,RW07002,RW07003,RW07004,RW07005,RW07006,RW07007,RW07008)
values(@packageid,getdate(),@userid,@username,0,'',0,2)";
                                    ba.ExecuteSql(sqlPackage, new SqlParameter("packageid", PackageId),
                                            new SqlParameter("@userid", this.LoginUserID),
                                            new SqlParameter("@username", this.LoginUserName));
                                }
                            }




                            ModelAdo<StockModel> adoStock = new ModelAdo<StockModel>();
                            List<StockModel> Stocks = adoStock.GetList("SC01003=@stockspec", "", "", new SqlParameter("@stockspec", StockSpec));
                            if (Stocks != null && Stocks.Count >= 1)
                            {
                                StockCode = Stocks[0].StockCode;
                                StockName = Stocks[0].StockName;
                                StockUnit = Stocks[0].Unit;
                                StockUnitQty = Stocks[0].UQTY;
                            }
                            else
                            {
                                //throw new Exception("未找到相对应的物料信息！");
                                continue;
                            }




                            string barcodeSql = @"
--单据明细
insert into RW04(RW04002,RW04003,RW04004,RW04005) values(getdate(),@billid,@barcodeid,N'创建条码')
--历史记录
insert into RW02(RW02002,RW02003,RW02004,RW02005,RW02010,RW02011) 
values(@barcodeid,getdate(),@userid,@username,@billid,N'创建条码标签')
--原材料
insert into RW01(RW01001,RW01002,RW01003,RW01004,RW01005,RW01006,RW01014,RW01024,RW01025,RW01027,RW01031,RW01032,RW01034,RW01035,RW01037,RW01038,RW01040,RW01041,RW01043)
values(@barcodeid,@stock,@stockname,@stockspec,@unit,@qty,@po,@userid,@username,@billid,@packageid,1,@company,@supplierbatch,@productiontime ,@validitytime,@tqty,@stype,'PO')
";

                            ba.ExecuteSql(barcodeSql, new SqlParameter("@userid", this.LoginUserID),
                                new SqlParameter("@username", this.LoginUserName),
                                new SqlParameter("@stock", StockCode),
                                new SqlParameter("@stockname", StockName),
                                new SqlParameter("@barcodeid", BarcodeId),
                                new SqlParameter("@stockspec", StockSpec),
                                new SqlParameter("@packageid", PackageId),
                                new SqlParameter("@unit", StockUnit),
                                new SqlParameter("@qty", StockUnitQty),
                                new SqlParameter("@tqty", Stocks[0].UQTY),
                                new SqlParameter("@po", PO),
                                new SqlParameter("@stype", Stocks[0].StockType),
                                new SqlParameter("@company", Company),
                                new SqlParameter("@supplierbatch", SupplierBatch),
                                new SqlParameter("@productiontime", ProductionTime),
                                new SqlParameter("@validitytime", ValidityTime),
                                new SqlParameter("@billid", BillId));
                        }
                        ts.Complete();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return this;
        }
    }
}
