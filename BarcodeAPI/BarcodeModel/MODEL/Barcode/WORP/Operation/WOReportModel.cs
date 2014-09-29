using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeModel.ADO;
using System.Data;
using System.Data.SqlClient;
using BarcodeModel.MODEL.Barcode.FG;
using BarcodeModel.MODEL.Barcode.RW;

namespace BarcodeModel.MODEL.Barcode.WORP.Operation
{
    public class WOReportModel : BaseSearchModel
    {
        public string Workorder { get; set; }
        public List<ReportModel> ReturnReportList { get; set; }
        public override BaseSearchModel Insert()
        {
            ModelAdo<WOModel> adoWO = new ModelAdo<WOModel>();
            WOModel modelWO = adoWO.GetModel("MP64001=@wo", "", new SqlParameter("@wo", this.Workorder));
            if (modelWO != null)
            {
                ModelAdo<ReportModel> adoReport = new ModelAdo<ReportModel>();
                List<ReportModel> list = adoReport.GetList("WK02002=@wo", "WK02001", "", new SqlParameter("@wo", this.Workorder));
                if (list.Count == 0)
                {
                    ModelAdo<WOLineModel> adoWOLine = new ModelAdo<WOLineModel>();
                    List<WOLineModel> wolineList = adoWOLine.GetList("MP65001=@wo", "MP65003", "", new SqlParameter("@wo", this.Workorder));
                    int i = 0;
                    string op = "";
                    foreach (WOLineModel item in wolineList)
                    {
                        if (op != item.OperationNO)
                            i = 0;
                        i++;
                        ReportModel modelReport = new ReportModel()
                        {
                            BOMOP = item.OperationNO,
                            BOMOPINDEX = i + "",
                            DeQTY = 0,
                            HadDe = 0,
                            HadDeQTY = 0,
                            StockCode = item.StockCode,
                            StockName = item.StockName,
                            Workorder = item.WO,
                            DeDate = System.DateTime.Now,
                        };
                        adoReport.Insert(modelReport);
                    }
                }
//                if (!string.IsNullOrEmpty(this.RWID))
//                {
//                    ModelAdo<RWBarcodeModel> adoRW = new ModelAdo<RWBarcodeModel>();
//                    RWBarcodeModel rwModel = adoRW.GetModelByID(this.RWID);
//                    if (rwModel != null)
//                    {
//                        if (this.DeQTY > (float)rwModel.StockUnitQty)
//                            throw new Exception("汇报数量超出条码数量");


//                        string sql = @"
//update RW01 set RW01006=RW01006-@deqty where RW01001=@bid
//
//insert into RW02(RW02002,RW02003,RW02004,RW02005,RW02010,RW02011)
//select RW01001,getdate(),@userid,@username,@dj,N'扣料 工单号'+@wo+' 数量'+convert(varchar(10),@deqty) from RW01 where RW01001=@bid
//
//update WK02 set WK02002=
//";
//                    }
//                    else
//                        throw new Exception("无效原材料条码");
//                }
                list = adoReport.GetList("WK02002=@wo", "WK02001", "", new SqlParameter("@wo", this.Workorder));
                this.ReturnReportList = list;
                return this;
            }
            else
                throw new Exception("无效工单,请重新确认工单");
        }
    }
}
