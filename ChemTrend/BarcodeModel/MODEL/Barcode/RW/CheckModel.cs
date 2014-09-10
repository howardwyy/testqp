using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.RW
{
    /// <summary>
    /// 原材料盘点明细表
    /// </summary>
    [Tablename(TableName = "RW12", PrimaryKey = "RW12001")]
    public class CheckModel : BaseSearchModel
    {

        //RW12001	int	主键	主键
        [Columname(Name = "RW12001")]
        public int ID { get; set; }
        //RW12002	datetime		盘点时间
        [Columname(Name = "RW12002")]
        public DateTime CreateTime { get; set; }
        //RW12003	varchar(50)		操作人id
        [Columname(Name = "RW12003")]
        public string UserID { get; set; }
        //RW12004	nvarchar(50)		操作人name
        [Columname(Name = "RW12004")]
        public string UserName { get; set; }
        //RW12005	varchar(50)		盘点计划ID
        [Columname(Name = "RW12005")]
        public string PlanID { get; set; }
        //RW12006	varchar(50)		条码ID
        [Columname(Name = "RW12006")]
        public string BarcodeID { get; set; }


    }

}
