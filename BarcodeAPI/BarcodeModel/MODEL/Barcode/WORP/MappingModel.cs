<<<<<<< HEAD
﻿using BarcodeModel.ADO;
using System;
=======
﻿using System;
>>>>>>> origin/master
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD

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
        public int BeginBom { get; set; }
        //WK03006	int		BEGIN BOM OP INDEX
        [Columname(Name = "WK03006")]
        public int BeginBomIndex { get; set; }
        //WK03007	int		END BOM OP
        [Columname(Name = "WK03007")]
        public int EndBom { get; set; }
        //WK03008	int		END BOM OP INDEX
        [Columname(Name = "WK03008")]
        public int EndBomIndex { get; set; }
        //WK03009	int		计算类型(1、计算 2固定)
        [Columname(Name = "WK03009")]
        public int Type { get; set; }
        //WK03010	decimal		固定时间(HOURS)
        [Columname(Name = "WK03010")]
        public decimal Hours { get; set; }

=======
using BarcodeModel.ADO;

namespace BarcodeModel.MODEL.Barcode.WORP
{
    [Tablename(TableName = "WK03", PrimaryKey = "WK03001")]
    public class MappingModel : BaseSearchModel
    {
        [Columname(Name = "WK03001")]
        public int ID { get; set; }

        [Columname(Name = "WK03002")]
        public string StockCode { get; set; }

        [Columname(Name = "WK03003")]
        public string StockName { get; set; }

        [Columname(Name = "WK03004")]
        public string Workcenter { get; set; }

        [Columname(Name = "WK03005")]
        public int BeginOP { get; set; }

        [Columname(Name = "WK03006")]
        public int BeginOPindex { get; set; }

        [Columname(Name = "WK03007")]
        public int EndOP { get; set; }

        [Columname(Name = "WK03008")]
        public int EndOPindex { get; set; }

        [Columname(Name = "WK03009")]
        public int CalType { get; set; }

        [Columname(Name = "WK03010")]
        public float Hours { get; set; }
>>>>>>> origin/master
    }
}
