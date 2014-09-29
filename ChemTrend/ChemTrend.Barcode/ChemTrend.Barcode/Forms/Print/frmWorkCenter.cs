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
using BarcodeModel.MODEL.Barcode;
using BarcodeModel.API;
using BarcodeModel.MODEL.Sys;
using DevExpress.XtraReports.UI;
using ChemTrend.Barcode.Report;

namespace ChemTrend.Barcode.Forms.Print
{
    public partial class frmWorkCenter : DevExpress.XtraEditors.XtraForm
    {

        List<WorkCenterModel> listWorkCenter;
        ModelAPI<WorkCenterModel> apiWorkCenter = new ModelAPI<WorkCenterModel>();
        WorkCenterModel searchModel;
        public frmWorkCenter()
        {
            InitializeComponent();
        }

        private void frmWorkCenter_Load(object sender, EventArgs e)
        {
            try
            {
                ModelAPI<CompanyModel> apiCompany = new ModelAPI<CompanyModel>();
                CompanyModel companyModel = apiCompany.GetModelByID("Companys"); ;
                lue_company.Properties.DataSource = companyModel.Companys;
                lue_company.ItemIndex = 0;
                InitData();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }
        }

        private void InitData()
        {
            searchModel = new WorkCenterModel();
            if (this.te_wccode.Text.Trim().Length != 0)
            {
                searchModel.WorkcenterCode = this.te_wccode.Text;
            }
            if (this.te_wcname.Text.Trim().Length != 0)
            {
                searchModel.WorkcenterName = this.te_wcname.Text;
            }
            if (this.lue_company.Text.Length >= 1)
            {
                searchModel.Company = this.lue_company.Text;
            }

            listWorkCenter= apiWorkCenter.GetList(searchModel);
            gc_workcenter.DataSource = listWorkCenter;
            this.gv_workcenter.FocusedRowHandle = 0;
        }

        private void sbtn_query_Click(object sender, EventArgs e)
        {
            InitData();
        }

        private void sbtn_print_Click(object sender, EventArgs e)
        {

            List<XtraReport> reports = new List<XtraReport>();
            int[] selectRows = gv_workcenter.GetSelectedRows();

            foreach (int row in selectRows)
            {
                WorkCenterModel model = listWorkCenter[gv_workcenter.GetDataSourceRowIndex(row)];
                repWorkCenter report = new repWorkCenter();
                report.WorkCenterName = model.WorkcenterName;
                report.WorkCenterCode = model.WorkcenterCode;
                report.CreateDocument();
                reports.Add(report);
            }
            frmMutiPrint mutiPrint = new frmMutiPrint();
            mutiPrint.reports = reports;
            mutiPrint.Show();
        }

        private void sbtn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}