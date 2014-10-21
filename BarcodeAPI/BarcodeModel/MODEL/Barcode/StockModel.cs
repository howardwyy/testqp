using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BarcodeModel.MODEL.Barcode
{
    /// <summary>
    /// 物料
    /// </summary>
    [Tablename(TableName = "view_Stock", PrimaryKey = "SC01001", ViewName = "view_Stock", IsScalaDB = true)]
    public class StockModel : BaseSearchModel
    {
        [Columname(Name = "SC01001")]
        public string StockCode { get; set; }

        [Columname(Name = "SC01002")]
        public string StockName { get; set; }

        [Columname(Name = "SC01003")]
        public string StockSpec { get; set; }

        [Columname(Name = "SC01035")]
        public string StockType { get; set; }

        [Columname(Name = "UQTY")]
        public decimal UQTY { get; set; }

        [Columname(Name = "UNIT")]
        public string Unit { get; set; }


        [Columname(Name = "SC01072")]
        public decimal PODivisor { get; set; }

        [Columname(Name = "SC01073")]
        public decimal SODivisor { get; set; }

        [Columname(Name = "Company")]
        public string Company { get; set; }
        //public override List<BaseSearchModel> GetALL(bool enableSearch = false)
        //{
        //    string where = "";
        //    List<SqlParameter> listParam = new List<SqlParameter>();
        //    if (!string.IsNullOrEmpty(this.StockCode))
        //    {
        //        where += "SC01001 like @search";
        //        listParam.Add(new SqlParameter("@search", "%" + this.StockCode + "%"));
        //    }
        //    int i = 0;
        //    return this.GetADO().GetList(1, where, "", out i, "", listParam.ToArray()).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
        //}
    }
}
