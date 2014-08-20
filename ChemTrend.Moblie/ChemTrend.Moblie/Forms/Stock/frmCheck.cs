using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChemTrend.Moblie.Forms.Stock
{
    public partial class frmCheck : ChemTrend.Moblie.Forms.Base.BaseTForm
    {
        public frmCheck()
        {
            InitializeComponent();
        }

        private void frmCheck_Load(object sender, EventArgs e)
        {
            mTitle.Text = "盘点";
            base.ucAction.Visible = true;
            base.ucAction.initString("提交");
        }
    }
}

