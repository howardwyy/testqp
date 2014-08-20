using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChemTrend.Moblie.Forms.Else
{
    public partial class frmAbout : ChemTrend.Moblie.Forms.Base.BaseTForm
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void lbl_copyright_ParentChanged(object sender, EventArgs e)
        {

        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            base.mTitle.Text = "关于";
        }
    }
}

