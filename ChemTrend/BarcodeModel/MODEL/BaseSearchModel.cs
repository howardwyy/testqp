using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BarcodeModel.ADO;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace BarcodeModel.MODEL
{
    public class BaseSearchModel
    {
        public string SearchOrderBy { get; set; }
        public int PageIndex { get; set; }
        public int totalCount { get; set; }
        public int PageSize { get; set; }
        public string LoginUserName { get; set; }
        public string LoginUserID { get; set; }
        private string _datatype = "data";

        public string Datatype
        {
            get { return _datatype; }
            set { _datatype = value; }
        }
        protected List<KeyValuePair<string, string>> ExcelMapping { get; set; }
        public BaseSearchModel()
        {
            SearchOrderBy = "";
            PageIndex = -1;
        }
        private ModelAdo mado = null;
        private ModelAdo GetADO()
        {
            if (mado == null)
                mado = new ModelAdo(this.GetType());
            return mado;
        }
        private bool CheckHasValue(object value)
        {
            if (value != null)
            {
                Type t = value.GetType();
                switch (t.Name.ToLower())
                {
                    case "string": return value.ToString() != default(string);
                    case "int": return (int)value != default(int);
                    case "datetime": return (DateTime)value != default(DateTime);
                }
            }
            return false;
        }
        /// <summary>
        /// 根据model值获取MODEL列表
        /// </summary>
        /// <param name="enableSearch">是否使用model进行内置查询</param>
        /// <returns></returns>
        public virtual List<BaseSearchModel> GetALL(bool enableSearch = false)
        {
            this.totalCount = 0;
            if (enableSearch)
            {
                Hashtable colMapping = this.GetADO().GetColumnMapping();
                if (colMapping.Keys.Count > 0)
                {
                    string where = "";
                    List<SqlParameter> lstParams = new List<SqlParameter>();
                    Type t = this.GetType();
                    foreach (string item in colMapping.Keys)
                    {
                        string column = colMapping[item] + "";
                        string searchformat = string.Format("{0}=@{0}", column);
                        PropertyInfo pi = t.GetProperty(item);
                        if (pi != null)
                        {
                            object value = pi.GetValue(this, null);
                            if (this.CheckHasValue(value))
                            {
                                where += (where.Length > 0 ? " and " + searchformat : searchformat);
                                lstParams.Add(new SqlParameter("@" + column, value));

                            }
                        }
                    }
                    if (this.PageIndex <= 0)
                    {
                        ModelAdo ma = this.GetADO();
                        return ma.GetList(where, this.SearchOrderBy, "", lstParams.ToArray()).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
                    }
                    else
                    {
                        int tcount = 0;
                        ModelAdo ma = this.GetADO();
                        if (this.PageSize != default(int) && this.PageSize > 0)
                            ma.PageSize = this.PageSize;
                        else
                            ma.PageSize = int.Parse(SysConfig.PageSize);
                        List<BaseSearchModel> lst = ma.GetList(this.PageIndex, where, this.SearchOrderBy, out tcount, "", lstParams.ToArray()).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
                        this.totalCount = tcount;
                        return lst;
                    }
                }
            }
            return this.GetADO().GetList("", "").ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
        }
        public virtual BaseSearchModel GetModelByID(string id)
        {
            return this.GetADO().GetModelByID(id) as BaseSearchModel;
        }
        public virtual List<BaseSearchModel> GetModelList(string[] ids)
        {
            return this.GetADO().GetModel(ids).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
        }
        public virtual int Update(BaseSearchModel model)
        {
            return this.GetADO().Update(model);
        }
        public virtual int Delete(string id)
        {
            return this.GetADO().Delete(id);
        }
        public virtual int Delete(string[] ids)
        {
            ModelAdo ma = this.GetADO();
            return ma.Delete(ids);
        }
        public virtual BaseSearchModel Insert()
        {
            this.GetADO().Insert(this);
            return this;
        }

        public static Type GetType(string name)
        {
            return Type.GetType(name);
        }


        /// <summary>
        /// 清空表数据
        /// </summary>
        /// <returns></returns>
        public virtual int CleanTable()
        {
            return this.GetADO().CleanTable();
        }
    }
}
