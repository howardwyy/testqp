using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BarcodeModel.MODEL.Barcode.FG.Operation
{
    /// <summary>
    /// 移库
    /// </summary>
    public class MoveWarehouseModel : BaseSearchModel
    {
        public string Warehouse { get; set; }
        public string Bin { get; set; }
        public string Remark { get; set; }
        public string[] Barcodes { get; set; }
    }
}
