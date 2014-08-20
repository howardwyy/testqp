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

namespace ChemTrend.Barcode.Forms.Print
{
    public partial class frmWarehouseAll : DevExpress.XtraEditors.XtraForm
    {
        public frmWarehouseAll()
        {
            InitializeComponent();
        }

        private void sbtn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbtn_select_Click(object sender, EventArgs e)
        {

        }
    }
}