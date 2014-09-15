using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BarcodeModel.MODEL.Barcode.RW
{
    /// <summary>
    /// 原材料领料单ITEM
    /// </summary>
    //[Tablename(TableName = "RW09", PrimaryKey = "RW09001", ViewName = "")]
    public class ReceiveDetailModel : BaseSearchModel
    {

        //RW09001	int	主键	主键
        //[Columname(Name = "RW09001")]
        public int ID { set; get; }
        //RW09002	int		行号
        //[Columname(Name = "RW09002")]
        public int LineID { set; get; }
        //RW09003	varchar(50)		领料单ID
        //[Columname(Name = "RW09003")]
        public string ReceiveID { set; get; }
        //RW09004	datetime		创建时间
        //[Columname(Name = "RW09004")]
        public DateTime CreateTime { set; get; }
        //RW09005	varchar(50)		操作人id
        //[Columname(Name = "RW09005")]
        public string UserID { set; get; }
        //RW09006	nvarchar(50)		操作人name
        //[Columname(Name = "RW09006")]
        public string UserName { set; get; }
        //RW09007	varchar(50)		物料号
        //[Columname(Name = "RW09007")]
        public string StockCode { set; get; }
        //RW09008	nvarchar(50)		物料描述
        //[Columname(Name = "RW09008")]
        public string StockName { set; get; }
        //RW09009	numeric(15,3)		领料数量
        //[Columname(Name = "RW09009")]
        public decimal ReceiveCount { set; get; }
        //RW09010	nvarchar(10)		单位
        //[Columname(Name = "RW09010")]
        public string ReceiveUnit { set; get; }
        //RW09011	numeric(15,3)		已领数量
        //[Columname(Name = "RW09011")]
        public decimal ReceivedCount { set; get; }
        //RW09012	numeric(15,3)		剩余数量
        //[Columname(Name = "RW09012")]
        public decimal ReceivedSurplusCount { set; get; }
        //RW09013	numeric(15,3)		from 库存
        //[Columname(Name = "RW09013")]
        public decimal FromCount { set; get; }
        //RW09014	numeric(15,3)		to 库存
        //[Columname(Name = "RW09014")]
        public decimal ToCount { set; get; }
    }
}