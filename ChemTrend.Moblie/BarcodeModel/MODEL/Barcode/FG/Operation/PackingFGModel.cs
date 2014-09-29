
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BarcodeModel.MODEL.Barcode.FG.Operation
{
    //装箱
    public class PackingFGModel : BaseSearchModel
    {
        public string PackingID { get; set; }
        public string[] Barcodes { get; set; }
        public int Status { get; set; }
       
    }
}
