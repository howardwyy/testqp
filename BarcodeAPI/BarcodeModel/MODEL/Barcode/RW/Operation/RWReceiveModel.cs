using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.RW.Operation
{
    /// <summary>
    /// 原材料领料操作【扫描端】
    /// </summary>
    public class RWReceiveModel : BaseSearchModel
    {
        /// <summary>
        /// 领料单ID
        /// </summary>
        public string ReceiveId { get; set; }

        /// <summary>
        /// 原材料ID
        /// </summary>
        public string[] Barcodes { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        public string Remark { set; get; }

        public override BarcodeModel.MODEL.BaseSearchModel Insert()
        {
            if (Barcodes == null || Barcodes.Length == 0)
            {
                throw new Exception("请扫描或输入领料单对应的条码标签");
            }
            else if (string.IsNullOrEmpty(ReceiveId))
            {
                throw new Exception("请扫描或输入领料单的条码标签");
            }
            else
            {
                ModelAdo<ReceiveModel> adoReceive = new ModelAdo<ReceiveModel>();
                ReceiveModel receiveModel = adoReceive.GetModel(ReceiveId);
                if (receiveModel == null)
                {
                    throw new Exception("领料单不存在");
                }
                else
                {

                }
            }
            return base.Insert();
        }

    }
}
