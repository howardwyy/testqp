using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.WORP
{
    [Tablename(TableName = "WK02", PrimaryKey = "WK02001")]
    public class ReportModel
    {
        [Columname(Name = "WK02001")]
        public int ID { get; set; }

        [Columname(Name = "WK02003")]
        public string StockCode { get; set; }

        [Columname(Name = "WK02004")]
        public string StockName { get; set; }

        [Columname(Name = "WK02002")]
        public string Workorder { get; set; }

        [Columname(Name = "WK02010")]
        public string Workcenter { get; set; }

        [Columname(Name = "WK02006")]
        public string BOMOP { get; set; }

        [Columname(Name = "WK02007")]
        public string BOMOPINDEX { get; set; }

        [Columname(Name = "WK02005")]
        public decimal DeQTY { get; set; }//需扣料数量

        [Columname(Name = "WK02008")]
        public DateTime DeDate { get; set; }//上次扣料时间

        [Columname(Name = "WK02009")]
        public decimal HadDeQTY { get; set; }//已扣料数量

        [Columname(Name = "WK02011")]
        public int HadDe { get; set; }
    }
}
