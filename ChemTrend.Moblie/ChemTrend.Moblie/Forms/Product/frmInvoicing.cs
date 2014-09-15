using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChemTrend.Moblie.Forms.Product
{
    public partial class frmInvoicing : ChemTrend.Moblie.Forms.Base.BaseTForm
    {

        public InvoiceModel curInvoiceModel { set; get; }
        public InvoiceDetailModel curInvoiceDetailModel { set; get; }

        public frmInvoicing()
        {
            InitializeComponent();
        }
    }
}