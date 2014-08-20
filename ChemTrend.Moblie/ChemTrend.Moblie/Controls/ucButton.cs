using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ChemTrend.Moblie.Controls
{
    public partial class ucButton : UserControl
    {

        public ucButton()
        {
            InitializeComponent();
        }

        public void initString(string str)
        {
            this.lbl_str.Text = str;
        }

    }
}
