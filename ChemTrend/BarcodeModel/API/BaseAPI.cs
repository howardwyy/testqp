using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace BarcodeModel.API
{
    public class BaseAPI
    {
        public string Domain { get; set; }
        public static string AccessToken { get; set; }
        public List<KeyValuePair<string, string>> APIHeads { get; set; }
        public BaseAPI()
        {
            this.Domain = SysConfig.APIDomain;
            this.APIHeads = new List<KeyValuePair<string, string>>();
        }
        public bool TestConnect()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(this.Domain);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string html = "";
                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(stream);
                    html = sr.ReadToEnd();
                }
                return html.Trim() == "true";
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public string SendRequest(string url, string method, object model = null, params KeyValuePair<string, string>[] heads)
        {
            if (!this.TestConnect())
            {
                throw new Exception("无法连接到服务器，请检查网络连接");
            }
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(this.Domain + url);
            request.ContentType = "application/json";
            request.Method = method;
            request.Accept = "text/html,application/xhtml+xml,application/json;q=0.9,image/webp,*/*;q=0.8";
            string headmethod = "post";
            request.Headers.Add("AccessToken", BaseAPI.AccessToken);
            if (this.APIHeads != null && this.APIHeads.Count > 0)
            {
                foreach (KeyValuePair<string, string> item in this.APIHeads)
                {
                    request.Headers.Add(item.Key, item.Value);
                }
            }
            if (heads != null && heads.Length > 0)
            {
                foreach (KeyValuePair<string, string> item in heads)
                {
                    request.Headers.Add(item.Key, item.Value);
                }
            }
            if (model != null)
            {
                request.Headers.Add("ModelInBody", "true");
                if (method == "GET")
                {
                    request.Method = "POST";
                    headmethod = model is string[] ? "getids" : "get";
                    request.Headers.Add("HeadMethod", headmethod);
                }
                else if (method == "DELETE")
                {
                    request.Method = "POST";
                    headmethod = "delete";
                    request.Headers.Add("HeadMethod", headmethod);
                }
                else
                    request.Headers.Add("HeadMethod", headmethod);
                string param = BaseAPI.SerializeObject(model);
                byte[] data = Encoding.UTF8.GetBytes(param);
                request.ContentLength = data.Length;
                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(data, 0, data.Length);
                    requestStream.Close();
                }
            }
            else
            {
                request.Headers.Add("ModelInBody", "false");
                request.Headers.Add("HeadMethod", headmethod);
            }
            try
            {

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string html = "";
                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(stream);
                    html = sr.ReadToEnd();
                }
                return html;
            }
            catch (WebException ex)
            {
                string html = "";
                using (Stream stream = ex.Response.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(stream);
                    html = sr.ReadToEnd();
                }
                ApiExceptionMessage aem = BaseAPI.DeserializeObject<ApiExceptionMessage>(html);
                //throw new ApiException() { ApiExceptionMessage = aem };
                throw new Exception(aem.ExceptionMessage);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static P DeserializeObject<P>(string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<P>(json);
        }
        public static string SerializeObject(Object value)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(value);
        }
        public static Object DeserializeObject(string json, Type type)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject(json, type);
        }
    }
}
