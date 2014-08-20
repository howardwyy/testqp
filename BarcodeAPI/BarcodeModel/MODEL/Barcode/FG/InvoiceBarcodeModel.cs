using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.FG
{
    /// <summary>
    /// FG10	成品发货单BARCODE	
    /// </summary>
    [Tablename(TableName = "FG10", PrimaryKey = "FG10001")]
    public class InvoiceBarcodeModel : BaseSearchModel
    {
        //FG10001	int	主键	主键
        [Columname(Name = "FG10001")]
        public int ID { get; set; }
        //FG10002	datetime		发货时间
        [Columname(Name = "FG10002")]
        public DateTime InvoiceTime { get; set; }
        //FG10003	varchar(50)		操作人id
        [Columname(Name = "FG10003")]
        public string UserID { get; set; }
        //FG10004	nvarchar(50)		操作人name
        [Columname(Name = "FG10004")]
        public string UserName { get; set; }
        //FG10005	varchar(50)		发货单ID
        [Columname(Name = "FG10005")]
        public string InvoiceID { get; set; }
        //FG10006	varchar(50)		发货单行ID
        [Columname(Name = "FG10006")]
        public string LineNum { get; set; }
        //FG10007	varchar(50)		成品标签ID
        [Columname(Name = "FG10007")]
        public string Barcode { get; set; }
         
    }
}
