using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BarcodeModel.MODEL.Barcode.FG.Operation
{
    /// <summary>
    /// 成品发货
    /// </summary>
    public class DeliveryBarcodeModel: BaseSearchModel
    {
        public string DeliveryID { get; set; }
        public string[] Barcodes { get; set; }
       
    }
}
