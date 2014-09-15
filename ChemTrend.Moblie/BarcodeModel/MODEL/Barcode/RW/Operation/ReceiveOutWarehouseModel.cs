using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BarcodeModel.MODEL.Barcode.RW.Operation
{
    /// <summary>
    /// 领料出库
    /// </summary>
    public class ReceiveOutWarehouseModel : BaseSearchModel
    {
        //仓库号
        public string Warehouse { get; set; }
        //库位号
        public string Bin { get; set; }
        //单据号备注
        public string Remark { get; set; }
        //领料单ID
        public string ReceiveID { get; set; }
        //领料单状态
        public string ReceiveStatus { get; set; }
        //领料单行ID
        public string ReceiveLine { get; set; }
        //领料单行已领数量
        public decimal ReceivedCount { set; get; }
        //领料单行剩余数量
        public decimal ReceiveSurplusCount { set; get; }
        //领料单行关联条码信息
        public string[] Barcodes { get; set; }

    }
}
