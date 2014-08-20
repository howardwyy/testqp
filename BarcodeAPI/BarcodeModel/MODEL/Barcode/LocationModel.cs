using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeModel.ADO;

namespace BarcodeModel.MODEL.Barcode
{
    [Tablename(TableName = "SC36", PrimaryKey = "SC36001", ViewName = "view_warehouse", IsScalaDB = true)]
    public class LocationModel : BaseSearchModel
    {
        [Columname(Name = "SC36001")]
        public string Warehouse { get; set; }
        [Columname(Name = "SC36002")]
        public string Location { get; set; }
        [Columname(Name = "SC36003")]
        public string LocationName { get; set; }
        [Columname(Name = "Company")]
        public string Company { get; set; }
    }
}
