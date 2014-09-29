using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BarcodeModel.MODEL.Barcode.WORP.Operation
{
    public class WOLineReportModel : BaseSearchModel
    {
        public int ReportLineID { get; set; }
        public string RWID { get; set; }
        public float DeQTY { get; set; }
        public string WorkOrder { get; set; }
    }
}
