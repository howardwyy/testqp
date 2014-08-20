using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChemTrend.Moblie.Controls;
using ChemTrend.Barcode.Utils;
using ChemTrend.Moblie.Data;
using BarcodeModel.MODEL.User;
using BarcodeModel.API;

namespace ChemTrend.Moblie.Forms.Else
{
    public partial class frmElseMain : ChemTrend.Moblie.Forms.Base.BaseForm
    {
        public frmElseMain()
        {
            InitializeComponent();
        }

        private void frmElseMain_Load(object sender, EventArgs e)
        {
            base.mTitle.Text = "其他";
            this.mMenuBotton.setCurrent(ucMenuBotton.curElse);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            //获取当前登陆用户信息,退出处理
            //存储当前登陆用户信息
            string AFileName = IniFilesUtil.GetAppRunPath() + "/" + AppConfig.IniFilePath;
            IniFilesUtil iniFilesUtil = new IniFilesUtil(AFileName);  
            string hisID = iniFilesUtil.IniReadValue(AppConfig.Section.Login.ToString(), AppConfig.Ident.HisID.ToString());
            ModelAPI<LoginHistoryModel> apiHistory = new ModelAPI<LoginHistoryModel>();
            apiHistory.Delete(hisID,null);
            Application.Exit();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.Show();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.Show();
        }
    }
}

