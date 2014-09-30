using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.RW
{
    /// <summary>
    /// RW20	原材料发货单BARCODE	
    /// </summary>
    [Tablename(TableName = "RW20", PrimaryKey = "RW20001")]
    public class RWInvoiceBarcodeModel : BaseSearchModel
    {
        //RW20001	int	主键	主键
        [Columname(Name = "RW20001")]
        public int ID { get; set; }
        //RW20002	datetime		发货时间
        [Columname(Name = "RW20002")]
        public DateTime InvoiceTime { get; set; }
        //RW20003	varchar(50)		操作人id
        [Columname(Name = "RW20003")]
        public string UserID { get; set; }
        //RW20004	nvarchar(50)		操作人name
        [Columname(Name = "RW20004")]
        public string UserName { get; set; }
        //RW20005	varchar(50)		发货单ID
        [Columname(Name = "RW20005")]
        public string InvoiceID { get; set; }
        //RW20006	varchar(50)		发货单行ID
        [Columname(Name = "RW20006")]
        public string LineNum { get; set; }
        //RW20007	varchar(50)		原材料标签ID
        [Columname(Name = "RW20007")]
        public string Barcode { get; set; }

    }
}
