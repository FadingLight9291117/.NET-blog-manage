using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using WebApplication3.EF;

namespace WebApplication3.Models
{
    public class comment_function : Base_Interface<comment_Table>
    {
        personal_blogEntities3 db = new personal_blogEntities3();

        public comment_Table Add(comment_Table entity)
        {
            comment_Table com = new comment_Table();
            com.BlogID = entity.BlogID;
            com.Content = entity.Content;
            com.DateTime = entity.DateTime;
            com.Name = entity.Name;
            com.Phonenumber = entity.Phonenumber;
            db.comment_Table.Add(com);
            if(db.SaveChanges()>0)
            {
                return entity;
            }
            return null;
        }

        public int Count(Expression<Func<comment_Table, bool>> predicate)
        {
            return db.Set<comment_Table>().Count(predicate);
        }

        public bool Delete(comment_Table entity)
        {
            comment_Table com = db.comment_Table.Find(entity.BlogID,entity.CommentID);
            db.comment_Table.Remove(com);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            else
                return false;

        }


        public bool Exist(comment_Table entity)
        {
            if (db.comment_Table.Find(entity.BlogID, entity.CommentID) != null)
                return true;
            else
                return false;
   
        }


        //p => p.CommentID == com.CommentID 这样使用参数 p为对象的形参 com.CommentID为查找的元素（建议查找int类型的ID）
        public comment_Table Find(Expression<Func<comment_Table, bool>> whereLambda)
        {
            comment_Table _entity = db.Set<comment_Table>().FirstOrDefault<comment_Table>(whereLambda);
            return _entity;
        }

 

        public bool Update(comment_Table entity)//根据主键查找
        {
            comment_Table com = db.comment_Table.Find(entity.BlogID,entity.CommentID);
            com.Content = entity.Content;
            db.Entry(com).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
    }
}