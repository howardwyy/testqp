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
    public partial class BaseTForm : Form
    {

        public ucButton ucBack;
        public Label mTitle;
        public ucButton ucAction;
        public BaseTForm()
        {
            InitializeComponent();
        }

        private void BaseTForm_Load(object sender, EventArgs e)
        {
            ucBack = this.ucBtn_back;
            ucAction = this.ucBtn_Action;
            mTitle = this.lbl_title;

        }

        private void ucBtn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}