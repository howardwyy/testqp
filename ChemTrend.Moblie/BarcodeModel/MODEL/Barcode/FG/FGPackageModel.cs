
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarcodeModel.MODEL.Barcode.FG
{
    public class FGPackageModel : BaseSearchModel
    {
        //RW07001	varchar(30)	主键	主键
        public string ID { get; set; }

        //RW07002	datetime		创建时间
        public DateTime CreateTime { get; set; }

        //RW07003	varchar(50)		操作人id
        public string UserId { get; set; }

        //RW07004	nvarchar(50)		操作人name
        public string UserName { get; set; }

        //RW07005	int		类型(1一次性 2多次)
        public int Type { get; set; }

        //RW07006	varchar(50)		stockcode(有代表只能装这个物料)
        public string StockCode { get; set; }

        //RW07007	int		可以装多少个标签(0代表无穷 其他按数量)
        public int Total { get; set; }

        //RW07008	int		状态(1.未使用；2.使用中；3，使用完)
        public int Status { get; set; }


    }
}
