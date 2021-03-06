﻿using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.RW
{
    /// <summary>
    /// 成品单据明细表
    /// </summary>
    [Tablename(TableName = "FG04", PrimaryKey = "FG04001", ViewName = "viewFGBillDetails")]
    public class FGBillDetailModel : BaseSearchModel
    {

        //FG04001	int	主键	主键
        [Columname(Name = "FG04001")]
        public int ID { set; get; }
        //FG04002	datetime		操作时间
        [Columname(Name = "FG04002")]
        public DateTime CreateTime { set; get; }
        //FG04003	varchar(50)		单据ID
        [Columname(Name = "FG04003")]
        public string BillID { set; get; }
        //FG04004	varchar(50)		条码ID
        [Columname(Name = "FG04004")]
        public string BarcodeID { set; get; }
        //FG04005	varchar(50)		操作备注
        [Columname(Name = "FG04005")]
        public string Remark { set; get; }
        //FG01002	varchar(50)		物料stockcode
        [Columname(Name = "FG01002", canInsert = false, canUpdate = false)]
        public string StockCode { get; set; }

        //FG01003	nvarchar(100)		物料name
        [Columname(Name = "FG01003", canInsert = false, canUpdate = false)]
        public string StockName { get; set; }

        //FG01004	nvarchar(100)		物料规格
        [Columname(Name = "FG01004", canInsert = false, canUpdate = false)]
        public string StockSpec { get; set; }

        //FG01005	nvarchar(10)		单位
        [Columname(Name = "FG01005", canInsert = false, canUpdate = false)]
        public string StockUnit { get; set; }

        //FG01006	numeric(15,3)		包装量
        [Columname(Name = "FG01006", canInsert = false, canUpdate = false)]
        public decimal StockUnitQty { get; set; }

        //FG01007	varchar(50)		批次
        [Columname(Name = "FG01007", canInsert = false, canUpdate = false)]
        public string StockBatch { get; set; }

    }
}
