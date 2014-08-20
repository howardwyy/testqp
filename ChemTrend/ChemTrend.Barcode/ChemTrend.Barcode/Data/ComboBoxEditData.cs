using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemTrend.Barcode.Data
{
    public class ComboBoxEditData
    {
        public string Text { set; get; }
        public string Value { set; get; }
        public override string ToString()
        {
            return Text;
        }
    }
}
