using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.FG.Operation
{
    /// <summary>
    /// 成品发货单，创建
    /// </summary>
    public class CreateInvoiceModel : BaseSearchModel
    {
        //SOLine数据集合
        public SOLineModel[] SOLines { set; get; }
        //OrderNumber
        public string SONO { set; get; }
        //期望收货日期
        public DateTime HopeTime { get; set; }
        //是否紧急
        public int isUrgent { get; set; }
        //备注
        public string Remark { get; set; }

    }
}
