using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BarcodeModel.ADO;
using BarcodeModel.MODEL;

namespace BarcodeModel.MODEL.User
{
    [Tablename(TableName = "UR02", PrimaryKey = "UR02001")]
    public class RoleModel : BaseSearchModel
    {
        [Columname(Name = "UR02001")]
        public string ID { get; set; }

        [Columname(Name = "UR02002")]
        public string RoleName { get; set; }

        [Columname(Name = "UR02003")]
        public string Remark { get; set; }

    }
}
