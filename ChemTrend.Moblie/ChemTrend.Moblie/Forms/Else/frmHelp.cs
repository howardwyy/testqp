using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChemTrend.Moblie.Forms.Else
{
    public partial class frmHelp : ChemTrend.Moblie.Forms.Base.BaseTForm
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            base.mTitle.Text = "帮助";
        }
    }
}

