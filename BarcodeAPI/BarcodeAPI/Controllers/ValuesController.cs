using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BarcodeModel.ADO;
using BarcodeModel.MODEL.User;

namespace BarcodeAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public List<UserModel> Get()
        {
            List<UserModel> model = this.Request.Content.ReadAsAsync<List<UserModel>>().Result;
            ModelAdo<UserModel> mUser = new ModelAdo<UserModel>();
            return mUser.GetList("", "", "");
        }

        // GET api/values/5
        public string Get(int id)
        {
            List<UserModel> model = this.Request.Content.ReadAsAsync<List<UserModel>>().Result;
            return "value";
        }

        // POST api/values
        public List<UserModel> Post()
        {
            List<UserModel> model = this.Request.Content.ReadAsAsync<List<UserModel>>().Result;
            HttpRequestMessage rm = this.Request;
            ModelAdo<UserModel> mUser = new ModelAdo<UserModel>();
            return mUser.GetList("", "", "");
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/values/5
        public void Delete(int id)
        {

        }
    }
}