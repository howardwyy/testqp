using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BarcodeModel.MODEL.Barcode.RW
{
    /// <summary>
    /// 原材料领料单
    /// </summary>
    //[Tablename(TableName = "RW08", PrimaryKey = "RW08001")]
    public class ReceiveModel : BaseSearchModel
    {
        //RW08001	varchar(30)	主键	主键 
        public string ID { get; set; }
        //RW08002	datetime		创建时间 
        public DateTime CreateTime { get; set; }
        //RW08003	varchar(50)		操作人id 
        public string UserID { get; set; }
        //RW08004	nvarchar(50)		操作人name 
        public string UserName { get; set; }
        //RW08005	datetime		期望收货日期 
        public DateTime HopeTime { get; set; }
        //RW08006	int		是否紧急 
        public int isUrgent { get; set; }
        //RW08007	nvarchar(100)		备注 
        public string Remark { get; set; }
        //RW08008	int		状态(1已申请 2部分发货 3关闭) 
        public int Status { get; set; }
        //RW08009	varchar(50)		from warehouse 
        public string FromWC { get; set; }
        //RW08010	nvarchar(50)		from warehouse name 
        public string FromWN { get; set; }
        //RW08011	varchar(50)		to warehouse 
        public string ToWC { get; set; }
        //RW08012	nvarchar(50)		to warehouse name 
        public string ToWN { get; set; }
    }

}