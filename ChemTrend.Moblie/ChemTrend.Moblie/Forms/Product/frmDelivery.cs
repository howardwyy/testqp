using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChemTrend.Moblie.Forms.Product
{
    public partial class frmDelivery : ChemTrend.Moblie.Forms.Base.BaseTForm
    {
        public frmDelivery()
        {
            InitializeComponent();
        }

        private void frmDelivery_Load(object sender, EventArgs e)
        {
            base.mTitle.Text = "发往客户";
            base.ucAction.Visible = true;
            base.ucAction.initString("提交");
        }
    }
}

