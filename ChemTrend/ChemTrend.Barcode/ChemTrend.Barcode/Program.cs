using ChemTrend.Barcode.Forms.Print;
using ChemTrend.Barcode.Forms.Stock;
using ChemTrend.Barcode.Forms.Systems;
using ChemTrend.Barcode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChemTrend.Barcode
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //汉化弹出框
            DevExpress.XtraEditors.Controls.Localizer.Active = new LocalizationCHS();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmChangePwd());

            //Application.Run(new frmAbout());

            frmLogin Log = new frmLogin();
            Log.StartPosition = FormStartPosition.CenterScreen;
            //使用模式对话框方法显示Log
            Log.ShowDialog();

            //DialogResult就是用来判断是否返回父窗体的
            if (Log.DialogResult == DialogResult.OK)
            {
                //在线程中打开主窗体
                Application.Run(new frmMain());
            }            
        }
    }
}
