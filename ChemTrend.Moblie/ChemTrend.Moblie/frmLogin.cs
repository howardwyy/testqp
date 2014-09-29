using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BarcodeModel.MODEL.User;
using BarcodeModel.API;
using ChemTrend.Moblie.Forms.Stock;
using ChemTrend.Moblie.Forms.Base;
using ChemTrend.Moblie.Controls;
using ChemTrend.Barcode.Utils;
using ChemTrend.Moblie.Data;
using System.Globalization; 

namespace ChemTrend.Moblie
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar +" / key");
        }

        protected override void OnClick(EventArgs e)
        {
            this.Focus();
            base.OnClick(e);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                string EncryptPwd = DESEncryptUtil.Encrypt(this.tbox_Pwd.Text);
                string EncryptUserName = DESEncryptUtil.Encrypt(this.tbox_Name.Text);

                LoginModel lm = new LoginModel()
                {
                    LoginName = tbox_Name.Text,
                    Password = EncryptPwd,
                };
                ModelAPI<LoginModel> api = new ModelAPI<LoginModel>();
                LoginModel resultModel = api.Insert<LoginModel>(lm);
                if (resultModel.LoginSuccess)
                {
                    BaseAPI.AccessToken = resultModel.Token;
                    //存储当前登陆用户信息
                    string AFileName = IniFilesUtil.GetAppRunPath() + "/" + AppConfig.IniFilePath;
                    IniFilesUtil iniFilesUtil = new IniFilesUtil(AFileName);
                    BaseAPI.AccessToken = resultModel.Token;

                    iniFilesUtil.IniWriteValue(AppConfig.Section.UserName.ToString(), AppConfig.Ident.UserName.ToString(), EncryptUserName);
                    iniFilesUtil.IniWriteValue(AppConfig.Section.Password.ToString(), AppConfig.Ident.Password.ToString(), EncryptPwd);
                    iniFilesUtil.IniWriteValue(AppConfig.Section.ID.ToString(), AppConfig.Ident.ID.ToString(), resultModel.UserID);
                    iniFilesUtil.IniWriteValue(AppConfig.Section.HisID.ToString(), AppConfig.Ident.HisID.ToString(), resultModel.loginHistoryModel.ID);
                    frmStockMain fStockMain = new frmStockMain();
                    fStockMain.Show();
                }
                else
                {
                    MessageBox.Show(resultModel.ErrorMsg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Back)
            {
                this.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}