using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BarcodeModel.ADO;
using BarcodeModel.API;
using BarcodeModel.MODEL;
using BarcodeModel.MODEL.User;

namespace BarcodeAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ModelAPI<RoleModel> apiUser = new ModelAPI<RoleModel>();
            ////apiUser.Insert(new RoleModel() { RoleName = "管理员", Remark = "这是一个管理员" });
            //try
            //{
            //    apiUser.GetModelByID("aaa");
            //}
            //catch (Exception ex)
            //{

            //}
            return View();
        }
    }
}
