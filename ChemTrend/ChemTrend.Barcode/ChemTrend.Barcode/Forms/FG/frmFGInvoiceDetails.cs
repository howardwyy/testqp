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
using BarcodeModel.API;

namespace ChemTrend.Barcode.Forms.FG
{
    public partial class frmFGInvoiceDetails : DevExpress.XtraEditors.XtraForm
    {
        public InvoiceModel curInvoiceModel { get; set; }
        public List<InvoiceDetailModel> listIDetails { set; get; }
        public frmFGInvoiceDetails()
        {
            InitializeComponent();
        }

        private void frmInvoiceDetails_Load(object sender, EventArgs e)
        {
            if (curInvoiceModel != null)
            {
                InitData();
            }
        }

        private void InitData() {
            try
            {
                ModelAPI<InvoiceDetailModel> apiReceiveDetails = new ModelAPI<InvoiceDetailModel>();
                InvoiceDetailModel searchInvoiceDetail = new InvoiceDetailModel();
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
                InvoiceDetailModel model = null;
                foreach (int row in selectRows)
                {
                    model = listIDetails[gv_invoice_detail.GetDataSourceRowIndex(row)];
                }
                if (model != null && model.InvoiceSurplusCount > 0)
                {
                    frmFGInvoicing frmFGInvoicing = new frmFGInvoicing();
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