using BarcodeModel.ADO;
using BarcodeModel.MODEL.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BarcodeModel.MODEL.Barcode.RW.Operation
{
    public class CleanCheckModel : BaseSearchModel
    {
        /// <summary>
        /// 重置盘点数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override int Delete(string id)
        {
            ModelAdo<CheckModel> adoCheck = new ModelAdo<CheckModel>();
            string sql = @"delete  RW12";
            return adoCheck.ExecuteSql(sql, null);
        }


    }
}
