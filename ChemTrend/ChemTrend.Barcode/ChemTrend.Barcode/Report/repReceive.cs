using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BarcodeModel.MODEL.Barcode.RW;
using System.Collections.Generic;

namespace ChemTrend.Barcode.Report
{
    public partial class repReceive : DevExpress.XtraReports.UI.XtraReport
    {
        public repReceive()
        {
            InitializeComponent();
        }

        public repReceive(List<ReceiveDetailModel> RDModels, ReceiveModel receiveModel)
        {

            InitializeComponent();
            if (receiveModel != null)
            {
                xbarcode.Text = receiveModel.ID;
                this.xlbl_hopetime.Text = receiveModel.HopeTime.ToString("yyyy-MM-dd");
                this.xlbl_receive.Text = receiveModel.ID;
            }
            if (RDModels != null)
            {
                this.DataSource = RDModels;
                this.xtcell_no.DataBindings.Add("Text", RDModels, "LineID");
                this.xtcell_stockname.DataBindings.Add("Text", RDModels, "StockCode");
                this.xtcell_receivecount.DataBindings.Add("Text", RDModels, "ReceiveCount");
                this.xtcell_unit.DataBindings.Add("Text", RDModels, "ReceiveUnit");
            }
        }
        private void TopMargin_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {



        }

    }
}
