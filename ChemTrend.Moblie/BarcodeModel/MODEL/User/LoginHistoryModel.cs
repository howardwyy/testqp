using System;
using System.Collections.Generic;
using System.Text;

namespace BarcodeModel.MODEL.User
{
    public class LoginHistoryModel : BaseSearchModel
    {
        public string ID { get; set; }

        public DateTime LoginTime { get; set; }

        public string UserID { get; set; }

        public string UserLoginName { get; set; }

        public string UserName { get; set; }

        public string UserCode { get; set; }

        public DateTime LogoutTime { get; set; }

        public int LoginStatus { get; set; }

        public string ComputerName { get; set; }

        public string IP { get; set; }

        public string LoginType { get; set; }
    }
}
