using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BarcodeModel.MODEL;
using BarcodeModel.MODEL.User;
using BarcodeModel.ADO;
using System.Reflection;
using System.Data;
using System.Data.SqlClient;

namespace BarcodeAPI.Controllers
{
    public class BaseModelController : ApiController
    {
        private BaseSearchModel searchModel;
        private bool enableSearch = false;
        private string headmethod = "post";
        private string AccessToken = "";
        private string loginUserID = "";
        private string loginUserName = "";
        private string[] ids;//批量删除
        public override System.Threading.Tasks.Task<HttpResponseMessage> ExecuteAsync(System.Web.Http.Controllers.HttpControllerContext controllerContext, System.Threading.CancellationToken cancellationToken)
        {
            string modeltype = "", modelinbody = "";
            try
            {
                IEnumerable<string> mts = controllerContext.Request.Headers.GetValues("ModelType");
                IEnumerable<string> mlbs = controllerContext.Request.Headers.GetValues("ModelInBody");
                IEnumerable<string> mig = controllerContext.Request.Headers.GetValues("HeadMethod");
                IEnumerable<string> act = controllerContext.Request.Headers.GetValues("AccessToken");
                if (mts.Count() > 0)
                    modeltype = mts.First();
                if (mlbs.Count() > 0)
                    modelinbody = mlbs.First();
                if (mig.Count() > 0)
                    headmethod = mig.First();
                if (act.Count() > 0)
                    this.AccessToken = act.First();
                if (string.IsNullOrEmpty(this.AccessToken))
                {
                    if (!modeltype.Equals("BarcodeModel.MODEL.User.LoginModel"))
                    {
                        throw new Exception("无法访问，未登录系统");
                    }
                }
                else
                    this.GetLoginUser(this.AccessToken, modeltype);
                if (!string.IsNullOrEmpty(modeltype))
                {
                    Type t = BaseSearchModel.GetType(modeltype);
                    if (modelinbody == "true" && headmethod == "getids")//获取
                    {
                        ids = (string[])controllerContext.Request.Content.ReadAsAsync(typeof(string[])).Result;
                    }
                    else if (modelinbody == "true" && headmethod != "delete")//获取
                    {
                        enableSearch = true;
                        searchModel = (BaseSearchModel)controllerContext.Request.Content.ReadAsAsync(t).Result;
                    }
                    else if (modelinbody == "true" && headmethod == "delete")//批量删除
                    {
                        ids = (string[])controllerContext.Request.Content.ReadAsAsync(typeof(string[])).Result;
                    }
                    if (searchModel == null)
                    {
                        Assembly ass = Assembly.GetAssembly(t);
                        searchModel = (BaseSearchModel)ass.CreateInstance(t.FullName);
                    }

                    searchModel.LoginUserID = this.loginUserID;
                    searchModel.LoginUserName = this.loginUserName;

                }
            }
            catch (Exception ex)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("无效请求"),
                    ReasonPhrase = "无效请求"
                };
                throw new HttpResponseException(resp);
            }
            return base.ExecuteAsync(controllerContext, cancellationToken);
        }
        private void GetLoginUser(string accesstoken, string modeltype)
        {
            string sql = @"
select UR01001,UR01005 from UR01 where UR01001 in (select UR05002 from UR05 where UR05001=@act and UR05005=1)
";
            BaseAdo ba = new BaseAdo();
            DataSet ds = ba.GetDataSet(sql, new SqlParameter("@act", accesstoken));
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                this.loginUserID = ds.Tables[0].Rows[0][0] + "";
                this.loginUserName = ds.Tables[0].Rows[0][1] + "";
            }
            else
                throw new Exception("无法访问，未登录系统");
        }
        // GET api/basemodel
        public Object Get()
        {
            if (searchModel.Datatype == "excel")
            {
                return searchModel.GetExcel(enableSearch);
            }
            else
            {
                List<BaseSearchModel> lst = searchModel.GetALL(enableSearch);
                if (searchModel.totalCount > 0 && lst.Count > 0)
                {
                    lst[0].totalCount = searchModel.totalCount;
                }
                return lst;
            }
        }
        // GET api/basemodel/5
        public BaseSearchModel Get(string id)
        {
            return searchModel.GetModelByID(id);
        }

        // POST api/basemodel
        public Object Post()
        {
            if (this.headmethod == "get")
            {
                if (searchModel.Datatype == "excel")
                {
                    return searchModel.GetExcel(enableSearch);
                }
                else
                {
                    List<BaseSearchModel> lst = searchModel.GetALL(enableSearch);
                    if (searchModel.totalCount > 0 && lst.Count > 0)
                    {
                        lst[0].totalCount = searchModel.totalCount;
                    }
                    return lst;
                }
            }
            else if (this.headmethod == "getids")
            {
                return searchModel.GetModelList(ids);
            }
            else if (this.headmethod == "delete")
            {
                return searchModel.Delete(ids);
            }
            else
            {
                if (enableSearch)
                {
                    return searchModel.Insert();
                }
                else
                    throw new Exception("未检测到Model对象,无效POST请求");
            }
        }

        // PUT api/basemodel/5
        public void Put()
        {
            if (enableSearch)
            {
                searchModel.Update(searchModel);
            }
            else
                throw new Exception("未检测到Model对象,无效POST请求");
        }

        // DELETE api/basemodel/5
        public void Delete(string id)
        {
            searchModel.Delete(id);
        }
    }
}
