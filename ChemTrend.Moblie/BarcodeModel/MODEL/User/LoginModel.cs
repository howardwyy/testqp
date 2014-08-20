using System;
using System.Collections.Generic;
using System.Text;

namespace BarcodeModel.MODEL.User
{
    public class LoginModel : BaseSearchModel
    {
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string UserID { get; set; }
        public string Token { get; set; }
        public bool LoginSuccess { get; set; }
        public string ErrorMsg { get; set; }
        public string IP { get; set; }
        public string ComputerName { get; set; }
        public string LoginType { get; set; }
        public UserModel userModel { get; set; }
        public LoginHistoryModel loginHistoryModel { get; set; }
    }
}
