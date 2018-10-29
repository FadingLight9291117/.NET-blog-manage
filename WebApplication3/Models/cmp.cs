using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication3.Models
{
    public class cmp  //通用数据访问类
    {
        //定义链接字符串
        private static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        public  static SqlDataReader GetReader(string sql)   //查询数据库的方法
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);//第一个参数为sql语句，第二个为连接对象
            try
            {
                conn.Open();//打开连接
                return
                    cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }

    public class shiti //实体类
    {
        public string UserName { get;set; }

        public string Password { get; set; }

        public string Name { get; set; }
    }

    public class data_fw //数据访问类
    {
        public shiti AdminLogin(shiti sys)
        {
            string sql = "select Name from administrator_Table where UserName='{0}' and Password='{1}'";
            sql = string.Format(sql, sys.UserName, sys.Password);  //解析对象
      
            SqlDataReader objReader =cmp.GetReader(sql);  //读取sql语句，返回对象
            if ( objReader!= null)
            {

                if (objReader.Read())    //返回对象为true说明账号密码正确
                {
                    sys.Name = objReader["Name"].ToString();//对象里的属性封装进去
                }
            }

            else
            {
                sys = null;//清空对象
            }
            objReader.Close();//关闭连接
            return sys;

        }
    }
}