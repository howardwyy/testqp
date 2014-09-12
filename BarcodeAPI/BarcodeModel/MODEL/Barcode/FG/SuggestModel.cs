using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.FG
{
    /// <summary>
    /// 发货建议单
    /// </summary>
    public class SuggestModel: BaseSearchModel
    {
        public string SuggestID { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
    }
}
