﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChemTrend.Moblie.Controls;

namespace ChemTrend.Moblie.Forms.Product
{
    public partial class frmProductMain : ChemTrend.Moblie.Forms.Base.BaseForm
    {
        public frmProductMain()
        {
            InitializeComponent();
        }

        private void frmProductMain_Load(object sender, EventArgs e)
        {
            this.mTitle.Text = "成品";
            this.mMenuBotton.setCurrent(ucMenuBotton.curProduct);
        }

        private void pbox_out_Click(object sender, EventArgs e)
        {

        }

        private void pbox_check_Click(object sender, EventArgs e)
        {
            frmCheck check = new frmCheck();
            check.Show();
        }

        private void pbox_package_Click(object sender, EventArgs e)
        {
            frmPackage package = new frmPackage();
            package.Show();
        }

        private void pbox_move_Click(object sender, EventArgs e)
        {
            frmMoveWH moveWH = new frmMoveWH();
            moveWH.Show();
        }

        private void pbox_inwarehouse_Click(object sender, EventArgs e)
        {

            frmEnterWH enterWH = new frmEnterWH();
            enterWH.Show();
        }

        private void pbox_delivery_Click(object sender, EventArgs e)
        {
            frmDelivery delivery = new frmDelivery();
            delivery.Show();
        }

    }
}

