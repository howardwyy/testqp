using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using BarcodeModel.MODEL.Barcode.RW;
using BarcodeModel.API;
using BarcodeModel.MODEL.Barcode.FG;
using BarcodeModel.MODEL;
using BarcodeModel.MODEL.Barcode;

namespace ChemTrend.Moblie.Data
{
    public class BarcodeInfo
    {
        public enum BarcodeType
        {
            RW = 1,//原材料、
            FG = 2,//成品、
            WO = 3,//工单号、
            RT = 4,//工序号、
            WH = 5,//仓库库位、
            PL = 6,//领料单、
            FB = 7,//成品装箱、
            RB = 8,//原材料装箱、
            SO = 9,//成品出库单(销售单)、
            WC = 10,//WorkCenter、
            ST = 11 //物料
        }

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
        /// </summary>
        /// <param name="RW"></param>
        /// <returns></returns>
        public static List<BaseSearchModel> GetBarcodes(string barcode)
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
                case "FG":
                    //成品
                    FGBarcodeModel searchFGModel = new FGBarcodeModel();
                    searchFGModel.ID = barcode;
                    ModelAPI<FGBarcodeModel> apiFGBarcodes = new ModelAPI<FGBarcodeModel>();
                    Barcodes = apiFGBarcodes.GetList(searchFGModel).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
                    break;
                case "RW":
                    //原材料
                    RWBarcodeModel searchRWModel = new RWBarcodeModel();
                    searchRWModel.ID = barcode;
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
                        ModelAPI<ReceiveDetailModel>  apiReceiveDetails = new ModelAPI<ReceiveDetailModel>();
                        ReceiveDetailModel searchReceiveDetail = new ReceiveDetailModel();
                        searchReceiveDetail.ReceiveID =barcode;// curReceiveModel.ID;
                        Barcodes = apiReceiveDetails.GetList(searchReceiveDetail).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
                   
                    break;
                case "RB":
                    //原材料装箱单 
                    PackingModel searchRBModel = new PackingModel();
                    ModelAPI<PackingModel> apiRBModel = new ModelAPI<PackingModel>();
                    Barcodes = apiRBModel.GetList(searchRBModel).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
                    if (Barcodes != null && Barcodes.Count>=1) {
                        RWBarcodeModel searchPRWModel = new RWBarcodeModel();
                        searchPRWModel.BoxID = barcode;
                        ModelAPI<RWBarcodeModel> apiPRWBarcodes = new ModelAPI<RWBarcodeModel>();
                        Barcodes = apiPRWBarcodes.GetList(searchPRWModel).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
                    }
                    break;
                case "FB":
                    //成品装箱单
                    FGPackageModel searchFBModel = new FGPackageModel();
                    ModelAPI<FGPackageModel> apiFBModel = new ModelAPI<FGPackageModel>();
                    Barcodes = apiFBModel.GetList(searchFBModel).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
                    if (Barcodes != null && Barcodes.Count >= 1)
                    {
                        FGBarcodeModel searchPFGModel = new FGBarcodeModel();
                        searchPFGModel.BoxID = barcode;
                        ModelAPI<FGBarcodeModel> apiPFGBarcodes = new ModelAPI<FGBarcodeModel>();
                        Barcodes = apiPFGBarcodes.GetList(searchPFGModel).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
                    }
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
