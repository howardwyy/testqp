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
using BarcodeModel.API;
using BarcodeModel.MODEL.Barcode.RW.Operation;

namespace ChemTrend.Barcode.Forms.Stock
{
    public partial class frmRWImport : DevExpress.XtraEditors.XtraForm
    {
        public frmRWImport()
        {
            InitializeComponent();
        }

        private void sbtn_import_Click(object sender, EventArgs e)
        {
            try
            {
                BarcodeCreateImportModel bcim = new BarcodeCreateImportModel();
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    bcim.FileName = ofd.FileName.Substring(ofd.FileName.LastIndexOf("\\") + 1);
                    bcim.Bytes = System.IO.File.ReadAllBytes(ofd.FileName);
                    ModelAPI<BarcodeCreateImportModel> apiBCEM = new ModelAPI<BarcodeCreateImportModel>();
                    BarcodeCreateImportModel returnBCEM = apiBCEM.Insert(bcim);
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }

        }
    }
}