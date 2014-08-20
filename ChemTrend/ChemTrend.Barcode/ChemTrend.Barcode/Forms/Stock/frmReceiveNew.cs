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
using BarcodeModel.MODEL.Barcode.RW.Operation;
using ChemTrend.Barcode.Utils;
using DevExpress.XtraReports.UI;
using ChemTrend.Barcode.Forms.Print;
using ChemTrend.Barcode.Report;
using BarcodeModel.MODEL.Sys;

namespace ChemTrend.Barcode.Forms.Stock
{
    public partial class frmReceiveNew : DevExpress.XtraEditors.XtraForm
    {

        ModelAPI<WOLineModel> apiWOLine = new ModelAPI<WOLineModel>();
        List<WOLineModel> listWOLine = null;
        public frmReceiveNew()
        {
            InitializeComponent();
        }

        private void sbtn_query_Click(object sender, EventArgs e)
        {
            WOLineModel searchModel = new WOLineModel()
            {
                WO = cbox_wo.Text,
                Company = lue_company.Text
            };
            listWOLine = apiWOLine.GetList(searchModel);
            gc_woline.DataSource = listWOLine;
        }

        private void sbtn_wo_Click(object sender, EventArgs e)
        {
            GetTips();
        }

        private void GetTips()
        {
            if (!String.IsNullOrEmpty(cbox_wo.Text))
            {
                cbox_wo.Properties.Items.Clear();
                string tips = cbox_wo.Text;
                WOLineModel returnModel = apiWOLine.GetModelByID(tips);
                if (returnModel != null)
                {
                    for (int i = 0; i < returnModel.WOS.Count(); i++)
                    {
                        cbox_wo.Properties.Items.Add(returnModel.WOS[i]);
                    }
                }
                cbox_wo.ShowPopup();
            }
        }

        private void cbox_wo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetTips();
            }
        }

        private void sbtn_create_print_Click(object sender, EventArgs e)
        {
            int[] selectRows = gv_woline.GetSelectedRows();
            if (selectRows.Length >= 1)
            {
                List<WOLineModel> selectedWOLines = new List<WOLineModel>();
                foreach (int row in selectRows)
                {
                    WOLineModel item = listWOLine[gv_woline.GetDataSourceRowIndex(row)];
                    selectedWOLines.Add(item);
                }

                ModelAPI<PListCreateModel> apiWOLine = new ModelAPI<PListCreateModel>();
                PListCreateModel createModel = new PListCreateModel()
                {
                    WOLine = selectedWOLines.ToArray(),
                    PLNO = this.cbox_wo.Text,
                    Remark = this.te_remark.Text,
                    isUrgent = this.cke_isurgent.Checked ? 1 : 0,
                    HopeTime = de_hopetime.DateTime
                };
                PListCreateModel PLCreateModel = apiWOLine.Insert(createModel);

                this.DialogResult = DialogResult.OK;
                if (DevExpress.XtraEditors.XtraMessageBox.Show("是否打印生成的条码信息？", "打印", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    ModelAPI<ReceiveModel> apiReceive = new ModelAPI<ReceiveModel>();
                    ReceiveModel receiveModel = apiReceive.GetModelByID(PLCreateModel.PLNO);

                    ModelAPI<ReceiveDetailModel> apiReceiveDetails = new ModelAPI<ReceiveDetailModel>();
                    ReceiveDetailModel searchReceiveDetail = new ReceiveDetailModel();
                    searchReceiveDetail.ReceiveID = PLCreateModel.PLNO;
                    List<ReceiveDetailModel> listRDetails = apiReceiveDetails.GetList(searchReceiveDetail);
                    List<XtraReport> reports = new List<XtraReport>();


                    repReceive report = new repReceive();
                    report.receiveModel = receiveModel;
                    report.RDModels = listRDetails;
                    report.CreateDocument();
                    reports.Add(report);

                    frmMutiPrint mutiPrint = new frmMutiPrint();
                    mutiPrint.reports = reports;
                    mutiPrint.Show();


                }
            }
        }

        private void frmReceiveNew_Load(object sender, EventArgs e)
        {
            de_hopetime.DateTime = System.DateTime.Now;

            ModelAPI<CompanyModel> apiCompany = new ModelAPI<CompanyModel>();
            CompanyModel companyModel = apiCompany.GetModelByID("Companys"); ;
            lue_company.Properties.DataSource = companyModel.Companys;
            lue_company.ItemIndex = 0;
        }
    }
}