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
    public partial class ucTitle : UserControl
    {
        public ucTitle()
        {
            InitializeComponent();
        }

        public void initTitle(string title) {
            this.lbl_title.Text = title;
        }

        
    }
}
