using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using WebApplication3.EF;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<comment> list = new List<comment>();
            comment_function c = new comment_function();
            comment_Table com = new comment_Table()
            {
                CommentID = 1,
                BlogID = 1,
                Name = "asdasd",
                Phonenumber = "12312312312",
                Content = "asdasdasd",
                DateTime = DateTime.Now
            };
            // list.Add(com);
            ViewBag.kp = new comment_function().Add(com);

            return View();

        }


        public List<blog_Table>  BlogSortByModule(int mod)
        {
            List<blog_Table> list = new List<blog_Table>();
            personal_blogEntities3 db = new personal_blogEntities3();
            var find = db.blog_Table;
            foreach (var read in find)
            {
                if (read.Module == mod)
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
            }
            list.Reverse();
            return list;
        }

    }
}