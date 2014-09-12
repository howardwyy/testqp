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
using DevExpress.XtraEditors.DXErrorProvider;

namespace ChemTrend.Barcode.Forms.FG
{
    public partial class frmFGStock : DevExpress.XtraEditors.XtraForm
    {
        public frmFGStock()
        {
            InitializeComponent();
        }
        private void frmFGStock_Load(object sender, EventArgs e)
        {
            InitValidationRules();
            InitData();
        }

        private void InitValidationRules()
        {
            ConditionValidationRule validationRule = new ConditionValidationRule();
            validationRule.ConditionOperator = ConditionOperator.IsBlank;
            validationRule.ErrorText = "请输入原材料！";
            dxvp_stock.SetValidationRule(this.te_stock, validationRule);
        }


        private void InitData()
        {
           

        }

        private void sbtn_query_Click(object sender, EventArgs e)
        {
            if (dxvp_stock.Validate()) { 
            
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void sbtn_create_Click(object sender, EventArgs e)
        {

        }

    }
}