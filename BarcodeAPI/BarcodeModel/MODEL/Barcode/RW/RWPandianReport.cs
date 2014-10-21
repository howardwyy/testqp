using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeModel.ADO;

namespace BarcodeModel.MODEL.Barcode.RW
{
    [Tablename(TableName = "RW01", PrimaryKey = "RW01001", ViewName = "view_RW_pandian")]
    public class RWPandianReport : BaseSearchModel
    {
        [Columname(Name = "RW01002")]
        public string StockCode { get; set; }

        [Columname(Name = "RW01003")]
        public string StockName { get; set; }

        [Columname(Name = "RW01001")]
        public string Barcode { get; set; }

        [Columname(Name = "RW01012")]
        public string SupplierCode { get; set; }

        [Columname(Name = "RW01013")]
        public string SupplierName { get; set; }

        [Columname(Name = "RW01035")]
        public string SupplierBatch { get; set; }

        [Columname(Name = "RW01014")]
        public string PO { get; set; }

        [Columname(Name = "RW01015")]
        public string POLineNO { get; set; }

        [Columname(Name = "RW01006")]
        public decimal QTY { get; set; }

        [Columname(Name = "RW01008")]
        public string Warehouse { get; set; }

        [Columname(Name = "RW01009")]
        public string Bin { get; set; }

        [Columname(Name = "pdstatus")]
        public string PDStatus { get; set; }
    }
}
