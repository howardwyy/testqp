using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BarcodeModel.MODEL.Barcode
{
    /// <summary>
    /// 仓库库位
    /// </summary>
    public class LocationModel : BaseSearchModel
    {
        public string Warehouse { get; set; }
        public string Location { get; set; }
        public string LocationName { get; set; }
        public string Company { get; set; }
    }
}
