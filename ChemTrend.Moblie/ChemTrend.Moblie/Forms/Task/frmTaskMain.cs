﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChemTrend.Moblie.Controls;

namespace ChemTrend.Moblie.Forms.Task
{
    public partial class frmTaskMain : ChemTrend.Moblie.Forms.Base.BaseForm
    {
        public frmTaskMain()
        {
            InitializeComponent();
        }

        private void frmTaskMain_Load(object sender, EventArgs e)
        {
            base.mTitle.Text = "工时汇报";
            base.mMenuBotton.setCurrent(ucMenuBotton.curTask);
        }

        private void pbox_inwarehouse_Click(object sender, EventArgs e)
        {

        }

        private void pbox_woreport_Click(object sender, EventArgs e)
        {
            frmTaskReport frmReport = new frmTaskReport();
            frmReport.Show();
        }
    }
}

