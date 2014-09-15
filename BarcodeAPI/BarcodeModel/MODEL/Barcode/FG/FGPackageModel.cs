using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.FG
{
    /// <summary>
    /// 成品装箱条码
    /// </summary>
    [Tablename(TableName = "FG07", PrimaryKey = "FG07001")]
    public class FGPackageModel : BaseSearchModel
    {
        //FG07001	varchar(30)	主键	主键
        [Columname(Name = "FG07001")]
        public string ID { get; set; }

        //FG07002	datetime		创建时间
        [Columname(Name = "FG07002")]
        public DateTime CreateTime { get; set; }

        //FG07003	varchar(50)		操作人id
        [Columname(Name = "FG07003")]
        public string UserId { get; set; }

        //FG07004	nvarchar(50)		操作人name
        [Columname(Name = "FG07004")]
        public string UserName { get; set; }
        //FG07005	int		类型(1一次性 2多次)
        [Columname(Name = "FG07005")]
        public int Type { get; set; }

        //FG07006	varchar(50)		stockcode(有代表只能装这个物料)
        [Columname(Name = "FG07006")]
        public string StockCode { get; set; }

        //FG07007	int		可以装多少个标签(0代表无穷 其他按数量)
        [Columname(Name = "FG07007")]
        public int Total { get; set; }

        //FG07008	int		状态(1.未使用；2.使用中；3，使用完)
        [Columname(Name = "FG07008")]
        public int Status { get; set; }


        //应用于查询，搜索功能，开始时间；
        public DateTime BeginTime { get; set; }
        //应用于查询，搜索功能，结束时间；
        public DateTime EndTime { get; set; }

        public int Count { get; set; }

        //应用于打印
        public FGPackageModel[] PackingModels { set; get; }

        public string[] ReturnID { get; set; }

        public override List<BaseSearchModel> GetALL(bool enableSearch = false)
        {
            ModelAdo<FGPackageModel> adoBill = new ModelAdo<FGPackageModel>();
            List<SqlParameter> listParam = new List<SqlParameter>();
            StringBuilder sbWhere = new StringBuilder();
            sbWhere.Append(" 1=1 ");
            if (!BeginTime.Equals(DateTime.MinValue) && !EndTime.Equals(DateTime.MinValue))
            {
                sbWhere.Append(" AND FG07002 BETWEEN  @BeginTime AND @EndTime ");
                listParam.Add(new SqlParameter("@BeginTime", BeginTime));
                listParam.Add(new SqlParameter("@EndTime", EndTime));

            }
            if (!string.IsNullOrEmpty(this.ID))
            {
                sbWhere.Append(" AND FG07001 = @ID");
                listParam.Add(new SqlParameter("@ID", ID));
            }
            if (Status >= 1)
            {
                sbWhere.Append(" AND FG07008 = @Status");
                listParam.Add(new SqlParameter("@Status", Status));
            }

            return adoBill.GetList(sbWhere.ToString(), " FG07002 DESC  ", "*", listParam.ToArray()).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);

        }

        public override BaseSearchModel Insert()
        {
            if (Count >= 1)
            {
                ModelAdo<FGPackageModel> modelAdo = new ModelAdo<FGPackageModel>();
                string[] strs = new string[Count];
                List<FGPackageModel> list = new List<FGPackageModel>();
                for (int i = 0; i < Count; i++)
                {
                    FGPackageModel pm = this.MemberwiseClone() as FGPackageModel;
                    pm.CreateTime = DateTime.Now;
                    pm.Status = 1;
                    strs[i] = pm.ID;
                    modelAdo.Insert(pm);

                    list.Add(pm);
                }
                this.PackingModels = list.ToArray();
                this.ReturnID = strs;
            }
            return this;


        }
    }
}
