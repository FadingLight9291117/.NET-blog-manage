using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.EF;

namespace WebApplication3.Controllers
{
    public class BlogManageController : Controller
    {
        [ValidateInput(false)]
        // GET: BlogManage
        public ActionResult Index(FormCollection fc)
        {
            var content = fc["content"];

            List<blog_Table> list = new List<blog_Table>();
            personal_blogEntities3 db = new personal_blogEntities3();
            var find = db.blog_Table;
            foreach (var read in find)
            {

                list.Add(new blog_Table()
                {
                    BlogID = read.BlogID,
                    Title = read.Title,
                    Synopsis = read.Synopsis,
                    Content = read.Content,
                    Image = read.Image,
                    DateTime = read.DateTime,
                    View_number = read.View_number,
                    Like_number = read.Like_number,
                    Comment_numbe = read.Comment_numbe,
                    Star = read.Star,
                    Module = read.Module
                });
            }
            list.Reverse();
            return View(list); 
        }
    }





}
