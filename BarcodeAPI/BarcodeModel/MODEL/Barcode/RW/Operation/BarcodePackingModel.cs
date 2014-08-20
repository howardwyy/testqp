using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BarcodeModel.MODEL.Barcode.RW.Operation
{
    /// <summary>
    /// 条码装箱操作
    /// </summary>
    public class BarcodePackingModel : BaseSearchModel
    {
        public RWBarcodeModel[] RWBarcodeModels { get; set; }
        public PackingModel packingModel { get; set; }
        public string Remark { get; set; }
        public string ReturnMsg { get; set; }
        public bool ReturnSuccess { get; set; }
        public override BaseSearchModel Insert()
        {
            using (TransactionScope ts = new TransactionScope())
            {
                //修改条码中对应装箱ID信息
                ModelAdo<RWBarcodeModel> apiBarcode = new ModelAdo<RWBarcodeModel>();
                //添加历史记录
                ModelAdo<RWHistoryModel> adoBarcodeHistroy = new ModelAdo<RWHistoryModel>(); 
                foreach (RWBarcodeModel item in RWBarcodeModels)
                {
                    item.BoxID = packingModel.ID;
                    apiBarcode.Update(item);

                    //创建条码历史记录【Add】
                    RWHistoryModel historyModel = new RWHistoryModel()
                    {
                        CreateTime = DateTime.Now,
                        BillID = "",
                        BarcodeID = item.ID,
                        Remark = Remark
                    };
                    adoBarcodeHistroy.Insert(historyModel);   
                }

                //修改barcode的条码状态
                ModelAdo<PackingModel> apiPacking = new ModelAdo<PackingModel>();
                packingModel.Status = 2;
                apiPacking.Update(packingModel);

                 

                ts.Complete();
            }
            return this;
        }

    }
}
