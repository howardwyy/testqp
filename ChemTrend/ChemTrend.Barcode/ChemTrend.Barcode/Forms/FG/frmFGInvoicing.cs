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
using BarcodeModel.MODEL.Barcode.FG;
using BarcodeModel.API;
using BarcodeModel.MODEL.Barcode.FG.Operation;

namespace ChemTrend.Barcode.Forms.FG
{
    public partial class frmFGInvoicing : DevExpress.XtraEditors.XtraForm
    {

        public static BarcodeModel.MODEL.Barcode.FG.InvoiceDetailModel IDModel { get; set; }

        public string InvoiceLine;
        private string[] Barcodes;

        ModelAPI<FGBarcodeModel> apiBarcode = new ModelAPI<FGBarcodeModel>();
        List<FGBarcodeModel> listBarcode = null;
        FGBarcodeModel searchModel = null;

        //已领数量
        private decimal InvoicedCount = 0;
        //剩余数量
        private decimal InvoiceSurplusCount = 0;
        //正在领的数量
        private decimal InvoicingCount = 0;

        public frmFGInvoicing()
        {
            InitializeComponent();
        }

        private void frmFGInvoicing_Load(object sender, EventArgs e)
        {
            if (IDModel != null) {
                this.te_wo.Text = IDModel.InvoiceID;
                this.te_qty.Text = IDModel.InvoiceCount.ToString();
                this.te_qtyed.Text = IDModel.InvoicedCount.ToString();
                this.te_qty_surplus.Text = IDModel.InvoiceSurplusCount.ToString();
                this.te_unit.Text = IDModel.Unit;
                this.te_stockcode.Text = IDModel.StockID;
                this.te_stockname.Text = IDModel.StockName;

                decimal.TryParse(IDModel.InvoiceSurplusCount.ToString(), out InvoiceSurplusCount);

                InitData();
            }
        }
        private void InitData() {
            searchModel = new FGBarcodeModel()
            {
                SearchOrderBy = "FG01010 DESC",
                Status = (int)AppConfig.Barcode.已入库,
                doPager = false
            };

            if (!String.IsNullOrEmpty(te_stockcode.Text))
            {
                searchModel.StockCode = te_stockcode.Text;
            }
            listBarcode = apiBarcode.GetList(searchModel);

            gc_barcode.DataSource = listBarcode;
            this.gv_barcode.FocusedRowHandle = 0;
        }

        private void sbtn_create_Click(object sender, EventArgs e)
        {
            try
            {
                ModelAPI<InvoicingFGModel> apiInvoicing = new ModelAPI<InvoicingFGModel>();
                InvoicingFGModel invoicingModel = new InvoicingFGModel();
                invoicingModel.Remark = AppConfig.BarcodeRemark.发货出库.ToString();
                invoicingModel.InvoiceID = IDModel.InvoiceID;
                invoicingModel.InvoiceLine = IDModel.ID.ToString();
                invoicingModel.InvoicedCount = IDModel.InvoicedCount + InvoicingCount;
                InvoiceSurplusCount = IDModel.InvoiceCount - IDModel.InvoicedCount - InvoicingCount;
                invoicingModel.InvoiceSurplusCount = InvoiceSurplusCount >= 0 ? InvoiceSurplusCount : 0;

                invoicingModel.InvoiceStatus = "2";

                //条码信息
                List<string> Barcodes = new List<string>();
                int[] selectBarcodeRows = gv_barcode.GetSelectedRows();
                if (selectBarcodeRows.Length >= 1)
                {
                    foreach (int row in selectBarcodeRows)
                    {
                        Barcodes.Add(listBarcode[gv_barcode.GetDataSourceRowIndex(row)].ID);
                    }
                    invoicingModel.Barcodes = Barcodes.ToArray();

                    apiInvoicing.Insert(invoicingModel);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("请选择条码信息！", "确认", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }
        }

        private void gv_barcode_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (e.ControllerRow >= 0)
            {
                FGBarcodeModel curBarcode = listBarcode[gv_barcode.GetDataSourceRowIndex(e.ControllerRow)];
                if (gv_barcode.IsRowSelected(e.ControllerRow))
                {
                    if (InvoiceSurplusCount > InvoicingCount)
                    {
                        //InvoicingCount += curBarcode.StockUnitQty;
                        //if (InvoiceSurplusCount > InvoicingCount)
                        //{
                        //    gv_barcode.SelectRow(e.ControllerRow);
                        //}
                        //te_qty_cur.Text = InvoicingCount.ToString();
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("发货操作已经完成，不能再次发货！", "确认", MessageBoxButtons.OK);
                        gv_barcode.UnselectRow(e.ControllerRow);
                    }

                    InvoicingCount += curBarcode.UnitQty;
                    if (InvoiceSurplusCount > InvoicingCount)
                    {
                        gv_barcode.SelectRow(e.ControllerRow);
                    }
                    te_qty_cur.Text = InvoicingCount.ToString();
                }
                else
                {
                    InvoicingCount -= curBarcode.UnitQty;
                    if (InvoiceSurplusCount > InvoicingCount)
                    {
                        gv_barcode.UnselectRow(e.ControllerRow);
                    }
                    te_qty_cur.Text = InvoicingCount.ToString();
                }

            }
        }

    }
}