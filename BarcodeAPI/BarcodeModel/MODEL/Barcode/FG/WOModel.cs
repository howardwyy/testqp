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

        [Columname(Name = "SC01002")]
        public string StcokName { get; set; }

        [Columname(Name = "SC01003")]
        public string StcokSpec { get; set; }

        [Columname(Name = "UNIT")]
        public string Unit { get; set; }

        [Columname(Name = "SC01072")]
        public decimal UnitQty { get; set; }

        [Columname(Name = "MP64004")]
        public decimal PlanQTY { get; set; }

        [Columname(Name = "MP64005")]
        public decimal AcQty { get; set; }

        [Columname(Name = "Company")]
        public string Company { get; set; }

        public int BarcodeQty { get; set; }
        public DateTime ProductDate { get; set; }
        public int LifeDate { get; set; }//保质期天数，ProductDate+LifeDate等于实际保质期
        public string PageCode { get; set; }

    }
}
