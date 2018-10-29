using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using WebApplication3.EF;

namespace WebApplication3.Models
{
    public class admin_function : Base_Interface<administrator_Table>
    {
        personal_blogEntities3 db = new personal_blogEntities3();


        public administrator_Table Add(administrator_Table entity)
        {
            administrator_Table ad = new administrator_Table();
            ad.UserName = entity.UserName;
            ad.Password = entity.Password;
            ad.Name = entity.Name;
            ad.Image = entity.Image;
            ad.Phonenumber = entity.Phonenumber;
            ad.Email = entity.Email;
            db.administrator_Table.Add(ad);
            if (db.SaveChanges() > 0)
            {

                return entity;
            }
            return null;
        }

        public int Count(Expression<Func<administrator_Table, bool>> predicate)
        {
            return db.Set<administrator_Table>().Count(predicate);
        }

        public bool Delete(administrator_Table entity)
        {
            administrator_Table ad = db.administrator_Table.Find(entity.UserID);
            db.administrator_Table.Remove(ad);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool Exist(administrator_Table entity)
        {
            if (db.administrator_Table.Find(entity.UserID) != null)
                return true;
            else
                return false;
        }
        //p => p.CommentID == com.CommentID 这样使用参数 p为对象的形参 com.CommentID为查找的元素（建议查找int类型的ID）

        public administrator_Table Find(Expression<Func<administrator_Table, bool>> whereLambda)
        {
            administrator_Table _entity = db.Set<administrator_Table>().FirstOrDefault<administrator_Table>(whereLambda);
            return _entity;
        }

        public bool Update(administrator_Table entity)
        {
            administrator_Table ad = db.administrator_Table.Find(entity.UserID);
            ad.UserName = entity.UserName;
            ad.Password = entity.Password;
            ad.Name = entity.Name;
            ad.Image = entity.Image;
            ad.Phonenumber = entity.Phonenumber;
            ad.Email = entity.Email;
            db.Entry(ad).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
    }
}