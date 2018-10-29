using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.EF;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class WriteBlogController : Controller
    {
        // GET: WriteBlog
        

        //[ValidateInput(false)]
        personal_blogEntities3 db = new personal_blogEntities3();
        
        public ActionResult Index()
        {
            //List<blog_Table> list = new List<blog_Table>();
            //blog_function c = new blog_function();
            return View();
            
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(blog_Table movie)
        {
            movie.DateTime = DateTime.Now;
            db.blog_Table.Add(movie);
            db.SaveChanges();
            return RedirectToAction("Index", "BlogManage");
                
        }
    }
}