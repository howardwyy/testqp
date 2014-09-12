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
using BarcodeModel.MODEL.Barcode.RW;

namespace ChemTrend.Barcode.Forms.Stock
{
    public partial class frmBillDetails : DevExpress.XtraEditors.XtraForm
    {
        public List<BillDetailModel> listBillDetails { set; get; }
        public frmBillDetails()
        {
            InitializeComponent();
        }

        private void sbtn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBillDetails_Load(object sender, EventArgs e)
        {
            this.gc_bill_detail.DataSource = listBillDetails;
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gc_bill_detail_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraScrollableControl1_Click(object sender, EventArgs e)
        {

        }
    }
}