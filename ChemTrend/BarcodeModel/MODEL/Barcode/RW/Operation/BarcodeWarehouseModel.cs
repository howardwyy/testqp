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
    /// 条码仓库处理；入库，移库
    /// </summary>
    public class BarcodeWarehouseModel: BaseSearchModel
    {
        public RWBarcodeModel[] RWBarcodeModels { get; set; }
        public int Status { get; set; }
        public string Warehouse { get; set; }
        public string Location { get; set; }
        public string Remark { get; set; }

        public string ReturnMsg { get; set; }
        public bool ReturnSuccess { get; set; }

        public override BaseSearchModel Insert()
        {
            using (TransactionScope ts = new TransactionScope())
            {
                //创建新的单据号
                ModelAdo<BillModel> adoBill = new ModelAdo<BillModel>();
                //创建新的单据号详情
                ModelAdo<BillDetailModel> adoBillDetail = new ModelAdo<BillDetailModel>();
                //添加历史记录
                ModelAdo<RWHistoryModel> adoBarcodeHistroy = new ModelAdo<RWHistoryModel>(); 
                BillModel billModel = new BillModel()
                {
                    CreateTime = DateTime.Now,
                    UserId = "",
                    UserName = "",
                    Flowkey = "",
                    FlowName = "",
                    RequisitionId = "",
                    Remark = Remark
                };
                adoBill.Insert(billModel);

                
                
                //修改条码信息
                foreach (RWBarcodeModel item in RWBarcodeModels)
                {
                    item.Location = Location;
                    item.Status = Status;
                    item.Warehouse = Warehouse;
                    item.WarehouseInTime = DateTime.Now;
                    item.Bill = billModel.ID;
                    item.Status = Status;
                    item.Update(item);

                     //创建新的单据详情信息
                    BillDetailModel billDetailModel = new BillDetailModel()
                    {
                        CreateTime = DateTime.Now,
                        BarcodeID = item.ID,
                        BillID = billModel.ID,
                        Remark = billModel.Remark
                    };
                    adoBillDetail.Insert(billDetailModel);

                    //创建条码历史记录【Add】
                    RWHistoryModel historyModel = new RWHistoryModel()
                    {
                        CreateTime = DateTime.Now,
                        BillID = billModel.ID,
                        BarcodeID = item.ID,
                        Remark = billModel.Remark
                    };
                    adoBarcodeHistroy.Insert(historyModel);          
                }

                ts.Complete();
            }
            return this;
        }
    }
}
