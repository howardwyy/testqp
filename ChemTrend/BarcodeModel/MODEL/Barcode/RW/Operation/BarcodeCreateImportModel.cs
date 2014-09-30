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
            //②：替换对应公司，17-31,16-32
            //③：替换PART_CODE，通过SC01003，找到对应的StockName，StockCode
            //④：是否存在装箱号条码。有：判断装箱条码中是否存在，如果存在：直接并入该装箱号条码。如果不存在：新建
            //⑤：插入原材料：   1：插入，父单据号表；
            //                   2：插入，子单据号明细表；
            //                   3：插入，原材料条码表；
            //                   4：插入，条码历史记录表；

            string strImport = System.Text.Encoding.ASCII.GetString(this.Bytes);
            string[] strImportLine = strImport.Split('\\');
            this.test = strImportLine.Length + "test";

            //            lock (objLock)
            //            {
            //                try
            //                {
            //                    using (TransactionScope ts = new TransactionScope())
            //                    {

            //                        BaseAdo ba = new BaseAdo();
            //                        string sql = @"
            //declare @billid varchar(30)
            //exec PROC_GETID 'RW03',@billid output
            //--单据头
            //insert into RW03(RW03001,RW03002,RW03003,RW03004,RW03005,RW03006,RW03007,RW03008)
            //values(@billid,getdate(),@userid,@username,'','','',N'创建条码')
            //select @billid t";
            //                        DataSet dsBillId = ba.GetDataSet(sql);
            //                        string BillId = ""; //总单据号
            //                        if (dsBillId != null && dsBillId.Tables[0].Rows.Count > 0)
            //                        {
            //                            BillId = dsBillId.Tables[0].Rows[0][0] + "";
            //                        }

            //                        string str = System.Text.Encoding.ASCII.GetString(this.Bytes);

            //                        string BarcodeId = "";//导入文件中获取
            //                        string StockCode = "";
            //                        string StockName = "";
            //                        string StockSpec = "";//导入文件中获取
            //                        string StockUnit = "";//导入文件中获取
            //                        string PO = "";//导入文件中获取
            //                        decimal StockUnitQty = 0;//导入文件中获取
            //                        string Company = "";//导入文件中获取
            //                        string SupplierBatch = "";//导入文件中获取
            //                        DateTime ProductionTime = DateTime.Now;//导入文件中获取
            //                        DateTime ValidityTime = DateTime.Now;//导入文件中获取


            //                        ModelAdo<StockModel> adoStock = new ModelAdo<StockModel>();
            //                        List<StockModel> Stokcs = adoStock.GetList("SC01003=@stockspec", "", "", new SqlParameter("@stockspec", StockSpec));
            //                        if (Stokcs != null && Stokcs.Count >= 1)
            //                        {
            //                            StockCode = Stokcs[0].StockCode;
            //                            StockName = Stokcs[0].StockName;
            //                        }

            //                        string barcodeSql = @"
            //--单据明细
            //insert into RW04(RW04002,RW04003,RW04004,RW04005) values(getdate(),@billid,@barcodeid,N'创建条码')
            //--历史记录
            //insert into RW02(RW02002,RW02003,RW02004,RW02005,RW02010,RW02011) 
            //values(@barcodeid,getdate(),@userid,@username,@billid,N'创建条码标签')
            //--原材料
            //insert into RW01(RW01001,RW01002,RW01003,RW01004,RW01005,RW01006,RW01014,RW01024,RW01025,RW01027,RW01032,RW01034,RW01035,RW01037,RW01038)
            //values(@barcodeid,@stock,@stockname,@stockspec,@unit,@qty,,@po,@userid,@username,@billid,1,@company,@supplierbatch,@productiontime ,@validitytime)
            //";

            //                        ba.ExecuteSql(sql, new SqlParameter("@userid", this.LoginUserID),
            //                            new SqlParameter("@username", this.LoginUserName),
            //                            new SqlParameter("@stock", StockCode),
            //                            new SqlParameter("@stockname", StockName),
            //                            new SqlParameter("@stockspec", StockSpec),
            //                            new SqlParameter("@unit", StockUnit),
            //                            new SqlParameter("@qty", StockUnitQty),
            //                            new SqlParameter("@po", PO),
            //                            new SqlParameter("@company", Company),
            //                            new SqlParameter("@supplierbatch", SupplierBatch),
            //                            new SqlParameter("@productiontime", ProductionTime),
            //                            new SqlParameter("@validitytime", ValidityTime),
            //                            new SqlParameter("@billid", BillId));

            //                        ts.Complete();

            //                    }
            //                }
            //                catch (Exception ex)
            //                {
            //                    throw ex;
            //                }
            //            }
            return this;
        }
    }
}
