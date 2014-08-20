using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeModel.ADO;
using System.Data;
using System.Data.SqlClient;

namespace BarcodeModel.MODEL.Barcode.RW.Operation
{
    public class PListCreateModel : BaseSearchModel
    {
        public WOLineModel[] WOLine { get; set; }
        public string PLNO { get; set; }
        //期望收货日期
        public DateTime HopeTime { get; set; }
        //是否紧急
        public int isUrgent { get; set; }
        //备注
        public string Remark { get; set; }

        public override BarcodeModel.MODEL.BaseSearchModel Insert()
        {
            if (WOLine == null || WOLine.Length == 0)
                throw new Exception("请选择领料单项");
            string sql = @"
declare @id varchar(30)
exec PROC_GETID 'RW08',@id output
insert into RW08(RW08001,RW08002,RW08003,RW08004,RW08005,RW08006,RW08007,RW08008)
values(@id,getdate(),@userid,@username,@HopeTime,@isUrgent,@Remark,1)
";
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@userid", this.LoginUserID));
            list.Add(new SqlParameter("@username", this.LoginUserName));
            list.Add(new SqlParameter("@HopeTime", this.HopeTime));
            list.Add(new SqlParameter("@isUrgent", this.isUrgent));
            list.Add(new SqlParameter("@Remark", this.Remark));
            StringBuilder sb = new StringBuilder();
            sb.Append(sql);

            int i = 10;
            foreach (WOLineModel item in this.WOLine)
            {
                sb.Append(string.Format(@"insert into RW09(RW09002,RW09003,RW09004,RW09005,RW09006,RW09007,RW09008,RW09009,RW09010,RW09011,RW09012)
values(@line{0},@id,getdate(),@userid,@username,@stock{0},@stockname{0},@planqty{0},@unit{0},0,@planqty{0})
", i));
                list.Add(new SqlParameter("@line"+i, item.Number));
                list.Add(new SqlParameter("@stock" + i, item.StockCode));
                list.Add(new SqlParameter("@stockname" + i, item.StockName));
                list.Add(new SqlParameter("@planqty" + i, item.PlanQTY));
                list.Add(new SqlParameter("@unit" + i, item.Unit));
                i = i + 10;
            }
            sb.Append("select @id PLNO");
            BaseAdo ba = new BaseAdo();
            DataSet ds = ba.GetDataSet(sb.ToString(), list.ToArray());
            if (ds != null && ds.Tables[0] != null && ds.Tables[0].Rows.Count>=1)
                this.PLNO = ds.Tables[0].Rows[0][0] + "";
            return this;
        }
    }
}
