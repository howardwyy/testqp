using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.FG.Operation
{
    /// <summary>
    /// 成品发货单，创建
    /// </summary>
    public class CreateInvoiceModel:BaseSearchModel
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

        public override BaseSearchModel Insert()
        {
            if (SOLines == null || SOLines.Length == 0)
                throw new Exception("请选择发货单项");
            string sql = @"
declare @id varchar(30)
exec PROC_GETID 'RW18',@id output
insert into RW18(RW18001,RW18002,RW18003,RW18004,RW18005,RW18006,RW18007,RW18008,RW18011,RW18012)
values(@id,getdate(),@userid,@username,@HopeTime,@isUrgent,@Remark,1,@CustomerCode,@CustomerName)
";
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@userid", this.LoginUserID));
            list.Add(new SqlParameter("@username", this.LoginUserName));
            list.Add(new SqlParameter("@HopeTime", this.HopeTime));
            list.Add(new SqlParameter("@isUrgent", this.isUrgent));
            list.Add(new SqlParameter("@Remark", this.Remark));
            list.Add(new SqlParameter("@CustomerCode", SOLines[0].CustomerCode));
            list.Add(new SqlParameter("@CustomerName", SOLines[0].CustomerName));
            StringBuilder sb = new StringBuilder();
            sb.Append(sql);

            int i = 10;
            foreach (SOLineModel item in this.SOLines)
            {
                sb.Append(string.Format(@"insert into FG09(FG09002,FG09003,FG09004,FG09005,FG09006,FG09007,FG09008,FG09009,FG09010,FG09011,FG09012)
values(@line{0},@id,getdate(),@userid,@username,@stock{0},@stockname{0},@orderqty{0},@unit{0},0,@orderqty{0})
", i));
                list.Add(new SqlParameter("@line" + i, item.LineNumber));
                list.Add(new SqlParameter("@stock" + i, item.StockCode));
                list.Add(new SqlParameter("@stockname" + i, item.StockName));
                list.Add(new SqlParameter("@orderqty" + i, item.OrderQty));
                list.Add(new SqlParameter("@unit" + i, item.Unit));
                i = i + 10;
            }
            sb.Append("select @id SONO");
            BaseAdo ba = new BaseAdo();
            DataSet ds = ba.GetDataSet(sb.ToString(), list.ToArray());
            if (ds != null && ds.Tables[0] != null && ds.Tables[0].Rows.Count >= 1)
                this.SONO = ds.Tables[0].Rows[0][0] + "";
            return this;
        }
    }
}
