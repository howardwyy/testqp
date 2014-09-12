using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Collections;
using System.Text;

namespace BarcodeModel.ADO
{
    public class ModelAdo<T> : BaseAdo
    {
        private Hashtable ColumnMapping = new Hashtable();
        private bool PrimaryKeyIsStr = false;
        private string PrimaryMember = "";
        public ModelAdo()
            : base()
        {
            Type t = typeof(T);
            if (t.IsDefined(typeof(TablenameAttribute), false))
            {
                Object[] objAttrs = t.GetCustomAttributes(typeof(TablenameAttribute), false);
                TablenameAttribute tn = objAttrs[0] as TablenameAttribute;
                this.ViewName = tn.ViewName;
                this.TableName = tn.TableName;
                this.PrimaryKey = tn.PrimaryKey;
                if (tn.IsScalaDB)
                {
                    this.ConnectionStr = SysConfig.DBScalaConnection;
                    if (this.ViewName.Contains("{0}"))
                        this.ViewName = string.Format(this.ViewName, SysConfig.CompanyCode);
                    if (this.TableName.Contains("{0}"))
                        this.TableName = string.Format(this.TableName, SysConfig.CompanyCode);
                }
            }
            if (this.TableName.Length == 0 || this.PrimaryKey.Length == 0)
                throw new Exception("未给T设置类属性TablenameAttribute");
            else
            {
                PropertyInfo[] fis = t.GetProperties();
                foreach (PropertyInfo item in fis)
                {
                    if (item.IsDefined(typeof(ColumnameAttribute), false))
                    {
                        Object[] objAttrs = item.GetCustomAttributes(typeof(ColumnameAttribute), false);
                        ColumnameAttribute tn = objAttrs[0] as ColumnameAttribute;
                        ColumnMapping[item.Name] = tn.Name;
                        if (tn.Name == this.PrimaryKey)
                        {
                            this.PrimaryMember = item.Name;
                            if (item.PropertyType == typeof(string))
                            {
                                this.PrimaryKeyIsStr = true;
                            }
                        }
                    }
                }
                if (this.PrimaryMember.Length == 0)
                    throw new Exception("未在类上标记主键字段");
            }
        }
        public Hashtable GetColumnMapping()
        {
            return this.ColumnMapping;
        }
        public List<T> GetList(string sql, params SqlParameter[] param)
        {
            DataSet ds = this.GetDataSet(sql, param);
            if (ds != null)
            {
                return this.GetList(ds.Tables[0]);
            }
            return null;
        }
        public List<T> GetList(string where, string orderby, string columns = "*", params SqlParameter[] param)
        {
            DataSet ds = this.GetDataSet(where, orderby, columns, param);
            if (ds != null)
            {
                return this.GetList(ds.Tables[0]);
            }
            return null;
        }
        public List<T> GetList(int pagenumber, string where, string orderby, out int totalCount, string columns = "*", params SqlParameter[] param)
        {
            DataSet ds = this.GetDataSet(pagenumber, where, orderby, out totalCount, columns, param);
            if (ds != null)
            {
                return this.GetList(ds.Tables[0]);
            }
            return null;
        }
        public T GetModelByID(string id, string columns = "*")
        {
            DataSet ds = this.GetDataByID(id, columns);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
                return this.GetModelByDatarow(ds.Tables[0].Rows[0]);
            return default(T);
        }
        public List<T> GetModel(string[] ids)
        {
            if (ids.Length > 0)
            {
                StringBuilder sb = new StringBuilder();
                if (this.PrimaryKeyIsStr)
                {
                    foreach (string item in ids)
                    {
                        sb.Append(",'" + ids + "'");
                    }
                }
                else
                {
                    foreach (string item in ids)
                    {
                        sb.Append("," + ids);
                    }
                }
                sb.Remove(0, 1);
                string sql = this.PrimaryKey + " in (" + sb.ToString() + ")";
                return this.GetList(sql, "");
            }
            else
                return new List<T>();
        }
        private List<T> GetList(DataTable table)
        {
            if (table != null)
            {
                List<T> list = new List<T>();
                foreach (DataRow item in table.Rows)
                {
                    list.Add(this.GetModelByDatarow(item));
                }
                return list;
            }
            return null;
        }
        public T GetModel(string where, string columns = "*", params SqlParameter[] param)
        {
            DataSet ds = this.GetDataSet(where, "", "", param);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                return this.GetModelByDatarow(ds.Tables[0].Rows[0]);
            }
            return default(T);
        }
        public int Update(T obj)
        {
            if (obj != null)
            {
                Type t = typeof(T);
                PropertyInfo fi = t.GetProperty(this.PrimaryMember);
                string id = fi.GetValue(obj, null) + "";
                if (id.Length > 0)
                {
                    string sql = "update {0} set {1} where {2}=@" + this.PrimaryMember;
                    List<SqlParameter> listParam = new List<SqlParameter>();
                    StringBuilder sb = new StringBuilder("");
                    foreach (string item in this.ColumnMapping.Keys)
                    {
                        PropertyInfo f = t.GetProperty(item);
                        Object[] objAttrs = f.GetCustomAttributes(typeof(ColumnameAttribute), false);
                        ColumnameAttribute tn = objAttrs[0] as ColumnameAttribute;
                        if (tn.canUpdate || f.Name == this.PrimaryMember)
                        {
                            object value = this.GetValue(f, obj);
                            if (value == null && tn.DefaultValue != null)
                                value = tn.DefaultValue;
                            if (item != this.PrimaryMember)
                                sb.Append(string.Format(",{0}=@{1}", this.ColumnMapping[item], item));
                            listParam.Add(new SqlParameter("@" + item, value));
                        }
                    }
                    if (sb.Length > 0)
                        sb.Remove(0, 1);
                    sql = string.Format(sql, this.TableName, sb.ToString(), this.PrimaryKey);
                    return this.ExecuteSql(sql, listParam.ToArray());
                }
            }
            return 0;
        }
        public int Delete(string id)
        {
            string sql = "delete from {0} where {1}=@id";
            sql = string.Format(sql, this.TableName, this.PrimaryKey);
            return this.ExecuteSql(sql, new SqlParameter("@id", id));
        }
        public int Delete(string[] ids)
        {
            if (ids.Length > 0)
            {
                string idstr = "";
                foreach (string item in ids)
                {
                    if (this.PrimaryKeyIsStr)
                        idstr += ",'" + item + "'";
                    else
                        idstr += "," + item;
                }
                if (idstr.StartsWith(","))
                {
                    idstr = idstr.Substring(1, idstr.Length - 1);
                }
                string sql = "delete from {0} where {1} in ({2})";
                return this.ExecuteSql(string.Format(sql, this.TableName, this.PrimaryKeyIsStr, idstr));
            }
            return 0;
        }
        public int Insert(T obj)
        {
            if (obj != null)
            {
                Type t = typeof(T);
                PropertyInfo fi = t.GetProperty(this.PrimaryMember);
                string id = fi.GetValue(obj, null) + "";
                if (id.Length == 0 && this.PrimaryKeyIsStr)
                    id = this.GetNewID();
                StringBuilder columns = new StringBuilder();
                StringBuilder values = new StringBuilder();
                List<SqlParameter> listParam = new List<SqlParameter>();
                foreach (string item in this.ColumnMapping.Keys)
                {
                    if (item != this.PrimaryMember)
                    {
                        PropertyInfo f = t.GetProperty(item);
                        Object[] objAttrs = f.GetCustomAttributes(typeof(ColumnameAttribute), false);
                        ColumnameAttribute tn = objAttrs[0] as ColumnameAttribute;
                        if (tn.canInsert && f.Name != this.PrimaryMember)
                        {
                            object value = this.GetValue(f, obj);
                            if (value == null && tn.DefaultValue != null)
                                value = tn.DefaultValue;
                            columns.Append("," + this.ColumnMapping[item]);
                            values.Append(",@" + item);
                            listParam.Add(new SqlParameter("@" + item, value));
                        }
                    }
                }
                if (columns.Length > 0)
                {
                    columns.Remove(0, 1);
                    values.Remove(0, 1);
                }
                string sql = "insert into {0}({3}{1}) values({4}{2})";
                if (this.PrimaryKeyIsStr)
                {
                    sql = string.Format(sql, this.TableName, columns.ToString(), values.ToString(), this.PrimaryKey + ",", "@" + this.PrimaryMember + ",");
                    listParam.Add(new SqlParameter("@" + this.PrimaryMember, id));
                }
                else
                {
                    sql = string.Format(sql, this.TableName, columns.ToString(), values.ToString(), "", "");
                }
                int result = this.ExecuteSql(sql, listParam.ToArray());
                if (result > 0 && this.PrimaryKeyIsStr)
                    fi.SetValue(obj, id, null);
                return result;
            }
            return 0;
        }
        private void SetValue(PropertyInfo pInfo, object obj, object value)
        {
            if (obj != null && pInfo != null)
            {
                if (pInfo.PropertyType == typeof(bool))
                {
                    string boolv = value + "";
                    if (boolv.ToLower() == "false" || boolv == "0")
                        pInfo.SetValue(obj, false, null);
                    else
                        pInfo.SetValue(obj, true, null);
                }
                else
                    pInfo.SetValue(obj, value, null);
            }
        }
        private object GetValue(PropertyInfo pInfo, object obj)
        {
            if (obj != null && pInfo != null)
            {
                object value = pInfo.GetValue(obj, null);
                if (pInfo.PropertyType == typeof(bool))
                {
                    string v = value + "";
                    if (v.ToLower() == "false" || v == "0" || v.Length == 0)
                        return false;
                    else
                        return true;
                }
                else
                    return value;
            }
            else
                return null;
        }
        private T GetModelByDatarow(DataRow row)
        {
            if (row != null)
            {
                Type t = typeof(T);
                Assembly ass = Assembly.GetAssembly(t);
                T obj = (T)ass.CreateInstance(t.FullName);
                foreach (string item in ColumnMapping.Keys)
                {
                    PropertyInfo fi = t.GetProperty(item);
                    object value = row[ColumnMapping[item] + ""];
                    if (!Convert.IsDBNull(value))
                    {
                        this.SetValue(fi, obj, value);
                    }
                }
                return obj;
            }
            else
                return default(T);
        }
    }



    public class ModelAdo : BaseAdo
    {
        private Hashtable ColumnMapping = new Hashtable();
        public bool PrimaryKeyIsStr = false;
        private string PrimaryMember = "";
        private Type type;
        public ModelAdo(Type t)
            : base()
        {
            type = t;
            if (t.IsDefined(typeof(TablenameAttribute), false))
            {
                Object[] objAttrs = t.GetCustomAttributes(typeof(TablenameAttribute), false);
                TablenameAttribute tn = objAttrs[0] as TablenameAttribute;
                this.ViewName = tn.ViewName;
                this.TableName = tn.TableName;
                this.PrimaryKey = tn.PrimaryKey;
                if (tn.IsScalaDB)
                {
                    this.ConnectionStr = SysConfig.DBScalaConnection;
                    if (this.ViewName.Contains("{0}"))
                        this.ViewName = string.Format(this.ViewName, SysConfig.CompanyCode);
                    if (this.TableName.Contains("{0}"))
                        this.TableName = string.Format(this.TableName, SysConfig.CompanyCode);
                }
            }
            if (this.TableName.Length == 0 || this.PrimaryKey.Length == 0)
                throw new Exception("未给T设置类属性TablenameAttribute");
            else
            {
                PropertyInfo[] fis = t.GetProperties();
                foreach (PropertyInfo item in fis)
                {
                    if (item.IsDefined(typeof(ColumnameAttribute), false))
                    {
                        Object[] objAttrs = item.GetCustomAttributes(typeof(ColumnameAttribute), false);
                        ColumnameAttribute tn = objAttrs[0] as ColumnameAttribute;
                        ColumnMapping[item.Name] = tn.Name;
                        if (tn.Name == this.PrimaryKey)
                        {
                            this.PrimaryMember = item.Name;
                            if (item.PropertyType == typeof(string))
                            {
                                this.PrimaryKeyIsStr = true;
                            }
                        }
                    }
                }
                if (this.PrimaryMember.Length == 0)
                    throw new Exception("未在类上标记主键字段");
            }
        }
        public Hashtable GetColumnMapping()
        {
            return this.ColumnMapping;
        }
        public List<object> GetList(string sql, params SqlParameter[] param)
        {
            DataSet ds = this.GetDataSet(sql, param);
            if (ds != null)
            {
                return this.GetList(ds.Tables[0]);
            }
            return null;
        }
        public List<object> GetList(string where, string orderby, string columns = "*", params SqlParameter[] param)
        {
            DataSet ds = this.GetDataSet(where, orderby, columns, param);
            if (ds != null)
            {
                return this.GetList(ds.Tables[0]);
            }
            return null;
        }
        public List<object> GetList(int pagenumber, string where, string orderby, out int totalCount, string columns = "*", params SqlParameter[] param)
        {
            DataSet ds = this.GetDataSet(pagenumber, where, orderby, out totalCount, columns, param);
            if (ds != null)
            {
                return this.GetList(ds.Tables[0]);
            }
            return null;
        }

        public object GetModelByID(string id, string columns = "*")
        {
            DataSet ds = this.GetDataByID(id, columns);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
                return this.GetModelByDatarow(ds.Tables[0].Rows[0]);
            return null;
        }
        private List<object> GetList(DataTable table)
        {
            if (table != null)
            {
                List<object> list = new List<object>();
                foreach (DataRow item in table.Rows)
                {
                    list.Add(this.GetModelByDatarow(item));
                }
                return list;
            }
            return null;
        }
        public object GetModel(string where, string columns = "*", params SqlParameter[] param)
        {
            DataSet ds = this.GetDataSet(where, "", "", param);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                return this.GetModelByDatarow(ds.Tables[0].Rows[0]);
            }
            return null;
        }
        public List<Object> GetModel(string[] ids)
        {
            if (ids.Length > 0)
            {
                StringBuilder sb = new StringBuilder();
                if (this.PrimaryKeyIsStr)
                {
                    foreach (string item in ids)
                    {
                        sb.Append(",'" + ids + "'");
                    }
                }
                else
                {
                    foreach (string item in ids)
                    {
                        sb.Append("," + ids);
                    }
                }
                sb.Remove(0, 1);
                string sql = this.PrimaryKey + " in (" + sb.ToString() + ")";
                return this.GetList(sql, "");
            }
            else
                return new List<Object>();
        }
        public int Update(Object obj)
        {
            if (obj != null)
            {
                Type t = this.type;
                PropertyInfo fi = t.GetProperty(this.PrimaryMember);
                string id = fi.GetValue(obj, null) + "";
                if (id.Length > 0)
                {
                    string sql = "update {0} set {1} where {2}=@" + this.PrimaryMember;
                    List<SqlParameter> listParam = new List<SqlParameter>();
                    StringBuilder sb = new StringBuilder("");
                    foreach (string item in this.ColumnMapping.Keys)
                    {
                        PropertyInfo f = t.GetProperty(item);
                        Object[] objAttrs = f.GetCustomAttributes(typeof(ColumnameAttribute), false);
                        ColumnameAttribute tn = objAttrs[0] as ColumnameAttribute;
                        if (tn.canUpdate || f.Name == this.PrimaryMember)
                        {
                            object value = this.GetValue(f, obj);
                            if (value == null && tn.DefaultValue != null)
                                value = tn.DefaultValue;
                            if (item != this.PrimaryMember)
                                sb.Append(string.Format(",{0}=@{1}", this.ColumnMapping[item], item));
                            listParam.Add(new SqlParameter("@" + item, value));
                        }
                    }
                    if (sb.Length > 0)
                        sb.Remove(0, 1);
                    sql = string.Format(sql, this.TableName, sb.ToString(), this.PrimaryKey);
                    return this.ExecuteSql(sql, listParam.ToArray());
                }
            }
            return 0;
        }
        public int Delete(string id)
        {
            string sql = "delete from {0} where {1}=@id";
            sql = string.Format(sql, this.TableName, this.PrimaryKey);
            return this.ExecuteSql(sql, new SqlParameter("@id", id));
        }
        public int Delete(string[] ids)
        {
            if (ids.Length > 0)
            {
                string idstr = "";
                foreach (string item in ids)
                {
                    if (this.PrimaryKeyIsStr)
                        idstr += ",'" + item + "'";
                    else
                        idstr += "," + item;
                }
                if (idstr.StartsWith(","))
                {
                    idstr = idstr.Substring(1, idstr.Length - 1);
                }
                string sql = "delete from {0} where {1} in ({2})";
                return this.ExecuteSql(string.Format(sql, this.TableName, this.PrimaryKey, idstr));
            }
            return 0;
        }
        public int Insert(Object obj)
        {
            if (obj != null)
            {
                Type t = this.type;
                PropertyInfo fi = t.GetProperty(this.PrimaryMember);
                string id = fi.GetValue(obj, null) + "";
                if (id.Length == 0 && this.PrimaryKeyIsStr)
                    id = this.GetNewID();
                StringBuilder columns = new StringBuilder();
                StringBuilder values = new StringBuilder();
                List<SqlParameter> listParam = new List<SqlParameter>();
                foreach (string item in this.ColumnMapping.Keys)
                {
                    if (item != this.PrimaryMember)
                    {
                        PropertyInfo f = t.GetProperty(item);
                        Object[] objAttrs = f.GetCustomAttributes(typeof(ColumnameAttribute), false);
                        ColumnameAttribute tn = objAttrs[0] as ColumnameAttribute;
                        if (tn.canInsert && f.Name != this.PrimaryMember)
                        {
                            object value = this.GetValue(f, obj);
                            if (value != null)
                            {
                                columns.Append("," + this.ColumnMapping[item]);
                                values.Append(",@" + item);
                                listParam.Add(new SqlParameter("@" + item, value));
                            }
                        }
                    }
                }
                if (columns.Length > 0)
                {
                    columns.Remove(0, 1);
                    values.Remove(0, 1);
                }
                string sql = "insert into {0}({3}{1}) values({4}{2})";
                if (this.PrimaryKeyIsStr)
                {
                    sql = string.Format(sql, this.TableName, columns.ToString(), values.ToString(), this.PrimaryKey + ",", "@" + this.PrimaryMember + ",");
                    listParam.Add(new SqlParameter("@" + this.PrimaryMember, id));
                }
                else
                {
                    sql = string.Format(sql, this.TableName, columns.ToString(), values.ToString(), "", "");
                }
                int result = this.ExecuteSql(sql, listParam.ToArray());
                if (result > 0 && this.PrimaryKeyIsStr)
                    fi.SetValue(obj, id, null);
                return result;
            }
            return 0;
        }
        private void SetValue(PropertyInfo pInfo, object obj, object value)
        {
            if (obj != null && pInfo != null)
            {
                if (pInfo.PropertyType == typeof(bool))
                {
                    string boolv = value + "";
                    if (boolv.ToLower() == "false" || boolv == "0")
                        pInfo.SetValue(obj, false, null);
                    else
                        pInfo.SetValue(obj, true, null);
                }
                else
                    pInfo.SetValue(obj, value, null);
            }
        }
        private object GetValue(PropertyInfo pInfo, object obj)
        {
            if (obj != null && pInfo != null)
            {
                object value = pInfo.GetValue(obj, null);
                if (pInfo.PropertyType == typeof(bool))
                {
                    string v = value + "";
                    if (v.ToLower() == "false" || v == "0" || v.Length == 0)
                        return false;
                    else
                        return true;
                }
                else
                    return value;
            }
            else
                return null;
        }
        private object GetModelByDatarow(DataRow row)
        {
            if (row != null)
            {
                Type t = this.type;
                Assembly ass = Assembly.GetAssembly(t);
                Object obj = ass.CreateInstance(t.FullName);
                foreach (string item in ColumnMapping.Keys)
                {
                    PropertyInfo fi = t.GetProperty(item);
                    object value = row[ColumnMapping[item] + ""];
                    if (!Convert.IsDBNull(value))
                    {
                        this.SetValue(fi, obj, value);
                    }
                }
                return obj;
            }
            else
                return null;
        }

        /// <summary>
        /// 清空整张表数据
        /// </summary>
        /// <returns></returns>
        public int CleanTable()
        {
            string sql = "delete from {0}";
            sql = string.Format(sql, this.TableName);
            return this.ExecuteSql(sql);
        }
    }
}