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
        //RW19001	int	主键	主键
        [Columname(Name = "RW19001")]
        public int ID { get; set; }
        //RW19002	int		行号
        [Columname(Name = "RW19002")]
        public int LineNum { get; set; }
        //RW19003	varchar(50)		发货单ID
        [Columname(Name = "RW19003")]
        public string InvoiceID { get; set; }
        //RW19004	datetime	
        [Columname(Name = "RW19004")]
        public DateTime CreateTime { get; set; }
        //RW19005	varchar(50)		操作人id
        [Columname(Name = "RW19005")]
        public string UserID { get; set; }
        //RW19006	nvarchar(50)		操作人name
        [Columname(Name = "RW19006")]
        public string UserName { get; set; }
        //RW19007	varchar(50)		物料号
        [Columname(Name = "RW19007")]
        public string StockID { get; set; }
        //RW19008	nvarchar(50)		物料描述
        [Columname(Name = "RW19008")]
        public string StockName { get; set; }
        //RW19009	numeric(15,3)		发货数量
        [Columname(Name = "RW19009")]
        public decimal InvoiceCount { get; set; }
        //RW19010	nvarchar(10)		单位
        [Columname(Name = "RW19010")]
        public string Unit { get; set; }
        //RW19011	numeric(15,3)		已领数量
        [Columname(Name = "RW19011")]
        public decimal InvoicedCount { get; set; }
        //RW19012	numeric(15,3)		剩余数量
        [Columname(Name = "RW19012")]
        public decimal InvoiceSurplusCount { get; set; }
        //RW19013	numeric(15,3)		from 库存
        [Columname(Name = "RW19013")]
        public decimal fromWHCount { get; set; }
        //RW19014	numeric(15,3)		to 库存
        [Columname(Name = "RW19014")]
        public decimal toWHCount { get; set; }
    }
}
