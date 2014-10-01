using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.RW.Operation
{
    /// <summary>
    /// 扫面条码核查是否可以进行领料操作【扫描端】
    /// </summary>
    public class CheckRWReceiveModel:BaseSearchModel
    {
        public string RecevieID { set; get; }
        public string Barcode { set; get; }
        public string ID { get; set; }
        public string StockCode { get; set; }
        public string LastUserName { get; set; }

        /// <summary>
        /// 依据扫描条码，是否能够进行
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override BaseSearchModel GetModelByID(string id)
        {

            if (RecevieID == null || RecevieID.Length == 0)
            {
                throw new Exception("请扫描或输入领料单的条码标签");
            }
            else {
                ModelAdo<RWBarcodeModel> adoRW = new ModelAdo<RWBarcodeModel>();
                RWBarcodeModel RWModel = adoRW.GetModelByID(Barcode, "*");
                if (RWModel == null)
                {
                    throw new Exception("领料条码标签不存在");
                }
                else 
                { 
                    //依据扫描原材料条码，获取对应的数据
                    
                }
            }

            return base.GetModelByID(id);
        }

    }
}
