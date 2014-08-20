using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Transactions;
using System.Data;

namespace BarcodeModel.MODEL.Barcode.RW.Operation
{
    public class BarcodeCreateModel : BaseSearchModel
    {
        private static Object lockobj = new object();
        public POLineModel[] POLineModels { get; set; }
        //订单明细操作说明
        public string BillRemark { get; set; }

        //应用于返回结果，处理打印功能
        //public RWBarcodeModel[] RWBarcodeModels { get; set; }
        public string[] ReturnIDS { get; set; }
        //public override BaseSearchModel Insert()
        //{
        //    using (TransactionScope ts = new TransactionScope())
        //    {
        //        //创建单据号
        //        ModelAdo<BillModel> adoBill = new ModelAdo<BillModel>();
        //        BillModel billModel = new BillModel()
        //        {
        //            CreateTime = DateTime.Now,
        //            UserId = "",
        //            UserName = "",
        //            Flowkey = "",
        //            FlowName = "",
        //            RequisitionId = "",
        //            Remark = BillRemark
        //        };
        //        adoBill.Insert(billModel);

        //        List<RWBarcodeModel> listBarcode = new List<RWBarcodeModel>();
        //        foreach (POLineModel item in POLineModels)
        //        {
        //            item.billModel = billModel;
        //            item.Insert();
        //            listBarcode.AddRange(item.RWBarcodeModels);
        //        }
        //        this.RWBarcodeModels = listBarcode.ToArray();
        //        ts.Complete();
        //    }
        //    return this;
        //}
        public override BarcodeModel.MODEL.BaseSearchModel Insert()
        {
            lock (lockobj)
            {
                try
                {
                    using (TransactionScope ts = new TransactionScope())
                    {
                        int count = 0;
                        foreach (POLineModel item in this.POLineModels)
                        {
                            item.Insert();
                            count += item.BarcodeQTY;
                        }
                        BaseAdo ba = new BaseAdo();
                        DataSet ds = ba.GetDataSet("select top " + count + " RW01001 from RW01 order by RW01001 desc");
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
