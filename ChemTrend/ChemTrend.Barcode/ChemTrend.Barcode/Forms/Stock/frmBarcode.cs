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
using DevExpress.XtraReports.UI;
using ChemTrend.Barcode.Forms.Report;
using ChemTrend.Barcode.Forms.Print;
using ChemTrend.Barcode.Utils;
using ChemTrend.Barcode.Data;
using BarcodeModel.MODEL.Barcode.RW.Operation;

namespace ChemTrend.Barcode.Forms.Stock
{
    public partial class frmBarcode : DevExpress.XtraEditors.XtraForm
    {
        ModelAPI<RWBarcodeModel> apiBarcode = new ModelAPI<RWBarcodeModel>();
        List<RWBarcodeModel> listBarcode = null;
        RWBarcodeModel searchModel = null;
        private int pageSize = 50;

        public frmBarcode()
        {
            InitializeComponent();
        }
        private void frmBarcode_Load(object sender, EventArgs e)
        {
            cbox_status.Properties.Items.AddRange(AppConfig.GetBarcodeStatus());

            searchModel = new RWBarcodeModel()
            {
                SearchOrderBy = "RW01001 DESC",
                PageIndex = ucPager.PageCurrent,
                PageSize = pageSize
            };
            InitData();
            InitValidationRules();
        }

        private void InitData()
        {


            ucPager.EventPaging += ucPager_EventPaging;
            ucPager.PageSize = pageSize;
            ucPager.Bind();

            gc_status.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            BaseFormatter formatBase = new BaseFormatter();
            gc_status.DisplayFormat.Format = formatBase;
            formatBase.EventHandler += new OverideFormat(formatBase_EventHandler);

        }
        private void InitValidationRules()
        {



        }

        private int ucPager_EventPaging(Controls.EventPagingArg e)
        {
            try
            {
                searchModel.PageIndex = ucPager.PageCurrent;
                searchModel.PageSize = ucPager.PageSize;
                listBarcode = apiBarcode.GetList(searchModel);
                gc_barcode.DataSource = listBarcode;
                this.gv_barcode.FocusedRowHandle = 0;
                if (listBarcode != null && listBarcode.Count >= 1)
                {
                    return listBarcode[0].totalCount;
                }
                else
                    return 0;
            }
            catch (ApiException ex)
            {
                MessageBox.Show(ex.ApiExceptionMessage.ExceptionMessage);
                return 0;
            }
        }

        private void bbi_stock_create_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmBarcodeNew frmBarcodeNew = new frmBarcodeNew();
            frmBarcodeNew.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = frmBarcodeNew.ShowDialog();
            if (result == DialogResult.OK)
            {
                InitData();
            }
        }

        private void sbtn_query_Click(object sender, EventArgs e)
        {
            int status = 0;
            if (!string.IsNullOrEmpty(cbox_status.Text))
            {
                int.TryParse((cbox_status.SelectedItem as ComboBoxEditData).Value, out status);
            }

            searchModel = new RWBarcodeModel()
            {
                SearchOrderBy = "RW01001 DESC",
                PageIndex = ucPager.PageCurrent,
                PageSize = pageSize
            };
            if (!String.IsNullOrEmpty(te_barcode.Text))
            {
                searchModel.ID = te_barcode.Text;
            }
            if (!String.IsNullOrEmpty(de_inwh_begin.Text) && !String.IsNullOrEmpty(de_inwh_end.Text))
            {
                searchModel.BeginTimeInWH = de_inwh_begin.DateTime;
                searchModel.EndTimeInWH = de_inwh_end.DateTime;
            }
            if (!String.IsNullOrEmpty(te_stockcode.Text))
            {
                searchModel.StockCode = te_stockcode.Text;
            }
            if (!String.IsNullOrEmpty(te_stockname.Text))
            {
                searchModel.StockName= te_stockname.Text;
            }
            if (!String.IsNullOrEmpty(te_po.Text))
            {
                searchModel.PO = te_po.Text;
            }
            if (!String.IsNullOrEmpty(te_supplierbatch.Text))
            {
                searchModel.SupplierBatch = te_supplierbatch.Text;
            }
            if (!String.IsNullOrEmpty(te_batch.Text)) {
                searchModel.BatchID = te_batch.Text;
            }
            if (status >= 1)
            {
                searchModel.Status = status;
            }
            InitData();
        }

