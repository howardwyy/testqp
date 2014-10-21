using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarcodeModel.MODEL.Barcode.FG
{
    [Tablename(TableName = "view_SOLine", PrimaryKey = "OR01001", ViewName = "view_SODeliveryLine", IsScalaDB = true)]
    public class SODeliveryLineModel : BaseSearchModel
    {
        [Columname(Name = "OR01001")]
        public string OrderNumber { get; set; }

        [Columname(Name = "OR03002")]
        public string LineNumber { get; set; }

        [Columname(Name = "OR03005")]
        public string StockCode { get; set; }

        [Columname(Name = "OR03006")]
        public string StockName { get; set; }

        [Columname(Name = "OR03007")]
        public string StockSpec { get; set; }

        [Columname(Name = "OR01035")]
        public string StockType { get; set; }

        [Columname(Name = "UNIT")]
        public string Unit { get; set; }

        [Columname(Name = "OR03011")]
        public decimal OrderQty { get; set; }

        [Columname(Name = "OR01003")]
        public string CustomerCode { get; set; }

        [Columname(Name = "SL01002")]
        public string CustomerName { get; set; }

        [Columname(Name = "Company")]
        public string Company { get; set; }

        [Columname(Name = "OR01015")]
        public DateTime OrderDate { get; set; }

        [Columname(Name = "OR03008")]
        public decimal Price { get; set; }

        [Columname(Name = "OR03046")]
        public string Warehouse { get; set; }
    }
}
