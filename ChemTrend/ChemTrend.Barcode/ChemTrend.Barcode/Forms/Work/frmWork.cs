using BarcodeModel.API;
using BarcodeModel.MODEL.Barcode.WORP;
using BarcodeModel.MODEL.Barcode.WORP.Operation;
using ChemTrend.Barcode.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChemTrend.Barcode.Forms.Work
{
    public partial class frmWork : Form
    {
        private ModelAPI<ReportModel> reportApi = new ModelAPI<ReportModel>();
        private List<ReportModel> reportModels { set; get; }
        private ReportModel searchModel { set; get; }
        public frmWork()
        {
            InitializeComponent();
        }

        private void frmWork_Load(object sender, EventArgs e)
        {
            InitView();
            InitData();
        }

        private void InitData()
        {
            try
            {
                reportModels = reportApi.GetList(searchModel);
                this.gc_work.DataSource = reportModels;
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }
        }

        private void InitView()
        {
            cbox_status.Properties.Items.AddRange(AppConfig.GetWorkStatus());
        }

        private void sbtn_query_Click(object sender, EventArgs e)
        {

        }

        private void sbtn_test_Click(object sender, EventArgs e)
        {
            try
            {
                ModelAPI<WOReportModel> apiWOReport = new ModelAPI<WOReportModel>();
                WOReportModel insertModel = new WOReportModel()
                {
                    Workorder = te_wo.Text
                };
                WOReportModel returnModel = apiWOReport.Insert(insertModel);
                reportModels = returnModel.ReturnReportList;
                this.gc_work.DataSource = reportModels; 
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }
        }
    }
}
