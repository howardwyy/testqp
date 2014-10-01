using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BarcodeModel.MODEL;

namespace BarcodeModel.API
{
    public class ModelAPI<T> : BaseAPI
    {
        public string ApiURL { get; set; }
        public ModelAPI()
            : base()
        {
            Type t = typeof(T);
            this.APIHeads.Add(new KeyValuePair<string, string>("ModelType", t.FullName));
            if (t.IsDefined(typeof(ApiURLAttribute), false))
            {
                Object[] objAttrs = t.GetCustomAttributes(typeof(ApiURLAttribute), false);
                ApiURLAttribute tn = objAttrs[0] as ApiURLAttribute;
                this.ApiURL = tn.URL;
            }
            else
            {
                this.ApiURL = "api/basemodel";
            }
        }
        public T GetModelByID(string ID)
        {
            string html = this.SendRequest(this.ApiURL + "/" + ID, "GET");
            return BaseAPI.DeserializeObject<T>(html);
        }
        public T GetModel(T searchModel)
        {
            List<T> lst = this.GetList(searchModel);
            if (lst.Count > 0)
                return lst[0];
            else
                return default(T);
        }
        public P GetModel<P>(T searchModel)
        {
            List<P> lst = this.GetList<List<P>>(searchModel);
            if (lst.Count > 0)
                return lst[0];
            else
                return default(P);
        }
        public List<T> GetList(T searchModel)
        {
            string html = this.SendRequest(this.ApiURL, "GET", searchModel);
            return BaseAPI.DeserializeObject<List<T>>(html);
        }
        public Byte[] GetExcel(T searchModel)
        {
            string html = this.SendRequest(this.ApiURL, "GET", searchModel);
            return BaseAPI.DeserializeObject<Byte[]>(html);
        }
        public List<T> GetList(string[] ids)
        {
            string html = this.SendRequest(this.ApiURL, "GET", ids);
            return BaseAPI.DeserializeObject<List<T>>(html);
        }
        public P GetList<P>(T searchModel)
        {
            string html = this.SendRequest(this.ApiURL, "GET", searchModel);
            return BaseAPI.DeserializeObject<P>(html);
        }
        public T Insert(T model)
        {
            string html = this.SendRequest(this.ApiURL, "POST", model);
            return BaseAPI.DeserializeObject<T>(html);
        }
        public P Insert<P>(T model)
        {
            string html = this.SendRequest(this.ApiURL, "POST", model);
            return BaseAPI.DeserializeObject<P>(html);
        }
        public T Update(T model)
        {
            string html = this.SendRequest(this.ApiURL, "PUT", model);
            return BaseAPI.DeserializeObject<T>(html);
        }
        public P Update<P>(T model)
        {
            string html = this.SendRequest(this.ApiURL, "PUT", model);
            return BaseAPI.DeserializeObject<P>(html);
        }
        public void Delete(string id)
        {
            this.SendRequest(this.ApiURL + "/" + id, "DELETE");
        }
        public void Delete(string[] ids)
        {
            this.SendRequest(this.ApiURL, "GET", ids);
        }
    }



    public class ModelAPI : BaseAPI
    {
        public string ApiURL { get; set; }
        private Type modelType;
        public ModelAPI(Type t)
            : base()
        {
            this.modelType = t;
            this.APIHeads.Add(new KeyValuePair<string, string>("ModelType", t.FullName));
            if (t.IsDefined(typeof(ApiURLAttribute), false))
            {
                Object[] objAttrs = t.GetCustomAttributes(typeof(ApiURLAttribute), false);
                ApiURLAttribute tn = objAttrs[0] as ApiURLAttribute;
                this.ApiURL = tn.URL;
            }
            else
            {
                this.ApiURL = "api/basemodel";
            }
        }
        public Object GetModelByID(string ID)
        {
            string html = this.SendRequest(this.ApiURL + "/" + ID, "GET");
            return BaseAPI.DeserializeObject(html, this.modelType);
        }
        public Object GetModel(Object searchModel)
        {
            List<Object> lst = this.GetList(searchModel);
            if (lst.Count > 0)
                return lst[0];
            else
                return null;
        }
        public List<Object> GetList(string[] ids)
        {
            string html = this.SendRequest(this.ApiURL, "GET", ids);
            return BaseAPI.DeserializeObject(html, typeof(List<Object>)) as List<Object>;
        }
        public List<Object> GetList(Object searchModel)
        {
            string html = this.SendRequest(this.ApiURL, "GET", searchModel);
            return BaseAPI.DeserializeObject(html, typeof(List<Object>)) as List<Object>;
        }
        public Object Insert(Object model)
        {
            string html = this.SendRequest(this.ApiURL, "POST", model);
            return BaseAPI.DeserializeObject(html, modelType);
        }
        public Object Update(Object model)
        {
            string html = this.SendRequest(this.ApiURL, "PUT", model);
            return BaseAPI.DeserializeObject(html, modelType);
        }
        public void Delete(string id)
        {
            this.SendRequest(this.ApiURL + "/" + id, "DELETE");
        }
    }
}
