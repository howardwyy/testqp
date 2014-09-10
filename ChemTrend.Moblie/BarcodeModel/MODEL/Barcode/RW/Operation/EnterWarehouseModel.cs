﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BarcodeModel.MODEL.Barcode.RW.Operation
{
    /// <summary>
    /// 入库
    /// </summary>
    public class EnterWarehouseModel : BaseSearchModel
    {
        public string Warehouse { get; set; }
        public string Bin { get; set; }
        public string Remark { get; set; }
        public string[] Barcodes { get; set; }

    }
}
