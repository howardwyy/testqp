using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChemTrend.Moblie.Controls;

namespace ChemTrend.Moblie.Forms.Base
{
    public partial class BaseForm : Form
    {
        public Label mTitle;
        public ucMenuBotton mMenuBotton;
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            mTitle = this.lbl_title;
            mMenuBotton = this.ucMB_menu;
        }

        private void ucBtn_back_Click(object sender, EventArgs e)
        {

        }
    }
}