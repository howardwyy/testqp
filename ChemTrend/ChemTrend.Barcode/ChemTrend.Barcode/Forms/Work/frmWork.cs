using ChemTrend.Barcode.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChemTrend.Barcode.Forms.Work
{
    public partial class frmWork : Form
    {
        public frmWork()
        {
            InitializeComponent();
        }

        private void frmWork_Load(object sender, EventArgs e)
        {
            InitView();
            InitData();
        }

        private void InitData()
        { 
        }

        private void InitView()
        {
            cbox_status.Properties.Items.AddRange(AppConfig.GetWorkStatus());
        }

        private void sbtn_query_Click(object sender, EventArgs e)
        {

        }
    }
}
