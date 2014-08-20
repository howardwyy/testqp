
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarcodeModel.MODEL.Barcode.RW.Operation
{
    /// <summary>
    /// 条码仓库处理；入库，移库
    /// </summary>
    public class BarcodeWarehouse: BaseSearchModel
    {
        public RWBarcodeModel[] RWBarcodeModels { get; set; }
        public int Status { get; set; }
        public string Warehouse { get; set; }
        public string Location { get; set; }
        public string Remark { get; set; }

        public string ReturnMsg { get; set; }
        public bool ReturnSuccess { get; set; }
      
    }
}
