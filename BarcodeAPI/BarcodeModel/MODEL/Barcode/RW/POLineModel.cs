using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeModel.ADO;
using System.Data.SqlClient;
using System.Data;

namespace BarcodeModel.MODEL.Barcode.RW
{
    [Tablename(TableName = "view_poline", PrimaryKey = "PC01001", ViewName = "view_poline", IsScalaDB = true)]
    public class POLineModel : BaseSearchModel
    {
        [Columname(Name = "PC01001")]
        public string PO { get; set; }

        [Columname(Name = "PC03002")]
        public string LineNum { get; set; }

        [Columname(Name = "SC01001")]
        public string StockCode { get; set; }

        [Columname(Name = "SC01002")]
        public string StockName { get; set; }

        [Columname(Name = "SC01003")]
        public string StockSpec { get; set; }

        [Columname(Name = "UNITPUR")]
        public string UNITPO { get; set; }

        [Columname(Name = "UNIT")]
        public string UNITWH { get; set; }

        [Columname(Name = "PL01001")]
        public string SupplierCode { get; set; }

        [Columname(Name = "PL01002")]
        public string SupplierName { get; set; }

        [Columname(Name = "PC03035")]
        public string Warehouse { get; set; }

        [Columname(Name = "Company")]
        public string Company { get; set; }

        [Columname(Name = "PC03010")]
        public decimal QTYPO { get; set; }

        [Columname(Name = "PC03011")]
        public decimal QTYRECEIVED { get; set; }

        [Columname(Name = "DH")]
        public decimal QTYRECEINING { get; set; }

        [Columname(Name = "UQTY")]
        public decimal UNITQTY { get; set; }

        public int BarcodeQTY { get; set; }

        public string Remark { get; set; }
        //供应商的batch [Columname(Name = "RW01035")]
        public string SupplierBatch { get; set; }

        //提示效果，返回值
        public string[] POS { get; set; }

        //返回条码信息应用于打印
        public RWBarcodeModel[] RWBarcodeModels { get; set; }

        //单据号头信息
        public BillModel billModel { set; get; }

        public override List<BaseSearchModel> GetALL(bool enableSearch = false)
        {
            List<BaseSearchModel> lst = base.GetALL(enableSearch);
            POLineModel[] lbs = new POLineModel[lst.Count];
            lst.ConvertAll<POLineModel>(m => m as POLineModel).CopyTo(lbs);
            lst.RemoveAll(m => true);
            foreach (POLineModel item in lbs)
            {
                if (item.UNITQTY <= 0)
                {
                    item.BarcodeQTY = 0;
                    lst.Add(item);
                }
                else
                {
                    int  p = (int)(item.QTYRECEINING / item.UNITQTY);
                    if (p * item.UNITQTY == item.QTYRECEINING)
                    {
                        item.BarcodeQTY = p;
                        lst.Add(item);
                    }
                    else
                    {
                        POLineModel clone = item.MemberwiseClone() as POLineModel;
                        clone.BarcodeQTY = p;
                        lst.Add(clone);
                        item.BarcodeQTY = 1;
                        item.UNITQTY = item.QTYRECEINING - p * item.UNITQTY;
                        lst.Add(item);
                    }
                }
            }
            return lst;
        }
        /// <summary>
        /// 通过录入数据，获取提示PO订单号码
        /// </summary>
        /// <returns></returns>
        public override BaseSearchModel GetModelByID(string id)
        {
            ModelAdo<POLineModel> modelAdo = new ModelAdo<POLineModel>();
            List<string> pos = new List<string>();
            string strSql = "select top  10  T.PC01001 as PO   from (select distinct(PC01001) from view_poline where  charindex(@tips,PC01001)>0) T";
            DataSet ds = modelAdo.GetDataSet(strSql, new SqlParameter("@tips", id));
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string[] rs = new string[ds.Tables[0].Rows.Count];
                for (int i = 0; i < rs.Length; i++)
                {
                    rs[i] = ds.Tables[0].Rows[i][0] + "";
                }
                this.POS = rs;
            }
            return this;
        }

