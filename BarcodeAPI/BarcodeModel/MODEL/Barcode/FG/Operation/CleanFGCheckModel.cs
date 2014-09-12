using BarcodeModel.ADO;
using BarcodeModel.MODEL.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BarcodeModel.MODEL.Barcode.FG.Operation
{
    /// <summary>
    /// 重置盘点数据
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public class CleanFGCheckModel : BaseSearchModel
    {

        public override int Delete(string id)
        {
            ModelAdo<FGCheckModel> adoCheck = new ModelAdo<FGCheckModel>();
            string sql = @"delete  FG12";
            return adoCheck.ExecuteSql(sql, null);
        }


    }
}
