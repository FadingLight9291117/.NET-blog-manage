using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class BlogManageController : Controller
    {
        [ValidateInput(false)]
        // GET: BlogManage
        public ActionResult Index(FormCollection fc)
        {
            var content = fc["content"];
            return View();
        }
    }
}