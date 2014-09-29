using BarcodeModel.ADO;
using BarcodeModel.MODEL.Barcode.RW;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BarcodeModel.MODEL.Barcode.FG.Operation
{
    /// <summary>
    /// 创建成品条码
    /// </summary>
    public class CreateFGModel : BaseSearchModel
    {


        private static Object lockobj = new object();
        public WOModel[] WOModels { get; set; }

        //订单明细操作说明
        public string BillRemark { get; set; }

        //应用于返回结果，处理打印功能
        //public RWBarcodeModel[] RWBarcodeModels { get; set; }
        public string[] ReturnIDS { get; set; }

        public override BarcodeModel.MODEL.BaseSearchModel Insert()
        {
            lock (lockobj)
            {
                try
                {
                    using (TransactionScope ts = new TransactionScope())
                    {
                        BaseAdo ba = new BaseAdo();
                        string sql = @"
declare @dj varchar(30)
exec PROC_GETID 'FG03',@dj output
select @dj t";
                        DataSet dsdj = ba.GetDataSet(sql);
                        string dj = "";
                        if (dsdj != null && dsdj.Tables[0].Rows.Count > 0)
                            dj = dsdj.Tables[0].Rows[0][0] + "";
                        int count = 0;
                        foreach (WOModel item in this.WOModels)
                        {
                            item.LoginUserID = this.LoginUserID;
                            item.LoginUserName = this.LoginUserName;
                            item.Danju = dj;
                            item.WorkOrder = item.WorkOrder;
                            item.Insert();
                            count += item.BarcodeQty;
                        }
                        DataSet ds = ba.GetDataSet("select top " + count + " FG01001 from FG01 order by FG01001 desc");
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            string[] ids = new string[ds.Tables[0].Rows.Count];
                            for (int i = 0; i < ids.Length; i++)
                            {
                                ids[i] = ds.Tables[0].Rows[i][0] + "";
                            }
                            this.ReturnIDS = ids;
                        }
                        ts.Complete();
                        return this;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

    }
}