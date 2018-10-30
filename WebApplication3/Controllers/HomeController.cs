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

        readonly personal_blogEntities3 db = new personal_blogEntities3();

        //主视图
        public ActionResult Index()
        {
            return View(BlogSortByModule(0));
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Study()
        {
            return View(BlogSortByModule(1));
        }

        public ActionResult Science()
        {
            return View(BlogSortByModule(2));
        }

        public ActionResult Read()
        {
            string url = Request.QueryString["id"];
            int id = int.Parse(url);
            personal_blogEntities3 db = new personal_blogEntities3();
            var data = from u in db.blog_Table where u.BlogID == id select u;
            foreach (var item in data)
            {
                ViewBag.Title1 = item.Title;
                ViewBag.Synopsis = item.Synopsis;
                ViewBag.Content = item.Content;
                ViewBag.DateTime = item.DateTime;
                ViewBag.View_number = item.View_number;
                ViewBag.Like_number = item.Like_number;
                if (item.Module == '1')
                {
                    ViewBag.Module = "学无止境";
                }
                else
                {
                    ViewBag.Module = "科学技术";
                }
            }
            return View();
        }

        //分布视图
        public ActionResult Slide()
        {
            List<blog_Table> list = new List<blog_Table>();
            int[] ID = new int[100];
            double[] star = new double[100];
            int sum = 0, flag = 0;
            personal_blogEntities3 db = new personal_blogEntities3();
            var find = db.blog_Table;
            foreach (var read in find)
            {
                ID[sum] = read.BlogID;
                star[sum++] = read.Star;
            }

            //冒泡排序 使用两个数组分别保存对象的ID和Star属性 对Star属性进行降序排序
            for (int i = 0; i < sum; i++)
            {
                for (int j = 0; j < sum - i - 1; j++)
                {
                    if (star[j] < star[j + 1])
                    {
                        int temp1; double temp2;
                        temp1 = ID[j]; ID[j] = ID[j + 1]; ID[j + 1] = temp1;
                        temp2 = star[j]; star[j] = star[j + 1]; star[j + 1] = temp2;
                        flag = 1;
                    }
                }
                //如果标志为0 说明数组已经是降序排列 提前结束排序
                if (flag == 0)
                    break;
            }
            for (int i = 0; i < sum; i++)
            {
                blog_Table blog = new blog_Table();
                int id = ID[i];
                blog = new blog_function().Find(p => p.BlogID == id);
                list.Add(blog);
            }
            return View(list);
        }

        public ActionResult Table()
        {
            return View(TableList());
        }

        public List<blog_Table> TableList()
        {
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
            return list;
        }

        //Table子分布视图
        public ActionResult Table_1()
        {

            return View();
        }

        public ActionResult Table_2()
        {
            List<blog_Table> list = new List<blog_Table>();
            int[] ID = new int[100];
            double[] star = new double[100];
            int sum = 0, flag = 0;
            personal_blogEntities3 db = new personal_blogEntities3();
            var find = db.blog_Table;
            foreach (var read in find)
            {
                ID[sum] = read.BlogID;
                star[sum++] = read.Star;
            }

            //冒泡排序 使用两个数组分别保存对象的ID和Star属性 对Star属性进行降序排序
            for (int i = 0; i < sum; i++)
            {
                for (int j = 0; j < sum - i - 1; j++)
                {
                    if (star[j] < star[j + 1])
                    {
                        int temp1; double temp2;
                        temp1 = ID[j]; ID[j] = ID[j + 1]; ID[j + 1] = temp1;
                        temp2 = star[j]; star[j] = star[j + 1]; star[j + 1] = temp2;
                        flag = 1;
                    }
                }
                //如果标志为0 说明数组已经是降序排列 提前结束排序
                if (flag == 0)
                    break;
            }
            for (int i = 0; i < sum; i++)
            {
                blog_Table blog = new blog_Table();
                int id = ID[i];
                blog = new blog_function().Find(p => p.BlogID == id);
                list.Add(blog);
            }
            return View(list);
        }



        public ActionResult Table_3()
        {

            return View();
        }



        public List<blog_Table> BlogSortByModule(int mod)
        {
            List<blog_Table> list = new List<blog_Table>();
            personal_blogEntities3 db = new personal_blogEntities3();
            var find = db.blog_Table;
            foreach (var read in find)
            {
                if (mod == 0)
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
                else if (read.Module == mod)
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