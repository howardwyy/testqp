using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.RW
{
    [Tablename(TableName = "RW07", PrimaryKey = "RW07001")]
    public class PackingModel : BaseSearchModel
    {
        //RW07001	varchar(30)	主键	主键
        [Columname(Name = "RW07001")]
        public string ID { get; set; }

        //RW07002	datetime		创建时间
        [Columname(Name = "RW07002")]
        public DateTime CreateTime { get; set; }

        //RW07003	varchar(50)		操作人id
        [Columname(Name = "RW07003")]
        public string UserId { get; set; }

        //RW07004	nvarchar(50)		操作人name
        [Columname(Name = "RW07004")]
        public string UserName { get; set; }

        //RW07005	int		类型(1一次性 2多次)
        [Columname(Name = "RW07005")]
        public int Type { get; set; }

        //RW07006	varchar(50)		stockcode(有代表只能装这个物料)
        [Columname(Name = "RW07006")]
        public string StockCode { get; set; }

        //RW07007	int		可以装多少个标签(0代表无穷 其他按数量)
        [Columname(Name = "RW07007")]
        public int Total { get; set; }

        //RW07008	int		状态(1.未使用；2.使用中；3，使用完)
        [Columname(Name = "RW07008")]
        public int Status { get; set; }


        //应用于查询，搜索功能，开始时间；
        public DateTime BeginTime { get; set; }
        //应用于查询，搜索功能，结束时间；
        public DateTime EndTime { get; set; }

        public int Count { get; set; }

        //应用于打印
        public PackingModel[] PackingModels{set;get;}

        public string[] ReturnID { get; set; }

        public override List<BaseSearchModel> GetALL(bool enableSearch = false)
        {
            ModelAdo<PackingModel> adoBill = new ModelAdo<PackingModel>();
            List<SqlParameter> listParam = new List<SqlParameter>();
            StringBuilder sbWhere = new StringBuilder();
            sbWhere.Append(" 1=1 ");
            if (!BeginTime.Equals(DateTime.MinValue) && !EndTime.Equals(DateTime.MinValue))
            {
                sbWhere.Append(" AND RW07002 BETWEEN  @BeginTime AND @EndTime ");
                listParam.Add(new SqlParameter("@BeginTime", BeginTime));
                listParam.Add(new SqlParameter("@EndTime", EndTime));

            }
            if (!string.IsNullOrEmpty(this.ID))
            {
                sbWhere.Append(" AND RW07001 = @ID");
                listParam.Add(new SqlParameter("@ID", ID));
            }
            if (Status >= 1) {
                sbWhere.Append(" AND RW07008 = @Status");
                listParam.Add(new SqlParameter("@Status", Status));
            }

            return adoBill.GetList(sbWhere.ToString(), " RW07002 DESC  ", "*", listParam.ToArray()).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
            
        }

        public override BaseSearchModel Insert()
        {
            if (Count >= 1)
            {
                ModelAdo<PackingModel> modelAdo = new ModelAdo<PackingModel>();
                string[] strs = new string[Count];
                List<PackingModel> list = new List<PackingModel>();
                for (int i = 0; i < Count; i++)
                {
                    PackingModel pm = this.MemberwiseClone() as PackingModel;
                    pm.CreateTime = DateTime.Now;
                    pm.Status = 1;
                    strs[i] = pm.ID;
                    modelAdo.Insert(pm);

                    list.Add(pm);
                }
                this.PackingModels = list.ToArray() ;
                this.ReturnID = strs;
            }
            return this;


        }
    }
}
