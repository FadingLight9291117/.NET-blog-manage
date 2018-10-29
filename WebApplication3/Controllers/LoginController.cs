using WebApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebGrease;
using WebApplication3.EF;

namespace WebApplication3.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            //获取数据
            string id = Request.Params["login"];
            string pwd = Request.Params["pwd"];

            administrator_Table ad1 = new admin_function().Find(p=>p.UserName==id);
            administrator_Table ad2 = new admin_function().Find(p => p.Password == pwd);

            if (ad1 != null&& ad2!=null)
            {
                if (ad1.UserID == ad2.UserID)
                {
                    return RedirectToAction("Index", "BlogManage", "WebApplication3.Controllers");

                }
                else
                {
                    return View();
                }
            }
            else
            { return View(); }
        }
    }
}