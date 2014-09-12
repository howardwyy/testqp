using BarcodeModel.MODEL.Barcode.RW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.FG.Operation
{
    //创建成品条码
    public class CreateFGModel: BaseSearchModel
    {
        private static Object lockobj = new object();
        public WOModel[] WOModels { get; set; }

        //订单明细操作说明
        public string BillRemark { get; set; }

        //应用于返回结果，处理打印功能
        //public RWBarcodeModel[] RWBarcodeModels { get; set; }
        public string[] ReturnIDS { get; set; }
    }
}
