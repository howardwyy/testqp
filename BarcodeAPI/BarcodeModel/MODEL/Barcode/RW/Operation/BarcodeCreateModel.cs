﻿using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Transactions;
using System.Data;
using System.Data.SqlClient;

namespace BarcodeModel.MODEL.Barcode.RW.Operation
{
    public class BarcodeCreateModel : BaseSearchModel
    {
        private static Object lockobj = new object();
        public POLineModel[] POLineModels { get; set; }

        //订单明细操作说明
        public string BillRemark { get; set; }

        //应用于返回结果，处理打印功能
        //public RWBarcodeModel[] RWBarcodeModels { get; set; }
        public string[] ReturnIDS { get; set; }
        public override BarcodeModel.MODEL.BaseSearchModel Insert()
        {
            lock (lockobj)
            {
                try
                {
                    using (TransactionScope ts = new TransactionScope())
                    {
                        BaseAdo ba = new BaseAdo();
                        string sql = @"
declare @dj varchar(30)
exec PROC_GETID 'RW03',@dj output
insert into RW03(RW03001,RW03002,RW03003,RW03004,RW03005,RW03006,RW03007,RW03008)
values(@dj,getdate(),@userid,@username,'','','',N'创建条码')
select @dj t";
                        DataSet dsdj = ba.GetDataSet(sql, new SqlParameter("@userid", this.LoginUserID), new SqlParameter("@username", this.LoginUserName));
                        string dj = "";
                        if (dsdj != null && dsdj.Tables[0].Rows.Count > 0)
                            dj = dsdj.Tables[0].Rows[0][0] + "";
                        int count = 0;
                        foreach (POLineModel item in this.POLineModels)
                        {
                            item.LoginUserID = this.LoginUserID;
                            item.LoginUserName = this.LoginUserName;
                            item.Danju = dj;
                            item.Insert();
                            count += item.BarcodeQTY;
                        }
                        DataSet ds = ba.GetDataSet("select top " + count + " RW01001 from RW01 order by RW01001 desc");
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            string[] ids = new string[ds.Tables[0].Rows.Count];
                            for (int i = 0; i < ids.Length; i++)
                            {
                                ids[i] = ds.Tables[0].Rows[i][0] + "";
                            }
                            this.ReturnIDS = ids;
                        }
                        ts.Complete();
                        return this;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

    }
}