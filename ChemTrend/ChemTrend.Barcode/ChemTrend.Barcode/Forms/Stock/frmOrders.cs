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

namespace ChemTrend.Barcode.Forms.Stock
{
    public partial class frmOrders : DevExpress.XtraEditors.XtraForm
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        private void sbtn_select_Click(object sender, EventArgs e)
        {

        }

        private void sbtn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}