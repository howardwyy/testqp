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
using BarcodeModel.MODEL.Barcode;

namespace ChemTrend.Barcode.Forms.Work
{
    public partial class frmWorkMapping : DevExpress.XtraEditors.XtraForm
    {

        public ModelAPI<MappingModel> apiMapping = new ModelAPI<MappingModel>();
        public MappingModel mappingModel = null;
        public WorkCenterModel searchWorkCenterModel {set;get;}

        public static int actionType { get; set; }
        public frmWorkMapping()
        {
            InitializeComponent();
        }

        private void frmWorkMapping_Load(object sender, EventArgs e)
        {
            InitView();
            InitData();
        }

        private void InitData()
        {
            try
            {

                ModelAPI<StockModel> apiStock = new ModelAPI<StockModel>();
                StockModel searchStock = new StockModel();
                List<StockModel> listStock = apiStock.GetList(searchStock);
                lue_stockcode.Properties.DataSource = listStock;
                lue_stockcode.ItemIndex = 0;
                if (actionType.Equals((int)AppConfig.ActionType.Update))
                {
                    if (mappingModel.FGCode != null)
                    {
                        this.lue_stockcode.ItemIndex = GetStockItemIndex(listStock, mappingModel.FGCode);
                    }
                }

                ModelAPI<WorkCenterModel> apiWorkCenter = new ModelAPI<WorkCenterModel>();
                List<WorkCenterModel> listWorkCenter = apiWorkCenter.GetList(searchWorkCenterModel);
                lue_workcenter.Properties.DataSource = listWorkCenter;
                lue_workcenter.ItemIndex = 0;
                if (actionType.Equals((int)AppConfig.ActionType.Update))
                {
                    if (mappingModel != null)
                    {
                        this.lue_workcenter.ItemIndex = GetItemIndex(listWorkCenter, mappingModel.WorkCenter);
                    }
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }
          
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
                        lue_stockcode.Text = mappingModel.FGCode;
                        te_fgname.Text = mappingModel.FGName;
                        lue_workcenter.Text = mappingModel.WorkCenter;
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
        private int GetItemIndex(List<WorkCenterModel> list, string id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].WorkcenterCode.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
        private int GetStockItemIndex(List<StockModel> list, string id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].StockCode.Equals(id))
                {
                    return i;
                }
            }
            return -1;
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
                int beginBomIndex = 0;
                int endBom = 0;
                int endBomIndex = 0;
                decimal hours = 0;

                int type = 1;
                if (this.xtab_main.SelectedTabPageIndex == 0)
                {
                    int.TryParse(te_bbo.Text, out beginBom);
                    int.TryParse(te_bboi.Text, out beginBomIndex);
                    int.TryParse(te_ebo.Text, out endBom);
                    int.TryParse(te_eboi.Text, out endBomIndex);
                }
                else
                {
                    type = 2;
                    decimal.TryParse(te_hours.Text, out hours);
                }


                StockModel curStockModel = lue_stockcode.GetSelectedDataRow() as StockModel;
                WorkCenterModel curWorkCenter = lue_workcenter.GetSelectedDataRow() as WorkCenterModel;

                apiMapping.Insert(new MappingModel()
                {
                    FGCode = curStockModel.StockCode,
                    FGName = curStockModel.StockName,
                    WorkCenter = curWorkCenter.WorkcenterCode,
                    BeginBom = beginBom,
                    BeginBomIndex = beginBomIndex,
                    EndBom = endBom,
                    EndBomIndex = endBomIndex,
                    Type = type,
                    Hours = hours
                });
                this.DialogResult = DialogResult.Yes;
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }
        }

        private void rbtn_calc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_calc.Checked) {
                rbtn_fix.Checked = false;
                xtab_main.SelectedTabPageIndex = 0;
            }
        }

        private void rbtn_fix_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_fix.Checked) {
                rbtn_calc.Checked = false;
                xtab_main.SelectedTabPageIndex = 1;
            }
        }


    }
}