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
    public partial class frmReceiveDetails : DevExpress.XtraEditors.XtraForm
    {
        public ReceiveModel focuseReceive { set; get; }
        private List<ReceiveDetailModel> listRDetails { set; get; }
        public frmReceiveDetails()
        {
            InitializeComponent();
        }

        private void frmReceiveDetails_Load(object sender, EventArgs e)
        {
            InitData();
        }
        private void InitData() {
            try
            {
                ModelAPI<ReceiveDetailModel> apiReceiveDetails = new ModelAPI<ReceiveDetailModel>();
                ReceiveDetailModel searchReceiveDetail = new ReceiveDetailModel();
                searchReceiveDetail.ReceiveID = focuseReceive.ID;
                listRDetails = apiReceiveDetails.GetList(searchReceiveDetail);
                if (listRDetails.Count >= 1)
                {
                    this.gc_receive_detail.DataSource = listRDetails;
                    this.gc_receive_detail.RefreshDataSource();
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

        private void sbtn_receive_Click(object sender, EventArgs e)
        {
            int[] selectRows = gv_receive_detail.GetSelectedRows();
            if (selectRows.Length >= 1)
            {
                ReceiveDetailModel model = null;
                foreach (int row in selectRows)
                {
                    model = listRDetails[gv_receive_detail.GetDataSourceRowIndex(row)];
                }
                if (model != null && model.ReceivedSurplusCount > 0)
                {
                    frmReceiving frmReceiving = new frmReceiving();
                    frmReceiving.StartPosition = FormStartPosition.CenterParent;
                    frmReceiving.rdModel = model;
                    DialogResult result = frmReceiving.ShowDialog();
                    if (result == DialogResult.OK) {
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