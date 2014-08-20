using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChemTrend.Moblie.Forms.Stock
{
    public partial class frmMove : ChemTrend.Moblie.Forms.Base.BaseTForm
    {
        public frmMove()
        {
            InitializeComponent();
        }

        private void frmMove_Load(object sender, EventArgs e)
        {
            base.mTitle.Text = "移库";
            base.ucAction.Visible = true;
            base.ucAction.initString("提交");
        }
    }
}

