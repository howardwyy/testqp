using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChemTrend.Moblie.Forms.Stock
{
    public partial class frmOut : ChemTrend.Moblie.Forms.Base.BaseTForm
    {
        public frmOut()
        {
            InitializeComponent();
        }

        private void frmOut_Load(object sender, EventArgs e)
        {
            base.mTitle.Text = "领料单出库";
            base.ucAction.Visible = true;
            base.ucAction.initString("提交");
        }
    }
}

