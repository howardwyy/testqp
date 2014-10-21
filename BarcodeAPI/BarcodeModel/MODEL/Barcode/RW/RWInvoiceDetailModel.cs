using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.RW
{
    /// <summary>
    /// RW19	原材料发货单ITEM	
    /// </summary>
    [Tablename(TableName = "RW19", PrimaryKey = "RW19001")]
    public class RWInvoiceDetailModel : BaseSearchModel
    {

        [Columname(Name = "RW19001")]
        public int ID { get; set; }

        [Columname(Name = "RW19002")]
        public string LineNum { get; set; }

        [Columname(Name = "RW19003")]
        public string DeliveryNumber { get; set; }

        [Columname(Name = "RW19004")]
        public DateTime CreateTime { get; set; }

        [Columname(Name = "RW19005")]
        public string UserID { get; set; }

        [Columname(Name = "RW19006")]
        public string UserName { get; set; }

        [Columname(Name = "RW19007")]
        public string StockID { get; set; }

        [Columname(Name = "RW19008")]
        public string StockName { get; set; }

        [Columname(Name = "RW19009")]
        public decimal TotalDeliveryQTY { get; set; }

        [Columname(Name = "RW19010")]
        public string Unit { get; set; }

        [Columname(Name = "RW19011")]
        public decimal DeliveredQTY { get; set; }

        [Columname(Name = "RW19012")]
        public decimal DeliveringQTY { get; set; }

        [Columname(Name = "RW19013")]
        public string Warehouse { get; set; }

        [Columname(Name = "RW19014")]
        public string Batch { get; set; }
    }
}
