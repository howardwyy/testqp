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

namespace ChemTrend.Barcode.Forms.FG
{
    public partial class frmFGSuggest : DevExpress.XtraEditors.XtraForm
    {
        public frmFGSuggest()
        {
            InitializeComponent();
        }

        private void sbtn_query_Click(object sender, EventArgs e)
        {

        }

        private void sbtn_print_Click(object sender, EventArgs e)
        {

        }

        private void sbtn_no_Click(object sender, EventArgs e)
        {
            frmFGSuggestChoice frmFGSuggestChoice = new frmFGSuggestChoice();
            frmFGSuggestChoice.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = frmFGSuggestChoice.ShowDialog();
            if (result == DialogResult.OK)
            {
                InitData();
            }
        }

        private void InitData()
        {

        }

        private void sbtn_customer_Click(object sender, EventArgs e)
        {
            frmFGCustomer frmFGCustomer = new frmFGCustomer();
            frmFGCustomer.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = frmFGCustomer.ShowDialog();
            if (result == DialogResult.OK)
            {
                InitData();
            }
        }
    }
}