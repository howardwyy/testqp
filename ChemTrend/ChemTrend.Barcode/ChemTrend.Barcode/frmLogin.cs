using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BarcodeModel.API;
using BarcodeModel.MODEL;
using BarcodeModel.MODEL.User;
using DevExpress.XtraEditors.DXErrorProvider;
using ChemTrend.Barcode.Utils;
using ChemTrend.Barcode.Data;

namespace ChemTrend.Barcode
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void sbtn_login_Click(object sender, EventArgs e)
        {
            try
            {



                string EncryptPwd = DESEncryptUtil.Encrypt(this.te_password.Text);
                string EncryptUserName = DESEncryptUtil.Encrypt(this.te_username.Text);
                if (dxvp_username.Validate() && dxvp_pwd.Validate())
                {

                    LoginModel lm = new LoginModel()
                    {
                        LoginName = te_username.Text,
                        Password = EncryptPwd,
                    };
                    ModelAPI<LoginModel> api = new ModelAPI<LoginModel>();
                    LoginModel resultModel = api.Insert<LoginModel>(lm);
                    if (resultModel.LoginSuccess)
                    {
                        //存储当前登陆用户信息
                        string AFileName = System.Environment.CurrentDirectory + "/" + AppConfig.IniFilePath;
                        IniFilesUtil iniFilesUtil = new IniFilesUtil(AFileName);
                        iniFilesUtil.WriteString(AppConfig.Section.Login.ToString(), AppConfig.Ident.UserName.ToString(), EncryptUserName);
                        iniFilesUtil.WriteString(AppConfig.Section.Login.ToString(), AppConfig.Ident.Password.ToString(), EncryptPwd);
                        iniFilesUtil.WriteString(AppConfig.Section.Login.ToString(), AppConfig.Ident.ID.ToString(), resultModel.userModel.ID);
                        iniFilesUtil.WriteString(AppConfig.Section.Login.ToString(), AppConfig.Ident.HisID.ToString(), resultModel.loginHistoryModel.ID);
                        //赋值给Token
                        BaseAPI.AccessToken = resultModel.Token;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {

                        DevExpress.XtraEditors.XtraMessageBox.Show(resultModel.ErrorMsg, "确认", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
                
            }

        }

        private void sbtn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            InitValidationRules();

            InitData();
        }

        private void InitData()
        {
            string AFileName = System.Environment.CurrentDirectory + "/" + AppConfig.IniFilePath;
            IniFilesUtil iniFilesUtil = new IniFilesUtil(AFileName);
            string strUserName  = iniFilesUtil.ReadString(AppConfig.Section.Login.ToString(), AppConfig.Ident.UserName.ToString(), "");
            string strPwd = iniFilesUtil.ReadString(AppConfig.Section.Login.ToString(), AppConfig.Ident.Password.ToString(), "");
            if (!String.IsNullOrEmpty(strPwd)) {
                string DecryptPwd = DESEncryptUtil.Decrypt(strPwd);
                te_password.Text = DecryptPwd;
            }

            if (!String.IsNullOrEmpty(strUserName))
            {
                string DecryptUserName = DESEncryptUtil.Decrypt(strUserName);
                te_username.Text = DecryptUserName;
            }
           
        }

        private void InitValidationRules()
        {
            ConditionValidationRule notEmptyValidationRule = new ConditionValidationRule();
            notEmptyValidationRule.ConditionOperator = ConditionOperator.IsNotBlank;
            notEmptyValidationRule.ErrorText = "请输入用户名！";
            dxvp_username.SetValidationRule(this.te_username, notEmptyValidationRule);//两个参数表示验name值为BulidName的TextEdit控件为notEmptyValidationRule验证




            notEmptyValidationRule.ErrorText = "请输入登录密码！";
            dxvp_pwd.SetValidationRule(this.te_password, notEmptyValidationRule);



        }

    }
}