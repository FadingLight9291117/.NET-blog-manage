//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class comment_Table
    {
        public int CommentID { get; set; }
        public int BlogID { get; set; }
        public string Name { get; set; }
        public string Phonenumber { get; set; }
        public string Content { get; set; }
        public System.DateTime DateTime { get; set; }
    }
}