using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace BarcodeAPI.App_Start
{
    public class APIExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            context.Response = new HttpResponseMessage { StatusCode = System.Net.HttpStatusCode.InternalServerError, Content = new StringContent(context.Exception.Message) };
            //context.Response.Headers.Add("ExceptionMessage", context.Exception.Message);
            // context.Response.Headers.Add("ExceptionMessage", HttpUtility.UrlEncode(context.Exception.Message));
        }
    }
}