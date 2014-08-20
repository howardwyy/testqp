using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.RW.Operation
{
    /// <summary>
    /// 条码销毁动作
    /// </summary>
    public class BarcodeDestoryModel : BaseSearchModel
    {
        public RWBarcodeModel[] RWBarcodeModels { get; set; }
        public int Status { get; set; }
        public string Remark { get; set; }
        public string ReturnMsg { get; set; }
        public bool ReturnSuccess { get; set; }
        public override int Update(BaseSearchModel model)
        {
            try
            {
                foreach (RWBarcodeModel item in RWBarcodeModels)
                {
                    //修改条码信息
                    ModelAdo<RWBarcodeModel> adoBarcode = new ModelAdo<RWBarcodeModel>();
                    item.Status = Status;
                    adoBarcode.Update(item);

                    //添加条码历史记录
                    ModelAdo<RWHistoryModel> adoBarcodeHistroy = new ModelAdo<RWHistoryModel>();
                    RWHistoryModel historyModel = new RWHistoryModel()
                    {
                        CreateTime = DateTime.Now,
                        BillID = "",
                        BarcodeID = item.ID,
                        Remark = Remark
                    };
                    adoBarcodeHistroy.Insert(historyModel);
                }
            }
            catch (Exception)
            {
                return 0;
            }

            return 1;
        }

    }
}
