using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarcodeModel.API
{
    public class ApiURLAttribute : Attribute
    {
        public string URL { get; set; }
    }
}
