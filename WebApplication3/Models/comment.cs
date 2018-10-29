using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class comment
    {
        //主键
        public int CommentID { get; set; }

        //外键
        public int BlogID { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "{1}到{0}个字符")]
        [Display(Name = "昵称")]
        public string Name { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [Display(Name = "手机号")]
        [DataType(DataType.PhoneNumber)]
        public string Phonenumber { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [Display(Name = "内容")]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        /// <summary>
        /// 评论时间
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [Display(Name = "评论时间")]
        [DataType(DataType.DateTime)]
        public string DateTime { get; set; }
    }
}