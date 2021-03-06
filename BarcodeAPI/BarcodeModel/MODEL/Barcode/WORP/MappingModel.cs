﻿using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.WORP
{
    /// <summary>
    /// WK03	工序MAPPING表	
    /// </summary>
    [Tablename(TableName = "WK03", PrimaryKey = "WK03001")]
    public class MappingModel : BaseSearchModel
    {
        //WK03001	int	主键	主键ID
        [Columname(Name = "WK03001")]
        public int ID { get; set; }
        //WK03002	varchar(30)		成品料号
        [Columname(Name = "WK03002")]
        public string FGCode { get; set; }
        //WK03003	nvarchar(50)		成品名称
        [Columname(Name = "WK03003")]
        public string FGName { get; set; }
        //WK03004	varchar(5)		WORKCENTER
        [Columname(Name = "WK03004")]
        public string WorkCenter { get; set; }
        //WK03005	int		BEGIN BOM OP
        [Columname(Name = "WK03005")]
        public string BeginBom { get; set; }
        //WK03006	int		BEGIN BOM OP INDEX
        [Columname(Name = "WK03006")]
        public string BeginBomIndex { get; set; }
        //WK03007	int		END BOM OP
        [Columname(Name = "WK03007")]
        public string EndBom { get; set; }
        //WK03008	int		END BOM OP INDEX
        [Columname(Name = "WK03008")]
        public string EndBomIndex { get; set; }
        //WK03009	int		计算类型(1、计算 2固定)
        [Columname(Name = "WK03009")]
        public int Type { get; set; }
        //WK03010	decimal		固定时间(HOURS)
        [Columname(Name = "WK03010")]
        public decimal Hours { get; set; }

    }
}
