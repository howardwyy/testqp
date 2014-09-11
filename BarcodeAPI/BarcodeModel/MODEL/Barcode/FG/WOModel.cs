using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.FG
{
    [Tablename(TableName = "view_WO", PrimaryKey = "MP64001", ViewName = "view_WO", IsScalaDB = true)]
    public class WOModel:BaseSearchModel
    {
        [Columname(Name="MP64001")]
        public string WorkOrder { get; set; }

        [Columname(Name = "MP64002")]
        public string StockCode { get; set; }

        [Columname(Name = "MP64004")]
        public decimal PlanQTY { get; set; }

        [Columname(Name = "MP64005")]
        public decimal Acqty { get; set; }

        [Columname(Name = "Company")]
        public string Company { get; set; }
    }
}
