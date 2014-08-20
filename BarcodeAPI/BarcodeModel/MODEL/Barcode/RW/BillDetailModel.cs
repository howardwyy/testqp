using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.RW
{
    /// <summary>
    /// 原材料单据明细表
    /// </summary>
    [Tablename(TableName = "RW04", PrimaryKey = "RW04001", ViewName = "viewBillDetails")]
    public class BillDetailModel : BaseSearchModel
    {

        //RW04001	int	主键	主键
        [Columname(Name = "RW04001")]
        public int ID { set; get; }
        //RW04002	datetime		操作时间
        [Columname(Name = "RW04002")]
        public DateTime CreateTime { set; get; }
        //RW04003	varchar(50)		单据ID
        [Columname(Name = "RW04003")]
        public string BillID { set; get; }
        //RW04004	varchar(50)		条码ID
        [Columname(Name = "RW04004")]
        public string BarcodeID { set; get; }
        //RW04005	varchar(50)		操作备注
        [Columname(Name = "RW04005")]
        public string Remark { set; get; }

        //RW01002	varchar(50)		物料stockcode
        [Columname(Name = "RW01002", canInsert = false, canUpdate = false)]
        public string StockCode { get; set; }

        //RW01003	nvarchar(100)		物料name
        [Columname(Name = "RW01003", canInsert = false, canUpdate = false)]
        public string StockName { get; set; }

        //RW01004	nvarchar(100)		物料规格
        [Columname(Name = "RW01004", canInsert = false, canUpdate = false)]
        public string StockSpec { get; set; }

        //RW01005	nvarchar(10)		单位
        [Columname(Name = "RW01005", canInsert = false, canUpdate = false)]
        public string StockUnit { get; set; }

        //RW01006	numeric(15,3)		包装量
        [Columname(Name = "RW01006", canInsert = false, canUpdate = false)]
        public decimal StockUnitQty { get; set; }

        //RW01007	varchar(50)		批次
        [Columname(Name = "RW01007", canInsert = false, canUpdate = false)]
        public string StockBatch { get; set; }

    }
}