        /*
        /// <summary>
        /// 创建条码信息
        /// 1：插入，父单据号表；
        /// 2：插入，子单据号明细表；
        /// 3：插入，原材料条码表；
        /// 4：插入，条码历史记录表；
        /// </summary>
        /// <returns></returns>
        public override BaseSearchModel Insert()
        {
            ModelAdo<RWBarcodeModel> adoBarcode = new ModelAdo<RWBarcodeModel>();
            ModelAdo<BillDetailModel> adoBillDetail = new ModelAdo<BillDetailModel>();
            ModelAdo<RWHistoryModel> adoBarcodeHistroy = new ModelAdo<RWHistoryModel>(); 



            List<RWBarcodeModel> listBarcode = new List<RWBarcodeModel>();
            for (int i = 0; i < BarcodeQTY; i++)
            {
                
                RWBarcodeModel barcodeModel = new RWBarcodeModel()
                {
                    Bill  = billModel.ID,
                    CompanyCode = this.Company,
                    StockUnit = this.UNITPO,
                    StockCode = this.StockCode,
                    StockName = this.StockName,
                    StockSpec = this.StockSpec,
                    StockUnitQty = this.UNITQTY,
                    SupplierCode = this.SupplierCode,
                    SupplierName = this.SupplierName,
                    Warehouse = this.Warehouse,
                    SO = this.PO,
                    Status = 1,
                    POLine = this.LineNum,
                    WarehouseInTime = DateTime.Now,
                    WarehouseOutTime = DateTime.Now,
                    Remark1 = Remark
                };
                adoBarcode.Insert(barcodeModel);

                listBarcode.Add(barcodeModel);

                BillDetailModel billDetailModel = new BillDetailModel()
                {
                    CreateTime = DateTime.Now,
                    BillID = billModel.ID,
                    BarcodeID = barcodeModel.ID,
                    Remark = billModel.Remark
                };
                adoBillDetail.Insert(billDetailModel);

                RWHistoryModel historyModel = new RWHistoryModel()
                {
                    CreateTime = DateTime.Now,
                    BillID = billModel.ID,
                    BarcodeID = barcodeModel.ID,
                    Remark = billModel.Remark
                };
                adoBarcodeHistroy.Insert(historyModel);          
 
                
                
            }
            this.RWBarcodeModels = listBarcode.ToArray();
            return this;
        }
         * */
        public override BarcodeModel.MODEL.BaseSearchModel Insert()
        {
            string sql = @"
declare @dj varchar(30)
declare @bid varchar(30)
declare @hid int
declare @i int
exec PROC_GETID 'RW03',@dj output
	
insert into RW03(RW03001,RW03002,RW03003,RW03004,RW03005,RW03006,RW03007,RW03008)
values(@dj,getdate(),@userid,@username,'','','',N'创建条码')

set @i=0
while @i<@printcount
begin
exec PROC_GETID 'RW01',@bid output
insert into RW02(RW02002,RW02003,RW02004,RW02005,RW02010,RW02011)
values(@bid,getdate(),@userid,@username,@dj,N'创建条码标签')

insert into RW01(RW01001,RW01002,RW01003,RW01004,RW01005,RW01006,RW01012,RW01013,RW01014,RW01015,RW01018,RW01024,RW01025,RW01027,RW01032,RW01034,RW01035)
values(@bid,@stock,@stockname,@stockspec,@unit,@qty,@sup,@supname,@po,@poline,@remark,@userid,@username,@dj,1,@company,@SupplierBatch)

insert into RW04(RW04002,RW04003,RW04004,RW04005) values(getdate(),@dj,@bid,N'创建条码')

set @i=@i+1
end
";
            BaseAdo ba = new BaseAdo();
            ba.ExecuteSql(sql, new SqlParameter("@userid", this.LoginUserID),
                new SqlParameter("@username", this.LoginUserName),
                new SqlParameter("@stock", this.StockCode),
                new SqlParameter("@stockname", this.StockName),
                new SqlParameter("@stockspec", this.StockSpec),
                new SqlParameter("@unit", this.UNITWH),
                new SqlParameter("@qty", this.UNITQTY),
                new SqlParameter("@po", this.PO),
                new SqlParameter("@poline", this.LineNum),
                new SqlParameter("@sup", this.SupplierCode),
                new SqlParameter("@supname", this.SupplierName),
                new SqlParameter("@remark", this.Remark),
                new SqlParameter("@company", this.Company),
                new SqlParameter("@SupplierBatch", this.SupplierBatch),
                new SqlParameter("@printcount", this.BarcodeQTY));
            return this;
        }
    }
}
