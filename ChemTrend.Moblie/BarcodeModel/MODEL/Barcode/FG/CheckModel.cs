using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BarcodeModel.MODEL.Barcode.FG
{
    /// <summary>
    /// 原材料盘点明细表
    /// </summary>
    ///[Tablename(TableName = "FG12", PrimaryKey = "FG12001")]
    public class CheckModel : BaseSearchModel
    {

        //FG12001	int	主键	主键
        //[Columname(Name = "FG12001")]
        public int ID { get; set; }
        //FG12002	datetime		盘点时间
        //[Columname(Name = "FG12002")]
        public DateTime CreateTime { get; set; }
        //FG12003	varchar(50)		操作人id
        //[Columname(Name = "FG12003")]
        public string UserID { get; set; }
        //FG12004	nvarchar(50)		操作人name
        //[Columname(Name = "FG12004")]
        public string UserName { get; set; }
        //FG12005	varchar(50)		盘点计划ID
        //[Columname(Name = "FG12005")]
        public string PlanID { get; set; }
        //FG12006	varchar(50)		条码ID
        //[Columname(Name = "FG12005")]
        public string BarcodeID { get; set; }


    }
 
}
