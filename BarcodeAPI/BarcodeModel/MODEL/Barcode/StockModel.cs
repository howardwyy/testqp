using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode
{
    /// <summary>
    /// 物料
    /// </summary>
    [Tablename(TableName = "view_Stock", PrimaryKey = "SC01001", ViewName = "view_Stock", IsScalaDB = true)]
    public class StockModel : BaseSearchModel
    {
        [Columname(Name = "SC01001")]
        public string StockCode { get; set; }

        [Columname(Name = "SC01002")]
        public string StockName { get; set; }

        [Columname(Name = "SC01003")]
        public string StockSpec { get; set; }

        [Columname(Name = "UNIT")]
        public string Unit { get; set; }

        [Columname(Name = "Company")]
        public string Company { get; set; }
    }
}
