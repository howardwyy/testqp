using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BarcodeModel.MODEL.Barcode.RW;
using System.Collections.Generic;

namespace ChemTrend.Barcode.Report
{
    public partial class repRWInvoice : DevExpress.XtraReports.UI.XtraReport
    {
        public repRWInvoice()
        {
            InitializeComponent();
        }

        public repRWInvoice(List<RWInvoiceDetailModel> invoiceDetailModels, RWInvoiceModel invoiceModel)
        {
            InitializeComponent();

            this.DataSource = invoiceDetailModels;

            this.xtcell_stock.DataBindings.Add("Text", invoiceDetailModels, "StockName");
            this.xtcell_linenum.DataBindings.Add("Text", invoiceDetailModels, "LineNum");
            this.xtcell_count.DataBindings.Add("Text", invoiceDetailModels, "InvoiceCount");
            this.xtcell_unit.DataBindings.Add("Text", invoiceDetailModels, "Unit");
            

            if (invoiceModel != null)
            {
                this.xlbl_customer.Text = invoiceModel.CustomerName;
                this.xlbl_invoice.Text = invoiceModel.ID;
                this.xlbl_hopetime.Text = invoiceModel.HopeTime.ToString("yyyy-MM-dd");
                this.xbarcode.Text = invoiceModel.ID;
                if (invoiceModel.isUrgent >= 1) {
                    this.xcbox_isurgent.Checked = true;
                }
            }

        }

    }
}
