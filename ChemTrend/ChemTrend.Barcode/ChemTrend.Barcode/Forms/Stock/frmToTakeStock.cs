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
using BarcodeModel.MODEL.Barcode.RW.Operation;

namespace ChemTrend.Barcode.Forms.Stock
{
    public partial class frmToTakeStock : DevExpress.XtraEditors.XtraForm
    {
        ModelAPI<CheckModel> apiCheck = new ModelAPI<CheckModel>();
        List<CheckModel> checkModels = new List<CheckModel>();
        CheckModel searchModel = null;
        public frmToTakeStock()
        {
            InitializeComponent();
        }

        private void frmToTakeStock_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            try
            {
                checkModels = apiCheck.GetList(searchModel);
                gc_check.DataSource = checkModels;
            }
            catch (Exception ex)
            {

                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }
        }

        private void sbtn_print_Click(object sender, EventArgs e)
        {

            InitData();
        }

        private void sbtn_reset_Click(object sender, EventArgs e)
        {
            try
            {
                if (DevExpress.XtraEditors.XtraMessageBox.Show("是否确认重置原材料盘点数据？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ModelAPI<CleanCheckModel> apiCCheck = new ModelAPI<CleanCheckModel>();
                    apiCCheck.Delete("RW12");
                    InitData();
                }

            }
            catch (Exception ex)
            {

                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }
        }

    }
}