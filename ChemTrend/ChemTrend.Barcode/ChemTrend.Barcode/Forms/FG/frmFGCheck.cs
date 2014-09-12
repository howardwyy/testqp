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
using BarcodeModel.MODEL.Barcode.FG.Operation;

namespace ChemTrend.Barcode.Forms.FG
{
    public partial class frmFGCheck : DevExpress.XtraEditors.XtraForm
    {
        ModelAPI<FGCheckModel> apiCheck = new ModelAPI<FGCheckModel>();
        List<FGCheckModel> checkModels = new List<FGCheckModel>();
        FGCheckModel searchModel = null;
        public frmFGCheck()
        {
            InitializeComponent();
        }

        private void frmFGCheck_Load(object sender, EventArgs e)
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

        private void sbtn_reset_Click(object sender, EventArgs e)
        {
            try
            {
                if (DevExpress.XtraEditors.XtraMessageBox.Show("是否确认重置成品盘点数据？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ModelAPI<CleanFGCheckModel> apiCCheck = new ModelAPI<CleanFGCheckModel>();
                    apiCCheck.Delete("FG12");
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