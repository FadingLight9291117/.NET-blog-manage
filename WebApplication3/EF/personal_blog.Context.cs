﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class personal_blogEntities3 : DbContext
    {
        public personal_blogEntities3()
            : base("name=personal_blogEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<administrator_Table> administrator_Table { get; set; }
        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<blog_Table> blog_Table { get; set; }
        public virtual DbSet<comment_Table> comment_Table { get; set; }
    }
}