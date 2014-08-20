using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChemTrend.Moblie.Controls;

namespace ChemTrend.Moblie.Forms.Stock
{
    public partial class frmStockMain : ChemTrend.Moblie.Forms.Base.BaseForm
    {
        public frmStockMain()
        {
            InitializeComponent();
        }


        private void frmStockMain_Load(object sender, EventArgs e)
        {

            base.mTitle.Text = "原材料";
            this.mMenuBotton.setCurrent(ucMenuBotton.curStock);
        }

        private void pbox_package_Click(object sender, EventArgs e)
        {
            frmPackage package = new frmPackage();
            package.Show();
        }

        private void pbox_out_Click(object sender, EventArgs e)
        {
            frmOut outFrm = new frmOut();
            outFrm.Show();
        }

        private void pbox_inwarehouse_Click(object sender, EventArgs e)
        {
            frmSInWarehouse inwarehouse = new frmSInWarehouse();
            inwarehouse.Show();
        }

        private void pbox_check_Click(object sender, EventArgs e)
        {
            frmCheck check = new frmCheck();
            check.Show();
        }

        private void pbox_move_Click(object sender, EventArgs e)
        {
            frmMove move = new frmMove();
            move.Show();
        }


        private void frmStockMain_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }
    }
}

