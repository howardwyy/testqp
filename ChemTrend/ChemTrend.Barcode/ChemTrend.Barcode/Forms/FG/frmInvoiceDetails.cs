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
using BarcodeModel.MODEL.Barcode.FG;

namespace ChemTrend.Barcode.Forms.FG
{
    public partial class frmInvoiceDetails : DevExpress.XtraEditors.XtraForm
    {
        public List<InvoiceDetailModel> invoiceDetailModels { set; get; }
        public frmInvoiceDetails()
        {
            InitializeComponent();
        }

        private void frmInvoiceDetails_Load(object sender, EventArgs e)
        {
            if (invoiceDetailModels != null) {
                gc_invoice_detail.DataSource = invoiceDetailModels;
            }
        }
    }
}