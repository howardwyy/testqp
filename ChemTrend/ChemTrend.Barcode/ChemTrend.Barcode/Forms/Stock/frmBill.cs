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
using BarcodeModel.MODEL.Barcode.RW;
using ChemTrend.Barcode.Utils;

namespace ChemTrend.Barcode.Forms.Stock
{
    public partial class frmBill : DevExpress.XtraEditors.XtraForm
    {

        ModelAPI<BillModel> apiBill = new ModelAPI<BillModel>();
        ModelAPI<BillDetailModel> apiBillDetail = new ModelAPI<BillDetailModel>();
        List<BillModel> listBill;
        List<BillDetailModel> listBillDetail;
        BillModel searchModel;
        BillDetailModel searchDetailModel;
        public frmBill()
        {
            InitializeComponent();
        }

        private void InitView()
        {
            de_start.Text = DateTimeUtil.GetFirstDayOfMonth();
            de_end.Text = DateTimeUtil.GetLastDayOfMonth();
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            InitView();
            InitData();
        }

        private void InitData()
        {
            searchModel = new BillModel();
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

        private void InitDetailData() {
            gc_bill_detail.DataSource = null;
            listBillDetail = apiBillDetail.GetList(searchDetailModel);
            gc_bill_detail.DataSource = listBillDetail;
        }

        private void gv_bill_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            BillModel curModel =listBill[gv_bill.GetDataSourceRowIndex(e.RowHandle)];
            searchDetailModel = new BillDetailModel() 
            {
                BillID = curModel.ID
            };
            InitDetailData();
        }

        private void sbtn_query_Click(object sender, EventArgs e)
        {
            
            InitData();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}