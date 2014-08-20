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
using DevExpress.XtraPrinting;
using DevExpress.XtraReports; 
using DevExpress.XtraReports.UI;

namespace ChemTrend.Barcode.Forms.Print
{
    public partial class frmMutiPrint : DevExpress.XtraEditors.XtraForm
    {
        public List<XtraReport> reports { set; get; }

        public frmMutiPrint()
        {
            InitializeComponent();
        }

        private void frmMutiPrint_Load(object sender, EventArgs e)
        {
            PrintingSystem pSystem = new PrintingSystem();
            this.dView.PrintingSystem = pSystem;
            Page page;
            foreach (XtraReport report in reports)
            {
                page = report.Pages.First;
                dView.PrintingSystem.Pages.Add(page);
            }

        }
    }
}