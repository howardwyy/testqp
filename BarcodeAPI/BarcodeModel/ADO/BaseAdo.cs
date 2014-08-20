using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Reflection;

namespace BarcodeModel.ADO
{
    public class BaseAdo
    {
        public string ConnectionStr { get; set; }
        public int PageSize { get; set; }
        private string _TableName = "";
        public string TableName { get { return _TableName; } set { _TableName = value; if (string.IsNullOrEmpty(this.ViewName)) this.ViewName = value; } }
        public string PrimaryKey { get; set; }
        public string ViewName { get; set; }

        public BaseAdo()
        {
            this.ConnectionStr = SysConfig.DBConnection;
            string pagesize = SysConfig.PageSize;
            int p = 10;
            if (!int.TryParse(pagesize, out p))
                p = 10;
            this.PageSize = p;
        }
        public DataSet GetDataSet(string sql, params SqlParameter[] param)
        {
            System.IO.File.AppendAllText("C:\\a.txt", sql);
            DataSet ds = ADOHelper.SqlHelper.ExecuteDataset(this.ConnectionStr, CommandType.Text, sql, param);
            return ds;
        }
        public int ExecuteSql(string sql, params SqlParameter[] param)
        {
            return ADOHelper.SqlHelper.ExecuteNonQuery(this.ConnectionStr, CommandType.Text, sql, param);
        }
        public DataSet GetDataSet(string where, string orderby, string columns = "*", params SqlParameter[] param)
        {
            if (where.Length > 0)
                where = "where " + where;
            if (orderby.Length > 0)
                orderby = "order by " + orderby;
            if (columns.Length == 0)
                columns = "*";
            string sql = "select {0} from {1} {2} {3}";
            sql = string.Format(sql, columns, this.ViewName, where, orderby);
            return this.GetDataSet(sql, param);
        }
        public DataSet GetDataSet(int pagenumber, string where, string orderby, out int totalCount, string columns = "*", params SqlParameter[] param)
        {
            totalCount = 0;
            int start = this.PageSize * (pagenumber - 1);
            string whereIn = "";
            if (where.Length > 0)
            {
                whereIn = "where " + where;
                where = "(" + where + ") and";
            }
            if (columns.Length == 0)
                columns = "*";

            if (orderby.Length == 0)
                orderby = this.PrimaryKey;
            else if (!orderby.Contains(this.PrimaryKey))
                orderby = orderby + "," + this.PrimaryKey;
            orderby = "order by " + orderby;
            string sql = @"select top {0} {1} from {2} where {3} {4} not in (select top {5} {4} from {2} {7} {6}) {6}";
            sql = string.Format(sql, this.PageSize, columns, this.ViewName, where, this.PrimaryKey, start, orderby, whereIn);

            string sqlCount = "select count({0}) from {1} {2}";
            sqlCount = string.Format(sqlCount, this.PrimaryKey, this.ViewName, whereIn);
            DataSet ds = this.GetDataSet(sqlCount, param);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
                int.TryParse(ds.Tables[0].Rows[0][0] + "", out totalCount);
            return this.GetDataSet(sql, param);
        }
        public DataSet GetDataByID(string id, string columns = "*")
        {
            if (columns.Length == 0)
                columns = "*";
            string sql = "select {0} from {1} where {2}=@id";
            sql = string.Format(sql, columns, this.ViewName, this.PrimaryKey);
            DataSet ds = this.GetDataSet(sql, new SqlParameter("@id", id));
            return ds;
        }
        public string GetNewID()
        {
            string sql = @"
declare @id varchar(20)
exec PROC_GETID @table,@id output
select @id ID
";
            DataSet ds = this.GetDataSet(sql, new SqlParameter("@table", this.TableName));
            if (ds != null && ds.Tables[0].Rows.Count > 0)
                return ds.Tables[0].Rows[0][0] + "";
            else
                return "";
        }
        /// <summary>
        /// 获取记录数
        /// </summary>
        /// <param name="where">where条件</param>
        /// <param name="param">sql参数</param>
        /// <returns></returns>
        public int GetRecordCount(string where = "", params SqlParameter[] param)
        {
            string count = this.GetScalar("count(1)", where, param);
            int result = 0;
            if (int.TryParse(count, out result))
                return result;
            else
                return 0;
        }
        /// <summary>
        /// 获取第一条的第一个结果
        /// </summary>
        /// <param name="column">要查询的字段</param>
        /// <param name="where">where条件</param>
        /// <param name="param">sql参数</param>
        /// <returns></returns>
        public string GetScalar(string column, string where = "", params SqlParameter[] param)
        {
            string sql = "select " + column + " from " + this.ViewName;
            if (where.Trim().Length > 0)
            {
                sql += " where " + where;
            }
            DataSet ds = this.GetDataSet(sql, param);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
                return ds.Tables[0].Rows[0][0] + "";
            else
                return "";
        }
    }
}