using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
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
        public BaseSearchModel()
        {
            SearchOrderBy = "";
            PageIndex = -1;
        }
    }
}
