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
using BarcodeModel.MODEL.Barcode.FG;
using BarcodeModel.API;
using ChemTrend.Barcode.Report;
using ChemTrend.Barcode.Forms.Print;
using DevExpress.XtraReports.UI;
using ChemTrend.Barcode.Data;
using ChemTrend.Barcode.Utils;

namespace ChemTrend.Barcode.Forms.FG
{
    public partial class frmFGInvoice : DevExpress.XtraEditors.XtraForm
    {

        ModelAPI<InvoiceModel> apiInvoice = new ModelAPI<InvoiceModel>();
        List<InvoiceModel> listInvoice = null;
        public frmFGInvoice()
        {
            InitializeComponent();
        }

        private void frmFGInvoice_Load(object sender, EventArgs e)
        {
            InitData();

        }
        private void InitData()
        {
            InvoiceModel searchModel = new InvoiceModel()
            {

            };
            if (!string.IsNullOrEmpty(tbox_barcode.Text))
            {
                searchModel.ID = tbox_barcode.Text;
            }
            if (!string.IsNullOrEmpty(de_begin.Text) && !string.IsNullOrEmpty(de_end.Text))
            {
                searchModel.BeginInvoiceTime = de_begin.DateTime;
                searchModel.EndInvoiceTime = de_end.DateTime;
            }
            try
            {
                listInvoice = apiInvoice.GetList(searchModel);
                gc_invoice.DataSource = listInvoice;


                col_status.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                BaseFormatter formatBase = new BaseFormatter();
                col_status.DisplayFormat.Format = formatBase;
                formatBase.EventHandler += new OverideFormat(formatBase_EventHandler);


                col_isUrgent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                BaseFormatter fbIsUrgent = new BaseFormatter();
                col_isUrgent.DisplayFormat.Format = fbIsUrgent;
                fbIsUrgent.EventHandler += new OverideFormat(fbIsUrgent_EventHandler);
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }
        }

        private string fbIsUrgent_EventHandler(string format, object arg, IFormatProvider formatProvider)
        {
            int state = int.Parse(arg.ToString());
            if (state == (int)AppConfig.IsCheck.是)
                return AppConfig.IsCheck.是.ToString();
            return AppConfig.IsCheck.否.ToString();
        }

        private string formatBase_EventHandler(string format, object arg, IFormatProvider formatProvider)
        {
            int state = int.Parse(arg.ToString());
            if (state == (int)AppConfig.Receive.已申请)
                return AppConfig.Receive.已申请.ToString();
            if (state == (int)AppConfig.Receive.部分发货)
                return AppConfig.Receive.部分发货.ToString();
            if (state == (int)AppConfig.Receive.关闭)
                return AppConfig.Receive.关闭.ToString();
            return AppConfig.Receive.已申请.ToString();
        }

        private void sbtn_create_Click(object sender, EventArgs e)
        {
            frmFGInvoiceNew frmFGInvoiceNew = new frmFGInvoiceNew();
            frmFGInvoiceNew.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = frmFGInvoiceNew.ShowDialog();
            if (result == DialogResult.OK)
            {
                InitData();
            }
        }

        private void sbtn_query_Click(object sender, EventArgs e)
        {
            InitData();
        }

        private void sbtn_print_Click(object sender, EventArgs e)
        {
            try
            {
                int[] selectRows = gv_invoice.GetSelectedRows();
                if (check_selected(selectRows))
                {
                    List<XtraReport> reports = new List<XtraReport>();
                    ModelAPI<InvoiceModel> apiInvoice = new ModelAPI<InvoiceModel>();
                    foreach (int row in selectRows)
                    {
                        InvoiceModel invoiceModel = listInvoice[gv_invoice.GetDataSourceRowIndex(row)]; ;

                        ModelAPI<InvoiceDetailModel> apiInvoiceDetails = new ModelAPI<InvoiceDetailModel>();
                        InvoiceDetailModel searchInvoiceDetail = new InvoiceDetailModel();
                        searchInvoiceDetail.InvoiceID = invoiceModel.ID;

                        List<InvoiceDetailModel> listIDetails = apiInvoiceDetails.GetList(searchInvoiceDetail);

                        repFGInvoice report = new repFGInvoice(listIDetails, invoiceModel);
                        report.CreateDocument();
                        reports.Add(report);
                    }

                    frmMutiPrint mutiPrint = new frmMutiPrint();
                    mutiPrint.reports = reports;
                    mutiPrint.Show();
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }
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

        private void gv_invoice_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                InvoiceModel curInvoiceModel = gv_invoice.GetFocusedRow() as InvoiceModel;

                frmFGInvoiceDetails frmIDetails = new frmFGInvoiceDetails();
                frmIDetails.StartPosition = FormStartPosition.CenterParent;
                frmIDetails.curInvoiceModel = curInvoiceModel;
                DialogResult result = frmIDetails.ShowDialog();
                if (result == DialogResult.OK)
                {
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