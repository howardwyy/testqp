using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarcodeModel.ADO
{
    class TablenameAttribute : Attribute
    {
        public string TableName { get; set; }
        public string ViewName { get; set; }
        public string PrimaryKey { get; set; }
        public bool IsScalaDB { get; set; }
        public TablenameAttribute()
        {
            this.IsScalaDB = false;
        }
    }
    class ColumnameAttribute : Attribute
    {
        public ColumnameAttribute()
        {
            this.canUpdate = true;
            this.canInsert = true;
        }
        public string Name { get; set; }
        public object DefaultValue { get; set; }
        public bool canUpdate { get; set; }
        public bool canInsert { get; set; }
    }
}
