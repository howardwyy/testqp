using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode
{
    [Tablename(TableName = "SC00", PrimaryKey = "SC00001", ViewName = "view_customer", IsScalaDB = true)]
    public class CustomerModel : BaseSearchModel
    {
        [Columname(Name = "SC00001")]
        public string CustomerCode { get; set; }
        [Columname(Name = "SC00002")]
        public string CustomerName{ get; set; }
    }
}
