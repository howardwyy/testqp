using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BarcodeModel.ADO;

namespace BarcodeModel.MODEL.User
{
    [Tablename(TableName = "UR01", PrimaryKey = "UR01001", ViewName = "viewUser")]
    public class UserModel : BaseSearchModel
    {
        [Columname(Name = "UR01001")]
        public string ID { get; set; }

        [Columname(Name = "UR01002")]
        public string UserCode { get; set; }

        [Columname(Name = "UR01003")]
        public string LoginName { get; set; }

        [Columname(Name = "UR01004")]
        public string Password { get; set; }

        [Columname(Name = "UR01005")]
        public string UserName { get; set; }

        [Columname(Name = "UR01006")]
        public string RoleID { get; set; }

        [Columname(Name = "UR02002", canInsert = false, canUpdate = false)]
        public string RoleName { get; set; }

        [Columname(Name = "UR01007")]
        public DateTime CreateTime { get; set; }

        [Columname(Name = "UR01008")]
        public bool Enable { get; set; }

    }
}
