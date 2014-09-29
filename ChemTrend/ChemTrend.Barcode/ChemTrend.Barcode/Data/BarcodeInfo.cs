using BarcodeModel.API;
using BarcodeModel.MODEL;
using BarcodeModel.MODEL.Barcode;
using BarcodeModel.MODEL.Barcode.FG;
using BarcodeModel.MODEL.Barcode.RW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChemTrend.Barcode.Data
{
    public class BarcodeInfo<T>
    {
        /// <summary>
        /// 通过条码获取
        /// 
        //RW = 1,//原材料、
        //FG = 2,//成品、
        //WO = 3,//工单号、
        //RT = 4,//工序号、
        //WH = 5,//仓库库位、
        //PL = 6,//领料单、
        //FB = 7,//成品装箱、
        //RB = 8,//原材料装箱、
        //SO = 9,//成品出库单(销售单)
        //WC = 10,//WorkCenter
        //ST = 11 //物料
        /// </summary>
        /// <param name="RW"></param>
        /// <returns></returns>
        public static List<BaseSearchModel> GetBarcode(string barcode)
        {
            //截取前两个字符  
            string Prefix = "";
            if (barcode.Length >= 2)
            {
                 Prefix = barcode.Substring(0, 2);

            }
            List<BaseSearchModel> Barcodes = new List<BaseSearchModel>();
            switch (Prefix)
            {
                case  "FG":
                    //成品
                    FGBarcodeModel searchFGModel = new FGBarcodeModel();
                    ModelAPI<FGBarcodeModel> apiFGBarcodes = new ModelAPI<FGBarcodeModel>();
                    Barcodes = apiFGBarcodes.GetList(searchFGModel).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
                    break;
                case "RW":
                    //原材料
                    RWBarcodeModel searchRWModel = new RWBarcodeModel();
                    ModelAPI<RWBarcodeModel> apiRWBarcodes = new ModelAPI<RWBarcodeModel>();
                    Barcodes = apiRWBarcodes.GetList(searchRWModel).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
                    break;
                case "WH":
                    //仓库库位
                    LocationModel searchWHModel = new LocationModel();
                    ModelAPI<LocationModel> apiWHModel = new ModelAPI<LocationModel>();
                    Barcodes = apiWHModel.GetList(searchWHModel).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
                    break;
                case "PL":
                    //领料单
                    ReceiveModel searchPLModel = new ReceiveModel();
                    ModelAPI<ReceiveModel> apiPLModel = new ModelAPI<ReceiveModel>();
                    Barcodes = apiPLModel.GetList(searchPLModel).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
                    break;
                case "RB":
                    //原材料装箱单
                    PackingModel searchRBModel = new PackingModel();
                    ModelAPI<PackingModel> apiRBModel = new ModelAPI<PackingModel>();
                    Barcodes = apiRBModel.GetList(searchRBModel).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
                    break;
                case "SO":
                    break;
                default:
                    break;
            }

            
         
            return Barcodes;
        }

    }
}
