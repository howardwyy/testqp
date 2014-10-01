using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ChemTrend.Barcode
{
    public partial class frmAbout : DevExpress.XtraEditors.XtraForm
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.panelControl1.Height < 120)
            {
                this.panelControl1.Height += 100;
            }
            else
            {
                this.Height -= 100;
                this.panelControl1.Height -= 100;
            }  
        }
    }
}