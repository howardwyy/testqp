using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.FG
{
    /// <summary>
    /// FG09	成品发货单ITEM	
    /// </summary>
    [Tablename(TableName = "FG09", PrimaryKey = "FG09001")]
    public class InvoiceDetailModel : BaseSearchModel
    {
        //FG09001	int	主键	主键
        [Columname(Name = "FG09001")]
        public int ID { get; set; }
        //FG09002	int		行号
        [Columname(Name = "FG09002")]
        public int LineNum { get; set; }
        //FG09003	varchar(50)		发货单ID
        [Columname(Name = "FG09002")]
        public string InvoiceID { get; set; }
        //FG09004	datetime	
        [Columname(Name = "FG09004")]
        public DateTime CreateTime { get; set; }
        //FG09005	varchar(50)		操作人id
        [Columname(Name = "FG09005")]
        public string UserID { get; set; }
        //FG09006	nvarchar(50)		操作人name
        [Columname(Name = "FG09006")]
        public string UserName { get; set; }
        //FG09007	varchar(50)		物料号
        [Columname(Name = "FG09007")]
        public string StockID { get; set; }
        //FG09008	nvarchar(50)		物料描述
        [Columname(Name = "FG09008")]
        public string StockName { get; set; }
        //FG09009	numeric(15,3)		发货数量
        [Columname(Name = "FG09009")]
        public decimal InvoiceCount { get; set; }
        //FG09010	nvarchar(10)		单位
        [Columname(Name = "FG09010")]
        public string Unit { get; set; }
        //FG09011	numeric(15,3)		已领数量
        [Columname(Name = "FG09011")]
        public decimal InvoicedCount { get; set; }
        //FG09012	numeric(15,3)		剩余数量
        [Columname(Name = "FG09012")]
        public decimal InvoiceSurplusCount { get; set; }
        //FG09013	numeric(15,3)		from 库存
        [Columname(Name = "FG09013")]
        public decimal fromWHCount { get; set; }
        //FG09014	numeric(15,3)		to 库存
        [Columname(Name = "FG09014")]
        public decimal toWHCount { get; set; }	
    }
}
