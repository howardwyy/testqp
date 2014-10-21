using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarcodeModel.MODEL.Barcode.WORP
{

    [Tablename(TableName = "WK01", PrimaryKey = "WK01001")]
    public class WOWK01Model
    {
        [Columname(Name = "WK01001")]
        public string WorkOrder { get; set; }

        [Columname(Name = "WK01002")]
        public string StockCode { get; set; }

        [Columname(Name = "WK01003")]
        public string StockName { get; set; }

        [Columname(Name = "WK01004")]
        public decimal QTY { get; set; }

        [Columname(Name = "WK01005", canInsert = false, canUpdate = false)]
        public DateTime BeginDate { get; set; }

        [Columname(Name = "WK01006", canInsert = false, canUpdate = false)]
        public DateTime EndDate { get; set; }

        [Columname(Name = "WK01007")]
        public decimal TotalHour { get; set; }

        [Columname(Name = "WK01008")]
        public int Status { get; set; }
    }
}
