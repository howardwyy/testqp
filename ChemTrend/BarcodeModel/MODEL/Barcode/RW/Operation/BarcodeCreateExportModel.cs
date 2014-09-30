using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BarcodeModel.MODEL.Barcode.RW.Operation
{
    public class BarcodeCreateExportModel : BaseSearchModel
    {
        public Byte[] Bytes { get; set; }
        public string FileName { get; set; }
        public override BarcodeModel.MODEL.BaseSearchModel Insert()
        {
            System.IO.File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory + FileName, this.Bytes);
            return this;
        }
    }
}
