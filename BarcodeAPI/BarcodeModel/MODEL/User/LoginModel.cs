using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BarcodeModel.ADO;
using System.Data.SqlClient;

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

        public override BaseSearchModel Insert()
        {

            ModelAdo<UserModel> adoUser = new ModelAdo<UserModel>();
            userModel = adoUser.GetModel("UR01003=@loginName and UR01004=@pass", "", new SqlParameter("@loginName", this.LoginName), new SqlParameter("@pass", this.Password));
            if (userModel != null)
            {

                ModelAdo<LoginHistoryModel> adoLH = new ModelAdo<LoginHistoryModel>();
                loginHistoryModel = adoLH.GetModel("UR05002=@id and UR05005=1", "*", new SqlParameter("@id", userModel.ID));
                if (loginHistoryModel != null)
                {
                    this.ErrorMsg = string.Format("用户{0}已在其他{1}终端登录，请先退出", userModel.UserName, loginHistoryModel.LoginType);
                    this.LoginSuccess = false;
                }
                else
                {
                    string id = Guid.NewGuid().ToString();
                    loginHistoryModel = new LoginHistoryModel()
                    {
                        ID = id,
                        LoginTime = DateTime.Now,
                        LogoutTime = DateTime.Now,
                        ComputerName = this.ComputerName,
                        IP = this.IP,
                        LoginStatus = 1,
                        LoginType = this.LoginType,
                        UserID = userModel.ID
                    };
                    int result = adoLH.Insert(loginHistoryModel);
                    if (result == 1)
                    {
                        this.Token = id;
                        this.UserID = userModel.ID;
                        this.LoginSuccess = true;
                    }
                }
            }
            else
            {
                this.LoginSuccess = false;
                this.ErrorMsg = "用户名或密码不正确";
            }
            return this;
        }
    }
}
