using System;
using System.Collections.Generic;
using System.Text;
using BarcodeModel.MODEL;

namespace BarcodeModel.MODEL.User
{
    public class RoleModel : BaseSearchModel
    {
        public string ID { get; set; }

        public string RoleName { get; set; }

        public string Remark { get; set; }

    }
}
