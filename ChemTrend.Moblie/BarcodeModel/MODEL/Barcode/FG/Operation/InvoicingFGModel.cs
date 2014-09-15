using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BarcodeModel.MODEL.Barcode.FG.Operation
{
    /// <summary>
    /// 成品发货
    /// </summary>
    public class InvoicingFGModel: BaseSearchModel
    {
        //单据号备注
        public string Remark { get; set; }
        //发货单ID
        public string InvoiceID { get; set; }
        //发货单状态
        public string InvoiceStatus { get; set; }
        //发货单行ID
        public string InvoiceLine { get; set; }
        //发货单行已领数量
        public decimal InvoicedCount { set; get; }
        //发货单行剩余数量
        public decimal InvoiceSurplusCount { set; get; }
        //发货单行关联条码信息
        public string[] Barcodes { get; set; }
       
    }
}
