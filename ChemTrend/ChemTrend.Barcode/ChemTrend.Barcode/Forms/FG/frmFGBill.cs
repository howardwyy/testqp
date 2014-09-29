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
using BarcodeModel.API;
using BarcodeModel.MODEL.Barcode.FG;
using ChemTrend.Barcode.Utils;
using BarcodeModel.MODEL.Barcode.RW;
using ChemTrend.Barcode.Data;

namespace ChemTrend.Barcode.Forms.FG
{
    public partial class frmFGBill : DevExpress.XtraEditors.XtraForm
    {
        ModelAPI<FGBillModel> apiBill = new ModelAPI<FGBillModel>();
        ModelAPI<FGBillDetailModel> apiBillDetail = new ModelAPI<FGBillDetailModel>();
        List<FGBillModel> listBill = new List<FGBillModel>();
        List<FGBillDetailModel> listBillDetail = new List<FGBillDetailModel>();
        FGBillModel searchModel;
        FGBillDetailModel searchDetailModel;

        public frmFGBill()
        {
            InitializeComponent();
        }
        private void frmFGBill_Load(object sender, EventArgs e)
        {
            InitView();
            InitData();
        }

        private void InitView()
        {
            de_start.Text = DateTimeUtil.GetFirstDayOfMonth();
            de_end.Text = DateTimeUtil.GetLastDayOfMonth();
            List<ComboBoxEditData> status = AppConfig.GetBarcodeRemarkStatus();
            foreach (ComboBoxEditData item in status)
            {
                cbox_remark.Properties.Items.Add(item.Text);
            }
        }


        private void InitData()
        {
            try
            {
                searchModel = new FGBillModel();
                if (!String.IsNullOrEmpty(de_start.Text) && !String.IsNullOrEmpty(de_end.Text))
                {
                    DateTime beginTime = DateTime.MinValue;
                    DateTime.TryParse(de_start.Text, out beginTime);
                    searchModel.BeginTime = beginTime;

                    DateTime endTime = DateTime.MaxValue;
                    DateTime.TryParse(de_end.Text, out endTime);
                    searchModel.EndTime = endTime;
                }
                if (te_bill.Text.Trim().Length >= 1)
                {
                    searchModel.ID = te_bill.Text.Trim();
                }
                if (te_username.Text.Trim().Length >= 1)
                {
                    searchModel.UserName = te_username.Text.Trim();
                }
                if (cbox_remark.Text.Trim().Length >= 1)
                {
                    searchModel.Remark = cbox_remark.Text;
                }

                listBill = apiBill.GetList(searchModel);
                gc_bill.DataSource = listBill;
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }

        }

        private void InitDetailData()
        {
            try
            {
                listBillDetail = apiBillDetail.GetList(searchDetailModel);
                gc_bill_detail.DataSource = listBillDetail;
            }
            catch (Exception ex)
            {

                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }
        }

        private void gv_bill_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            FGBillModel curModel = listBill[gv_bill.GetDataSourceRowIndex(e.RowHandle)];
            searchDetailModel = new FGBillDetailModel()
            {
                BillID = curModel.ID
            };
            InitDetailData();
        }

        private void sbtn_query_Click(object sender, EventArgs e)
        {

            InitData();
        }

    }
}