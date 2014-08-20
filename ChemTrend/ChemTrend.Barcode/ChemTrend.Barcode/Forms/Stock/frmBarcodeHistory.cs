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
    public partial class frmBarcodeHistory : DevExpress.XtraEditors.XtraForm
    {

        public List<RWHistoryModel> listRWHistory { set; get; }
        public frmBarcodeHistory()
        {
            InitializeComponent();
        }

        private void sbtn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBarcodeHistory_Load(object sender, EventArgs e)
        {
            this.gc_barcode_history.DataSource = listRWHistory;
        }
    }
}