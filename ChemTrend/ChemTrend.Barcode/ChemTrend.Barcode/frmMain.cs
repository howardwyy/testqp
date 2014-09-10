using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ChemTrend.Barcode.Forms.Stock;
using DevExpress.XtraTabbedMdi;
using ChemTrend.Barcode.Forms.Print;
using System.Reflection;
using ChemTrend.Barcode.Forms.Systems;
using ChemTrend.Barcode.Data;
using ChemTrend.Barcode.Utils;
using BarcodeModel.MODEL.User;
using BarcodeModel.API;
using ChemTrend.Barcode.Forms.FG;

namespace ChemTrend.Barcode
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            OpenWindow(typeof(frmBarcode).ToString());
            InitViews();
        }

        #region  获取初始化数据

        public string hisID { get; set; }
        public string userId { get; set; }
        public string userName { get; set; }
        public string Password { get; set; }
        private void InitViews()
        {
             //获取当前登陆用户信息,退出处理
            string AFileName = System.Environment.CurrentDirectory + "/" + AppConfig.IniFilePath;
            IniFilesUtil iniFilesUtil = new IniFilesUtil(AFileName);
            hisID = iniFilesUtil.ReadString(AppConfig.Section.Login.ToString(), AppConfig.Ident.HisID.ToString(), "");
            userId = iniFilesUtil.ReadString(AppConfig.Section.Login.ToString(), AppConfig.Ident.ID.ToString(), "");
            string DecryptUserName = iniFilesUtil.ReadString(AppConfig.Section.Login.ToString(), AppConfig.Ident.UserName.ToString(), "");
            userName = DESEncryptUtil.Decrypt(DecryptUserName);
            string DecryptPassword = iniFilesUtil.ReadString(AppConfig.Section.Login.ToString(), AppConfig.Ident.Password.ToString(), "");
            Password = DESEncryptUtil.Decrypt(DecryptPassword);

            updateStatusBar("当前登录用户：" + userName);
        }

        public System.Timers.Timer timer = null;
        public void updateStatusBar(string statusBar)
        {
            if (statusBar != null && statusBar.Length >= 1)
            {
                barStaticItem_statusBar.Visibility = BarItemVisibility.Always;
                barStaticItem_statusBar.Caption = statusBar;
            }
            else
            {
                barStaticItem_statusBar.Visibility = BarItemVisibility.Always;
            }

            timer = new System.Timers.Timer();
            timer.Interval = 1000;

            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer.Start();

        }
        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.bsi_timer.Caption = DateTime.Now.ToString("yyyy年MM月dd日 hh:mm:ss");
        }

        #endregion



        #region 双击关闭
        private DateTime m_LastClick = System.DateTime.Now;
        private XtraMdiTabPage m_lastPage = null;
        private void xtraTabbedMdiManager1_MouseDown(object sender, MouseEventArgs e)
        {
            XtraMdiTabPage curPage = (sender as XtraTabbedMdiManager).SelectedPage;

            if (e.Button == MouseButtons.Left)
            {

                DateTime dt = DateTime.Now;
                TimeSpan span = dt.Subtract(m_LastClick);
                if (span.TotalMilliseconds < 300)  //如果两次点击的时间间隔小于300毫秒，则认为是双击
                {


                    if (this.MdiChildren.Length > 1)
                    {

                        // 限制只有在同一个页签上双击才能关闭.(规避两个页签切换时点太快导致意外关闭页签)
                        if (curPage.Equals(m_lastPage))
                        {
                            //if (this.ActiveMdiChild != m_MapForm)
                            //{
                            this.ActiveMdiChild.Close();
                            //}

                        }
                    }
                    m_LastClick = dt.AddMinutes(-1);
                }
                else
                {
                    m_LastClick = dt;
                    m_lastPage = curPage;
                }
            }
        }
        #endregion


        private void barButtonItem_stock_ItemClick(object sender, ItemClickEventArgs e)
        {
            //frmStocks childForm = new frmStocks();
            //childForm.MdiParent = this;
            //// 子窗体的 Text  就是 Tab页中的标题 ,我这里是直接取 navItem中的标题作为 tab页的标题
            ////childForm.Text = navItem.Caption + tabCount++;
            //// 显示 
            //childForm.Show();
            //// 设置当前 tab页的 图标,我这里也默认取navBar中的Item中的图标
            ////xtraTabbedMdiManager1.Pages[subform].Image = navItem.SmallImage;


            OpenWindow(typeof(frmBarcode).ToString());
        }

        private void barButtonItem_warehouse_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenWindow(typeof(frmWarehouse).ToString());
        }

        private void barButtonItem_customer_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenWindow(typeof(frmCustomer).ToString());
        }


        private void barButtonItem_sys_user_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenWindow(typeof(frmUsers).ToString());
        }


        private void bbtn_database_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenWindow(typeof(frmDatabase).ToString());
        }


        private void bbtn_my_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenWindow(typeof(frmChangePwd).ToString());

        }


        private void bbtn_warehouse_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenWindow(typeof(frmWarehouse).ToString());

        }


        private void bbtn_access_ItemClick(object sender, ItemClickEventArgs e)
        {
        }


        private void bbtn_stock_number_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenWindow(typeof(frmBill).ToString());
        }



        private void bbtn_stock_packing_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenWindow(typeof(frmPacking).ToString());

        }


        private void bbtn_stock_receiving_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenWindow(typeof(frmReceive).ToString());

        }

        private void bbtn_stock_totakestock_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenWindow(typeof(frmToTakeStock).ToString());

        }

        private void bbtn_role_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenWindow(typeof(frmRoles).ToString()); 
        }


        #region 唯一实例

        /// <summary>

        /// Open child window

        /// </summary>

        /// <param name="ChildTypeString"></param>

        public void OpenWindow(string ChildTypeString)
        {

            Form myChild = null;

            if (!ContainMDIChild(ChildTypeString))
            {
                // Get current process assembly
                Assembly assembly = Assembly.GetExecutingAssembly();
                // Create data type using type string
                Type typForm = assembly.GetType(ChildTypeString);
                // Create object using type's "InvokeMember" method
                Object obj = typForm.InvokeMember(
                    null,
                    BindingFlags.DeclaredOnly |
                    BindingFlags.Public | BindingFlags.NonPublic |
                    BindingFlags.Instance | BindingFlags.CreateInstance,
                    null,
                    null,
                    null);



                // Show child form 
                if (obj != null)
                {
                    myChild = obj as Form;
                    myChild.MdiParent = this;
                    myChild.Show();
                    myChild.Focus();
                }

            }

        }



        /// <summary>

        /// Search mdi child form by specific type string

        /// </summary>

        /// <param name="ChildTypeString"></param>

        /// <returns></returns>

        private bool ContainMDIChild(string ChildTypeString)
        {

            Form myMDIChild = null;

            foreach (Form f in this.MdiChildren)
            {

                if (f.GetType().ToString() == ChildTypeString)
                {

                    // found it 

                    myMDIChild = f;

                    break;

                }

            }



            // Show the exist form

            if (myMDIChild != null)
            {

                myMDIChild.TopMost = true;

                myMDIChild.Show();

                myMDIChild.Focus();

                return true;

            }

            else

                return false;

        }
        #endregion

       

        private void bbtn_exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                destroyLogin();
               
                // 关闭所有的线程
                this.Dispose();
                this.Close();
            }

        }



        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            destroyLogin();
        }

        private void destroyLogin() {
            //获取当前登陆用户信息,退出处理
            string AFileName = System.Environment.CurrentDirectory + "/" + AppConfig.IniFilePath;
            IniFilesUtil iniFilesUtil = new IniFilesUtil(AFileName);
            string hisID = iniFilesUtil.ReadString(AppConfig.Section.Login.ToString(), AppConfig.Ident.HisID.ToString(), "");
            ModelAPI<LoginHistoryModel> apiHistory = new ModelAPI<LoginHistoryModel>();
            apiHistory.Delete(hisID);

                
        }

        private void bbtn_item_fg_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenWindow(typeof(frmFG).ToString());
        }

        private void bbtn_item_bill_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenWindow(typeof(frmFGBill).ToString());
        }

        private void bbtn_item_invoice_ItemClick(object sender, ItemClickEventArgs e)
        {

            OpenWindow(typeof(frmFGInvoice).ToString());
        }

        private void bbtn_item_package_ItemClick(object sender, ItemClickEventArgs e)
        {

            OpenWindow(typeof(frmFGPackage).ToString());
        }


        private void bbtn_item_business_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenWindow(typeof(frmFGBusiness).ToString());

        }

    }
}