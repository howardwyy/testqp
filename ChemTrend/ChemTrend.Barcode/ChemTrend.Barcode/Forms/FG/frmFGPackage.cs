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
using BarcodeModel.MODEL.Barcode.FG.Operation;
using ChemTrend.Barcode.Utils;
using BarcodeModel.MODEL.Barcode.FG;
using DevExpress.XtraEditors.DXErrorProvider;
using ChemTrend.Barcode.Data;
using DevExpress.XtraReports.UI;
using ChemTrend.Barcode.Forms.Print;
using ChemTrend.Barcode.Report;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace ChemTrend.Barcode.Forms.FG
{
    public partial class frmFGPackage : DevExpress.XtraEditors.XtraForm
    {

        ModelAPI<FGPackageModel> apiPacking = new ModelAPI<FGPackageModel>();
        List<FGPackageModel> listPacking = null;
        FGPackageModel searchModel = null;

        ModelAPI<FGBarcodeModel> apiBarcode = new ModelAPI<FGBarcodeModel>();
        List<FGBarcodeModel> listBarcode = null;

        FGPackageModel curFGPackageModel;

        public frmFGPackage()
        {
            InitializeComponent();
        }


        private void frmFGPackage_Load(object sender, EventArgs e)
        {
            InitValidationRules();
            InitView();
            InitData();
        }

        private void InitView()
        {
            de_create_begin.Text = DateTimeUtil.GetFirstDayOfMonth();
            de_create_end.Text = DateTimeUtil.GetLastDayOfMonth();

            cbox_status.Properties.Items.AddRange(AppConfig.GetPackingStatus());
        }

        private void InitValidationRules()
        {
            ConditionValidationRule validationRule = new ConditionValidationRule();
            validationRule.ConditionOperator = ConditionOperator.GreaterOrEqual;
            validationRule.ErrorText = "请输入创建数量！";
            validationRule.Value1 = 1;
            dxvp_count.SetValidationRule(this.te_count, validationRule);
        }


        private void InitData()
        {
            int status = 0;
            if (!string.IsNullOrEmpty(cbox_status.Text))
            {
                int.TryParse((cbox_status.SelectedItem as ComboBoxEditData).Value, out status);
            }
            searchModel = new FGPackageModel();
            if (!String.IsNullOrEmpty(de_create_begin.Text) && !String.IsNullOrEmpty(de_create_end.Text))
            {
                DateTime beginTime = DateTime.MinValue;
                DateTime.TryParse(de_create_begin.Text, out beginTime);
                searchModel.BeginTime = beginTime;

                DateTime endTime = DateTime.MaxValue;
                DateTime.TryParse(de_create_end.Text, out endTime);
                searchModel.EndTime = endTime;
            }
            if (!String.IsNullOrEmpty(te_packingcode.Text))
            {
                searchModel.ID = te_packingcode.Text.Trim();
            }
            if (status >= 1)
            {
                searchModel.Status = status;
            }

            listPacking = apiPacking.GetList(searchModel);
            gc_packing.DataSource = listPacking;

            gc_packing_status.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            BaseFormatter formatBase = new BaseFormatter();
            gc_packing_status.DisplayFormat.Format = formatBase;
            formatBase.EventHandler += new OverideFormat(formatBase_EventHandler);

        }
        private void InitDetailsData()
        {
            FGBarcodeModel searchModel = new FGBarcodeModel()
            {
                doPager = false,
                BoxID = curFGPackageModel.ID
            };

            listBarcode = apiBarcode.GetList(searchModel);
            gc_packing_details.DataSource = listBarcode;
        }

        //状态（1，未使用；2.使用中；3，使用完）
        private string formatBase_EventHandler(string format, object arg, IFormatProvider formatProvider)
        {
            int state = int.Parse(arg.ToString());
            if (state == 1)
                return "未使用";
            if (state == 2)
                return "使用中";
            if (state == 3)
                return "使用完";
            return "未使用";
        }
        private void sbtn_query_Click(object sender, EventArgs e)
        {
            InitData();
        }

        private void sbtn_candp_Click(object sender, EventArgs e)
        {
            if (dxvp_count.Validate())
            {
                int count = 1;
                int.TryParse(te_count.Text, out count);
                frmMain fMain = (frmMain)this.ParentForm;
                FGPackageModel FGPackageModel = new FGPackageModel()
                {
                    Count = count,
                    UserName = fMain.userName,
                    UserId = fMain.userId
                };
                FGPackageModel returnModel = apiPacking.Insert(FGPackageModel);
                FGPackageModel[] FGPackageModels = returnModel.PackingModels;
                if (FGPackageModels.Length >= 1)
                {
                    if (DevExpress.XtraEditors.XtraMessageBox.Show("装箱条码生成完成！\r\n是否打印生成的条码信息？", "打印", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        List<XtraReport> reports = new List<XtraReport>();
                        foreach (FGPackageModel model in FGPackageModels)
                        {
                            repFGPackage report = new repFGPackage();
                            report.model = model;
                            report.CreateDocument();
                            reports.Add(report);
                        }
                        frmMutiPrint mutiPrint = new frmMutiPrint();
                        mutiPrint.reports = reports;
                        mutiPrint.Show();
                    }
                }

                InitData();
            }
        }


        private void sbtn_print_Click(object sender, EventArgs e)
        {
            List<XtraReport> reports = new List<XtraReport>();
            int[] selectRows = gv_packing.GetSelectedRows();

            foreach (int row in selectRows)
            {
                FGPackageModel model = listPacking[gv_packing.GetDataSourceRowIndex(row)];
                repFGPackage report = new repFGPackage();
                report.model = model;
                report.CreateDocument();
                reports.Add(report);
            }
            frmMutiPrint mutiPrint = new frmMutiPrint();
            mutiPrint.reports = reports;
            mutiPrint.Show();
        }

        private void gv_packing_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;

            Point pt = view.GridControl.PointToClient(Control.MousePosition);

            DoRowDoubleClick(view, pt);



        }

        private void DoRowDoubleClick(GridView view, Point pt)
        {

            GridHitInfo info = view.CalcHitInfo(pt);

            if (info.InRow || info.InRowCell)
            {

                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                curFGPackageModel = listPacking[gv_packing.GetDataSourceRowIndex(info.RowHandle)];
                InitDetailsData();
            }

        }

        private void sbtn_packing_del_Click(object sender, EventArgs e)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("确认移除该条码信息？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int[] rows = gv_packing_details.GetSelectedRows();
                if (rows.Length >= 1)
                {
                    foreach (int r in rows)
                    {
                        FGBarcodeModel barcodeModel = listBarcode[gv_packing_details.GetDataSourceRowIndex(r)];
                        barcodeModel.BoxID = "";
                        apiBarcode.Update(barcodeModel);
                    }

                    //判断该装箱条码是否，没有关联barcode信息
                    FGBarcodeModel searchModelPacking = new FGBarcodeModel()
                    {
                        BoxID = curFGPackageModel.ID
                    };
                    List<FGBarcodeModel> listRW = apiBarcode.GetList(searchModelPacking);
                    if (listRW.Count == 0)
                    {
                        curFGPackageModel.Status = (int)AppConfig.Packing.使用完;
                        apiPacking.Update(curFGPackageModel);
                        InitData();
                    }
                    InitDetailsData();
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("请选中行信息!", "确认", MessageBoxButtons.OK);
                }
            }
        }

        private void sbtn_packing_add_sure_Click(object sender, EventArgs e)
        {
            if (dxvp_barcode.Validate())
            {
                FGBarcodeModel searchModel = new FGBarcodeModel()
                {
                    ID = te_barcode.Text
                };
                FGBarcodeModel barcodeModel = apiBarcode.GetModel(searchModel);
                barcodeModel.BoxID = curFGPackageModel.ID;
                apiBarcode.Update(barcodeModel);

                InitDetailsData();
            }
        }

        private void sbtn_packing_add_un_Click(object sender, EventArgs e)
        {
            pcc_packing_add.Hide();
        }

        private void sbtn_packing_add_Click(object sender, EventArgs e)
        {
            if (curFGPackageModel != null)
            {
                if (curFGPackageModel.Status.Equals((int)AppConfig.Packing.使用完))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("该条码信息已经使用完!", "确认", MessageBoxButtons.OK);
                }
                else
                {
                    pcc_packing_add.Show();
                }
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请选中行信息!", "确认", MessageBoxButtons.OK);
            }
        }
    }
}