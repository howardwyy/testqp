using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode
{
    /// <summary>
    /// 工作中心
    /// </summary>
    [Tablename(TableName = "MP50", PrimaryKey = "MP50001", ViewName = "view_WorkCenter", IsScalaDB = true)]
    public class WorkCenterModel:BaseSearchModel
    {
        [Columname(Name = "MP50001")]
        public string WorkcenterCode { get; set; }

        [Columname(Name = "MP50002")]
        public string WorkcenterName { get; set; }

        [Columname(Name = "Company")]
        public string Company { get; set; }
    }
}
