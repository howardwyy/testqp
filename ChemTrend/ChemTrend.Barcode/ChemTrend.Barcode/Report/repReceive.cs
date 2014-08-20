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
        public List<ReceiveDetailModel> RDModels { get; set; }
        public ReceiveModel receiveModel { get; set; }
        public repReceive()
        {
            InitializeComponent();
        }

        private void TopMargin_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xbc_barcode.Text = receiveModel.ID;

            //SetBinding(RDModels.Count, xrTable2);
            XRTableRow[] xrRow = new XRTableRow[RDModels.Count];
            for (int i = 0; i < xrRow.Length; i++)
            {
                xrRow[i] = new XRTableRow();
                XRTableCell cell_id = new XRTableCell();
                cell_id.DataBindings.Add("Text", RDModels[i], "ID");
                cell_id.Site = header_id.Site;
                XRTableCell cell_stockname = new XRTableCell();
                cell_stockname.DataBindings.Add("Text", RDModels[i], "StockName");
                cell_stockname.Site = header_stockname.Site;


                XRTableCell cell_receiveunit = new XRTableCell();
                cell_receiveunit.DataBindings.Add("Text", RDModels[i], "ReceiveUnit");
                cell_receiveunit.Site = header_unit.Site;


                XRTableCell cell_receivecount = new XRTableCell();
                cell_receivecount.DataBindings.Add("Text", RDModels[i], "ReceiveCount");
                cell_receivecount.Site = header_receivecount.Site;


                XRTableCell cell_receivedcount = new XRTableCell();
                cell_receivedcount.DataBindings.Add("Text", RDModels[i], "ReceivedCount");
                cell_receivedcount.Site = header_receivedcount.Site;

                

                xrRow[i].Cells.Add(cell_id);
                xrRow[i].Cells.Add(cell_stockname);
                xrRow[i].Cells.Add(cell_receiveunit);
                xrRow[i].Cells.Add(cell_receivecount);
                xrRow[i].Cells.Add(cell_receivedcount);
                
            }
            xrt_receive.Rows.AddRange(xrRow);
        }

    }
}
