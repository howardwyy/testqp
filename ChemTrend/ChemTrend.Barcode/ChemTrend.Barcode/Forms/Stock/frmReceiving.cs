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
using BarcodeModel.MODEL.Barcode.RW.Operation;
using BarcodeModel.API;
using BarcodeModel.MODEL.Barcode;
using ChemTrend.Barcode.Utils;
using ChemTrend.Barcode.Data;

namespace ChemTrend.Barcode.Forms.Stock
{
    public partial class frmReceiving : DevExpress.XtraEditors.XtraForm
    {
        public string ReceiveLine;
        private string[] barcodes;

        public ReceiveDetailModel rdModel;


        ModelAPI<LocationModel> apiWarehouse = new ModelAPI<LocationModel>();
        List<LocationModel> listWarehouse;
        LocationModel searchWHModel;


        ModelAPI<RWBarcodeModel> apiBarcode = new ModelAPI<RWBarcodeModel>();
        List<RWBarcodeModel> listBarcode = null;
        RWBarcodeModel searchModel = null;
        //已领数量
        private decimal ReceivedCount = 0;
        //剩余数量
        private decimal ReceiveSurplusCount = 0;
        //正在领的数量
        private decimal ReceivingCount = 0;
        public frmReceiving()
        {
            InitializeComponent();
        }

        private void frmReceiving_Load(object sender, EventArgs e)
        {
            if (rdModel != null)
            {
                this.te_wo.Text = rdModel.ReceiveID;
                this.te_qty.Text = rdModel.ReceiveCount.ToString();
                this.te_qtyed.Text = rdModel.ReceivedCount.ToString();
                this.te_qty_surplus.Text = rdModel.ReceivedSurplusCount.ToString();
                this.te_unit.Text = rdModel.ReceiveUnit;
                this.te_stockcode.Text = rdModel.StockCode;
                this.te_stockname.Text = rdModel.StockName;

                decimal.TryParse(rdModel.ReceivedSurplusCount.ToString(), out ReceiveSurplusCount);

                InitData();
            }
        }

        private void InitData()
        {
            try
            {
                searchModel = new RWBarcodeModel()
                {
                    SearchOrderBy = "RW01010 DESC",
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


                listWarehouse = apiWarehouse.GetList(searchWHModel);
                gc_warehouse.DataSource = listWarehouse;
                this.gv_warehouse.FocusedRowHandle = 0;
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }

        }


        private void sbtn_create_Click(object sender, EventArgs e)
        {
            try
            {
                ModelAPI<ReceiveOutWarehouseModel> apiROW = new ModelAPI<ReceiveOutWarehouseModel>();
                ReceiveOutWarehouseModel rowModel = new ReceiveOutWarehouseModel();
                rowModel.Remark = AppConfig.BarcodeRemark.领料出库.ToString();
                rowModel.ReceiveID = rdModel.ReceiveID;
                rowModel.ReceiveLine = rdModel.ID.ToString();
                rowModel.ReceivedCount = rdModel.ReceivedCount + ReceivingCount;
                ReceiveSurplusCount = rdModel.ReceiveCount - rdModel.ReceivedCount - ReceivingCount;
                rowModel.ReceiveSurplusCount = ReceiveSurplusCount >= 0 ? ReceiveSurplusCount : 0;
                int[] selectRows = gv_warehouse.GetSelectedRows();
                if (selectRows.Length >= 1)
                {
                    //仓库信息
                    LocationModel locationModel = null;
                    foreach (int row in selectRows)
                    {
                        locationModel = listWarehouse[gv_warehouse.GetDataSourceRowIndex(row)];
                    }
                    rowModel.ReceiveStatus = "2";
                    rowModel.Warehouse = locationModel.Warehouse;
                    rowModel.Bin = locationModel.Location;
                    

                    //条码信息
                    List<string> Barcodes = new List<string>();
                    int[] selectBarcodeRows = gv_barcode.GetSelectedRows();
                    if (selectBarcodeRows.Length >= 1)
                    {
                        foreach (int row in selectBarcodeRows)
                        {
                            Barcodes.Add(listBarcode[gv_barcode.GetDataSourceRowIndex(row)].ID);
                        }
                        rowModel.Barcodes = Barcodes.ToArray();

                        apiROW.Insert(rowModel);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("请选择条码信息！", "确认", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("请选择入库信息！", "确认", MessageBoxButtons.OK);

                }

            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }
        }

        private void sbtn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gv_barcode_RowLoaded(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {
        }

        private void gv_barcode_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (e.ControllerRow >= 0)
            {
                RWBarcodeModel curBarcode = listBarcode[gv_barcode.GetDataSourceRowIndex(e.ControllerRow)];
                if (gv_barcode.IsRowSelected(e.ControllerRow))
                {
                    if (ReceiveSurplusCount > ReceivingCount)
                    {
                        //ReceivingCount += curBarcode.StockUnitQty;
                        //if (ReceiveSurplusCount > ReceivingCount)
                        //{
                        //    gv_barcode.SelectRow(e.ControllerRow);
                        //}
                        //te_qty_cur.Text = ReceivingCount.ToString();
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("领料操作已经完成，不能再次领料！", "确认", MessageBoxButtons.OK);
                        gv_barcode.UnselectRow(e.ControllerRow);
                    }

                    ReceivingCount += curBarcode.StockUnitQty;
                    if (ReceiveSurplusCount > ReceivingCount)
                    {
                        gv_barcode.SelectRow(e.ControllerRow);
                    }
                    te_qty_cur.Text = ReceivingCount.ToString();
                }
                else
                {
                    ReceivingCount -= curBarcode.StockUnitQty;
                    if (ReceiveSurplusCount > ReceivingCount)
                    {
                        gv_barcode.UnselectRow(e.ControllerRow);
                    }
                    te_qty_cur.Text = ReceivingCount.ToString();
                }

            }
        }

    }
}