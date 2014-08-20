using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ChemTrend.Moblie.Controls
{
    public partial class ucMenuBotton : UserControl
    {
        public static ChemTrend.Moblie.Forms.Stock.frmStockMain stockFrm;
        public static ChemTrend.Moblie.Forms.Else.frmElseMain elseFrm;
        public static ChemTrend.Moblie.Forms.Product.frmProductMain productFrm;
        public static ChemTrend.Moblie.Forms.Task.frmTaskMain taskMain;

        public static int curStock = 1;
        public static int curProduct= 2;
        public static int curTask = 3;
        public static int curElse = 4;

        public ucMenuBotton()
        {
            InitializeComponent();
        }


        private void panel_else_Click(object sender, EventArgs e)
        {

            if (elseFrm == null)
            {
                elseFrm = new ChemTrend.Moblie.Forms.Else.frmElseMain();
                elseFrm.Show();
            }
            else
            {
                elseFrm.Activate();
            }
        }

        private void panel_stock_Click(object sender, EventArgs e)
        {
            if (stockFrm == null)
            {
                stockFrm = new ChemTrend.Moblie.Forms.Stock.frmStockMain();
                stockFrm.Show();
            }
            else
            {
                stockFrm.Activate();
            }
        }

        private void panel_product_Click(object sender, EventArgs e)
        {
            if (productFrm == null)
            {
                productFrm = new ChemTrend.Moblie.Forms.Product.frmProductMain();
                productFrm.Show();
            }
            else
            {
                productFrm.Activate();
            }
            
        }

        private void panel_task_Click(object sender, EventArgs e)
        {
            if (taskMain == null)
            {
                taskMain = new ChemTrend.Moblie.Forms.Task.frmTaskMain();
                taskMain.Show();
            }
            else
            {
                taskMain.Activate();
            }
            
        }


        public void setCurrent(int type) {

            this.lbl_stock.ForeColor = Color.Black;
            this.lbl_product.ForeColor = Color.Black;
            this.lbl_task.ForeColor = Color.Black;
            this.lbl_else.ForeColor = Color.Black;
            this.pbox_stock.Image = Properties.Resources.menu_stock_normal;
            this.pbox_product.Image = Properties.Resources.menu_product_normal;
            this.pbox_task.Image = Properties.Resources.menu_task_normal;
            this.pbox_else.Image = Properties.Resources.menu_else__normal;
            switch (type) {
                case 1:
                    this.pbox_stock.Image = Properties.Resources.menu_stock_checked;
                    this.lbl_stock.ForeColor = Color.OrangeRed;
                    break;
                case 2:
                    this.pbox_product.Image = Properties.Resources.menu_product_checked;
                    this.lbl_product.ForeColor = Color.OrangeRed;
                    break;
                case 3:
                    this.pbox_task.Image = Properties.Resources.menu_task_checked;
                    this.lbl_task.ForeColor = Color.OrangeRed;
                    break;
                case 4:
                    this.pbox_else.Image = Properties.Resources.menu_else_checked;
                    this.lbl_else.ForeColor = Color.OrangeRed;
                    break;
                default :
                    break;
            }
        
        }

       
    }
}
