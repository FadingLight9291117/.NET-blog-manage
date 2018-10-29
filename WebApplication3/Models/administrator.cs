using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class administrator
    {
        //主键
        public int UserID { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "{1}到{0}个字符")]
        [Display(Name = "用户名")]
        public string UserName { get; set; }

/// <summary>
        /// 密码
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [Display(Name = "密码")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "{1}到{0}个字符")]
        [Display(Name = "昵称")]
        public string Name { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [Display(Name = "头像")]
        [DataType(DataType.ImageUrl)]
        public string Image { get; set; }


        /// <summary>
        /// 手机号
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [Display(Name = "手机号")]
        [DataType(DataType.PhoneNumber)]
        public string Phonenumber { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [Display(Name = "邮箱")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

  



    }
}