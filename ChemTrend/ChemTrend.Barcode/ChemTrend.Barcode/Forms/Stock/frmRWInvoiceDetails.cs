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
using BarcodeModel.API;

namespace ChemTrend.Barcode.Forms.Stock
{
    public partial class frmRWInvoiceDetails : DevExpress.XtraEditors.XtraForm
    {
        public RWInvoiceModel curInvoiceModel { get; set; }
        public List<RWInvoiceDetailModel> listIDetails { set; get; }
        public frmRWInvoiceDetails()
        {
            InitializeComponent();
        }

        private void frmRWInvoiceDetails_Load(object sender, EventArgs e)
        {
            if (curInvoiceModel != null)
            {
                InitData();
            }
        }

        private void InitData()
        {
            try
            {
                ModelAPI<RWInvoiceDetailModel> apiReceiveDetails = new ModelAPI<RWInvoiceDetailModel>();
                RWInvoiceDetailModel searchInvoiceDetail = new RWInvoiceDetailModel();
                searchInvoiceDetail.InvoiceID = curInvoiceModel.ID;
                listIDetails = apiReceiveDetails.GetList(searchInvoiceDetail);
                if (listIDetails.Count >= 1)
                {
                    this.gc_invoice_detail.DataSource = listIDetails;
                }
            }
            catch (Exception ex)
            {

                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }
        }


        private void sbtn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbtn_invoice_Click(object sender, EventArgs e)
        {
            int[] selectRows = gv_invoice_detail.GetSelectedRows();
            if (selectRows.Length >= 1)
            {
                RWInvoiceDetailModel model = null;
                foreach (int row in selectRows)
                {
                    model = listIDetails[gv_invoice_detail.GetDataSourceRowIndex(row)];
                }
                if (model != null && model.InvoiceSurplusCount > 0)
                {
                    frmRWInvoicing frmFGInvoicing = new frmRWInvoicing();
                    frmFGInvoicing.StartPosition = FormStartPosition.CenterParent;
                    frmFGInvoicing.IDModel = model;
                    DialogResult result = frmFGInvoicing.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        InitData();
                    }
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("该领料单行，已经没有剩余领料，不能再次进行领料操作！", "确认", MessageBoxButtons.OK);

                }
            }
        }

    }
}