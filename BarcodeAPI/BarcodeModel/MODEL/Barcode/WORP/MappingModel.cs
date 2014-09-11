using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeModel.ADO;

namespace BarcodeModel.MODEL.Barcode.WORP
{
    [Tablename(TableName = "WK03", PrimaryKey = "WK03001")]
    public class MappingModel : BaseSearchModel
    {
        [Columname(Name = "WK03001")]
        public int ID { get; set; }

        [Columname(Name = "WK03002")]
        public string StockCode { get; set; }

        [Columname(Name = "WK03003")]
        public string StockName { get; set; }

        [Columname(Name = "WK03004")]
        public string Workcenter { get; set; }

        [Columname(Name = "WK03005")]
        public int BeginOP { get; set; }

        [Columname(Name = "WK03006")]
        public int BeginOPindex { get; set; }

        [Columname(Name = "WK03007")]
        public int EndOP { get; set; }

        [Columname(Name = "WK03008")]
        public int EndOPindex { get; set; }

        [Columname(Name = "WK03009")]
        public int CalType { get; set; }

        [Columname(Name = "WK03010")]
        public float Hours { get; set; }
    }
}
