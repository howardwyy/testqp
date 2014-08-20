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
using DevExpress.XtraEditors.DXErrorProvider;
using BarcodeModel.MODEL.User;
using BarcodeModel.API;
using ChemTrend.Barcode.Utils;
using ChemTrend.Barcode.Data;

namespace ChemTrend.Barcode.Forms.Systems
{
    public partial class frmChangePwd : DevExpress.XtraEditors.XtraForm
    {
        frmMain fMain;
        public frmChangePwd()
        {
            InitializeComponent();
        }

        private void sbtn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbtn_update_Click(object sender, EventArgs e)
        {
            if (dxvp_username.Validate() && dxvp_password.Validate() && dxvp_password_new.Validate() && dxvp_password_sure.Validate())
            {
                string EncryptPwd = DESEncryptUtil.Encrypt(te_passwordnew.Text);

                ModelAPI<UserModel> apiUser = new ModelAPI<UserModel>();
                UserModel userModel = apiUser.GetModelByID(fMain.userId);
                if (userModel != null)
                { 
                    //存储当前登陆用户信息
                    string AFileName = System.Environment.CurrentDirectory + "/" + AppConfig.IniFilePath;
                    IniFilesUtil iniFilesUtil = new IniFilesUtil(AFileName);
                    iniFilesUtil.WriteString(AppConfig.Section.Login.ToString(), AppConfig.Ident.Password.ToString(), "");

                    userModel.Password = EncryptPwd;
                    apiUser.Update(userModel);
                    if (DevExpress.XtraEditors.XtraMessageBox.Show("用户信息已修改，\r\n请重新登陆！", "退出", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Application.Restart();
                    }
                }
            }
        }

        private void frmChangePwd_Load(object sender, EventArgs e)
        {
            fMain = (frmMain)this.ParentForm;
            this.te_username.Text = fMain.userName;
            InitValidationRules();
        }

        private void InitValidationRules()
        {
            ConditionValidationRule validationRule = new ConditionValidationRule();
            validationRule.ConditionOperator = ConditionOperator.IsNotBlank;
            validationRule.ErrorText = "请输入用户名！";
            dxvp_username.SetValidationRule(this.te_username, validationRule);

            validationRule.ConditionOperator = ConditionOperator.EndsWith;
            validationRule.Value1 = fMain.Password;
            validationRule.ErrorText = "请输入正确的历史密码！";
            dxvp_password.SetValidationRule(this.te_password, validationRule);

            validationRule.ConditionOperator = ConditionOperator.IsNotBlank;
            validationRule.ErrorText = "请输入新密码！";
            dxvp_password_new.SetValidationRule(this.te_passwordnew, validationRule);

        }

        private void te_passwordnew_TextChanged(object sender, EventArgs e)
        {
            ConditionValidationRule validationRule = new ConditionValidationRule();
            validationRule.ConditionOperator = ConditionOperator.Equals;
            validationRule.ErrorText = "确认密码和新密码不一致！";
            validationRule.Value1 = this.te_passwordnew.Text;
            dxvp_password_sure.SetValidationRule(this.te_passwordnew_sure, validationRule);
        }

    }
}