using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using WebApplication3.EF;

namespace WebApplication3.Models
{
    public class blog_function : Base_Interface<blog_Table>
    {
        personal_blogEntities3 db = new personal_blogEntities3();

        public blog_Table Add(blog_Table entity)
        {
            blog_Table blog = new blog_Table();
            blog.Title = entity.Title;
            blog.Synopsis = entity.Synopsis;
            blog.Content = entity.Content;
            blog.Image = entity.Image;
            blog.DateTime = entity.DateTime;
           
            blog.Star = entity.Star;
            blog.Module = entity.Module;
            blog.View_number = entity.View_number;
            blog.Like_number = entity.Like_number;
            blog.Comment_numbe = entity.Comment_numbe;
            db.blog_Table.Add(blog);
            if (db.SaveChanges() > 0)
            {
 
                return entity;
            }
            else
                return null;
        }

        public int Count(Expression<Func<blog_Table, bool>> predicate)
        {
            return db.Set<blog_Table>().Count(predicate);
        }

        public bool Delete(blog_Table entity)
        {
            blog_Table blog = db.blog_Table.Find(entity.BlogID);
            db.blog_Table.Remove(blog);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool Exist(blog_Table entity)
        {
            if (db.blog_Table.Find(entity.BlogID) != null)
                return true;
            else
                return false;
        }
        //p => p.CommentID == com.CommentID 这样使用参数 p为对象的形参 com.CommentID为查找的元素（建议查找int类型的ID）
        public blog_Table Find(Expression<Func<blog_Table, bool>> whereLambda)
        {
            blog_Table _entity = db.Set<blog_Table>().FirstOrDefault<blog_Table>(whereLambda);
            return _entity;
        }

        public bool Update(blog_Table entity)
        {
            blog_Table blog = db.blog_Table.Find(entity.BlogID);
            blog.Title = entity.Title;
            blog.Synopsis=entity.Synopsis;
            blog.Content = entity.Content;
            blog.Image = entity.Image;
            db.Entry(blog).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
    }
}