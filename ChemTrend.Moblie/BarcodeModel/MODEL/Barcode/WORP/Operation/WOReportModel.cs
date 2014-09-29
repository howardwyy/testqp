using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BarcodeModel.MODEL.Barcode.FG;
using BarcodeModel.MODEL.Barcode.RW;

namespace BarcodeModel.MODEL.Barcode.WORP.Operation
{
    public class WOReportModel : BaseSearchModel
    {
        public string Workorder { get; set; }
        public List<ReportModel> ReturnReportList { get; set; }
       
    }
}
