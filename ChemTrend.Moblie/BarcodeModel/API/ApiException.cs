using System;
using System.Collections.Generic;
using System.Text;

namespace BarcodeModel.API
{
    public class ApiExceptionMessage
    {
        public string ExceptionMessage { get; set; }
        public string Message { get; set; }
        public string ExceptionType { get; set; }
        public string StackTrace { get; set; }
        public string ErrCode { get; set; }
        public ApiExceptionMessage()
        {
            this.ErrCode = "100";
        }
    }
    public class ApiException : Exception
    {
        public ApiExceptionMessage ApiExceptionMessage { get; set; }
    }
}
