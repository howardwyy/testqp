using System;
using System.Collections.Generic;
using System.Text;

namespace BarcodeModel.MODEL.User
{
    public class UserModel : BaseSearchModel
    {
        public string ID { get; set; }

        public string UserCode { get; set; }

        public string LoginName { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public string RoleID { get; set; }

        public string RoleName { get; set; }

        public DateTime CreateTime { get; set; }

        public bool Enable { get; set; }
    }
}