        private void sbtn_print_Click(object sender, EventArgs e)
        {
            printBarcode();

        }

        private void printBarcode()
        {
            int[] selectRows = gv_barcode.GetSelectedRows();
            if (check_selected(selectRows))
            {
                List<XtraReport> reports = new List<XtraReport>();
                foreach (int row in selectRows)
                {
                    RWBarcodeModel model = listBarcode[gv_barcode.GetDataSourceRowIndex(row)];
                    repStock report = new repStock();
                    report.model = model;
                    report.CreateDocument();
                    reports.Add(report);
                }
                frmMutiPrint mutiPrint = new frmMutiPrint();
                mutiPrint.reports = reports;
                mutiPrint.Show();

            }
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void nbitem_packing_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int[] selectRows = gv_barcode.GetSelectedRows();
            if (check_selected(selectRows))
            {
                List<string> selectIds = new List<string>();
                foreach (int row in selectRows)
                {
                    RWBarcodeModel item = listBarcode[gv_barcode.GetDataSourceRowIndex(row)];
                    if (!check_destory(item))
                    {
                        return;
                    }
                    if (!string.IsNullOrEmpty(item.BoxID))
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("您选择的行信息有误！\n\r\n\r 选中条码中存在装箱信息。", "警告", MessageBoxButtons.OK);
                        return;
                    }
                    selectIds.Add(item.ID);
                }

                frmPackingBarcode pBarcode = new frmPackingBarcode();
                pBarcode.ids = selectIds;
                DialogResult result = pBarcode.ShowDialog();
                if (result == DialogResult.OK)
                {
                    InitData();
                    return;
                }
            }

        }

        private void nbitem_print_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            printBarcode();
        }

        private void nbitem_inwarehouse_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int[] selectRows = gv_barcode.GetSelectedRows();
            if (check_selected(selectRows))
            {
                List<string> selectIds = new List<string>();
                string wCode = "";
                foreach (int row in selectRows)
                {
                    RWBarcodeModel model = listBarcode[gv_barcode.GetDataSourceRowIndex(row)];
                    if (!check_destory(model))
                    {
                        return;
                    }
                    if (model.Status != (int)AppConfig.Barcode.未扫描)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("您选择的行信息有误！\n\r\n\r 存在不能再次入库的条码信息", "警告", MessageBoxButtons.OK);
                        return;
                    }
                    if (!string.IsNullOrEmpty(wCode))
                    {
                        if (!wCode.Equals(model.Warehouse))
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("您选择的行信息有误！\n\r\n\r 存在多个的仓库信息。", "警告", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    wCode = model.Warehouse;
                    selectIds.Add(model.ID);
                }

                frmWarehouseBarcode wBarcode = new frmWarehouseBarcode();
                wBarcode.ids = selectIds;
                wBarcode.wCode = wCode;
                wBarcode.Action = (int)AppConfig.BarcodeRemark.条码入库;
                DialogResult result = wBarcode.ShowDialog();
                if (result == DialogResult.OK)
                {
                    InitData();
                }
            }
        }


        //状态（1未扫描 2已入库 3已出库 4 移库中 5 报废）
        private string formatBase_EventHandler(string format, object arg, IFormatProvider formatProvider)
        {
            int state = int.Parse(arg.ToString());
            if (state == (int)AppConfig.Barcode.未扫描)
                return AppConfig.Barcode.未扫描.ToString();
            if (state == (int)AppConfig.Barcode.已入库)
                return AppConfig.Barcode.已入库.ToString();
            if (state == (int)AppConfig.Barcode.已出库)
                return AppConfig.Barcode.已出库.ToString();
            if (state == (int)AppConfig.Barcode.移库中)
                return AppConfig.Barcode.移库中.ToString();
            if (state == (int)AppConfig.Barcode.报废)
                return AppConfig.Barcode.报废.ToString();
            return AppConfig.Barcode.未扫描.ToString();
        }

        private void nbitem_move_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int[] selectRows = gv_barcode.GetSelectedRows();

            if (check_selected(selectRows))
            {

                List<string> selectIds = new List<string>();
                string wCode = "";
                foreach (int row in selectRows)
                {
                    RWBarcodeModel model = listBarcode[gv_barcode.GetDataSourceRowIndex(row)];
                    if (!check_destory(model))
                    {
                        return;
                    }
                    if (model.Location == null || model.Location.Length == 0)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("您选择的行信息有误！\n\r\n\r 存在未入库信息？", "确认", MessageBoxButtons.OK);
                        return;
                    }
                    if (!string.IsNullOrEmpty(wCode))
                    {
                        if (!wCode.Equals(model.Warehouse))
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("您选择的行信息有误！\n\r\n\r 存在多个的仓库信息。", "警告", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    wCode = model.Warehouse;
                    selectIds.Add(model.ID);
                }

                frmWarehouseBarcode wBarcode = new frmWarehouseBarcode();
                wBarcode.ids = selectIds;
                wBarcode.Action = (int)AppConfig.BarcodeRemark.条码移库;
                DialogResult result = wBarcode.ShowDialog();
                if (result == DialogResult.OK)
                {
                    InitData();
                }
            }
        }

        private void nbi_destroy_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int[] selectRows = gv_barcode.GetSelectedRows();
            if (check_selected(selectRows))
            {
                if (DevExpress.XtraEditors.XtraMessageBox.Show("是否确认报废选中信息？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    List<string> ids = new List<string>();
                    foreach (int row in selectRows)
                    {
                        RWBarcodeModel model = listBarcode[gv_barcode.GetDataSourceRowIndex(row)];
                        if (!check_destory(model))
                        {
                            return;
                        }
                        ids.Add(model.ID);
                    }


                    ModelAPI<DestroyBarcodeModel> apiDestory = new ModelAPI<DestroyBarcodeModel>();
                    DestroyBarcodeModel destoryModel = new DestroyBarcodeModel()
                    {
                        Barcodes = ids.ToArray(),
                        Remark = AppConfig.Barcode.报废.ToString(),
                    };
                    apiDestory.Insert(destoryModel);
                    InitData();
                }
            }
        }

        private void gv_barcode_DoubleClick(object sender, EventArgs e)
        {
            RWBarcodeModel focuseBarcode = gv_barcode.GetFocusedRow() as RWBarcodeModel;
            ModelAPI<RWHistoryModel> apiRWHistory = new ModelAPI<RWHistoryModel>();
            RWHistoryModel searchRWHistory = new RWHistoryModel();
            searchRWHistory.BarcodeID = focuseBarcode.ID;
            List<RWHistoryModel> listRWHistory = apiRWHistory.GetList(searchRWHistory);
            if (listRWHistory.Count >= 1)
            {
                frmBarcodeHistory frmRWHistory = new frmBarcodeHistory();
                frmRWHistory.StartPosition = FormStartPosition.CenterParent;
                frmRWHistory.listRWHistory = listRWHistory;
                DialogResult result = frmRWHistory.ShowDialog();
            }
        }

        private bool check_destory(RWBarcodeModel model)
        {
            if (model.Status == (int)AppConfig.Barcode.报废)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("您选择的行信息有误！\n\r\n\r 存在报废条码信息。", "警告", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private bool check_selected(int[] rows)
        {
            if (rows.Length == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请选中行信息？", "确认", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

    }
}