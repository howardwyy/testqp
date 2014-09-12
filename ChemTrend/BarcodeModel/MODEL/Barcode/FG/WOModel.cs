using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.FG
{
    [Tablename(TableName = "view_WO", PrimaryKey = "MP64001", ViewName = "view_WO", IsScalaDB = true)]
    public class WOModel : BaseSearchModel
    {

        [Columname(Name = "MP64001")]
        public string WorkOrder { get; set; }

        [Columname(Name = "MP64002")]
        public string StockCode { get; set; }

        [Columname(Name = "SC01002")]
        public string StockName { get; set; }

        [Columname(Name = "SC01003")]
        public string StockSpec { get; set; }

        [Columname(Name = "UNIT")]
        public string Unit { get; set; }

        [Columname(Name = "SC01072")]
        public decimal UnitQty { get; set; }

        //实际数量 
        [Columname(Name = "MP64004")]
        public decimal PlanQTY { get; set; }


        //计划数量 
        [Columname(Name = "MP64005")]
        public decimal AcQty { get; set; }

        [Columname(Name = "Company")]
        public string Company { get; set; }


        public int BarcodeQty { get; set; }
        public DateTime ProductDate { get; set; }
        //保质期天数，ProductDate+LifeDate等于实际保质期
        public int LifeDate { get; set; }
        public string PageCode { get; set; }
        public string Remark { get; set; }
        public string Danju { get; set; }//创建时的统一单据号

    }
}
