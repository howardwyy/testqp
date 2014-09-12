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
using ChemTrend.Barcode.Data;
using BarcodeModel.MODEL.Barcode.WORP;
using BarcodeModel.API;

namespace ChemTrend.Barcode.Forms.Work
{
    public partial class frmWorkMapping : DevExpress.XtraEditors.XtraForm
    {

        public ModelAPI<MappingModel> apiMapping = new ModelAPI<MappingModel>();
        public MappingModel mappingModel = null;

        public static int actionType { get; set; }
        public frmWorkMapping()
        {
            InitializeComponent();
        }

        private void frmWorkMapping_Load(object sender, EventArgs e)
        {
            InitView();
        }

        private void InitView()
        {
            switch (actionType)
            {
                case (int)AppConfig.ActionType.Insert:
                    sbtn_create.Visible = true;
                    sbtn_update.Visible = false;
                    break;
                case (int)AppConfig.ActionType.Update:
                    sbtn_create.Visible = false;
                    sbtn_update.Visible = Visible;
                    if (mappingModel != null)
                    {
                        this.te_id.Text = mappingModel.ID + "";
                        te_fgcode.Text = mappingModel.FGCode;
                        te_fgname.Text = mappingModel.FGName;
                        te_workcenter.Text = mappingModel.WorkCenter;
                        te_bbo.Text = mappingModel.BeginBom + "";
                        te_bboi.Text = mappingModel.BeginBomIndex + "";
                        te_ebo.Text = mappingModel.EndBom + "";
                        te_eboi.Text = mappingModel.EndBomIndex + "";
                        te_hours.Text = mappingModel.Hours + "";
                    }
                    break;
                default:
                    break;
            }
        }

        private void sbtn_update_Click(object sender, EventArgs e)
        {

        }

        private void sbtn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbtn_create_Click(object sender, EventArgs e)
        {
            try
            {
                int beginBom = 0;
                int.TryParse(te_bbo.Text, out beginBom);


                int beginBomIndex = 0;
                int.TryParse(te_bboi.Text, out beginBomIndex);

                int endBom = 0;
                int.TryParse(te_ebo.Text, out endBom);


                int endBomIndex = 0;
                int.TryParse(te_eboi.Text, out endBomIndex);

                decimal hours = 0;
                decimal.TryParse(te_hours.Text, out hours);

                apiMapping.Insert(new MappingModel()
                {
                    FGCode = te_fgcode.Text,
                    FGName = te_fgname.Text,
                    WorkCenter = te_workcenter.Text,
                    BeginBom = beginBom,
                    BeginBomIndex = beginBomIndex,
                    EndBom = endBom,
                    EndBomIndex = endBomIndex,
                    Type = 2,
                    Hours = hours
                });
                this.DialogResult = DialogResult.Yes;
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }
        }


    }
}