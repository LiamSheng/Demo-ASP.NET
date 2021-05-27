using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DataAccess
{
    /// <summary>
    /// 数据库访问层
    /// </summary>
    public class User
    {
        /// <summary>
        /// 向数据库中添加用户的方法
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool add(Model.User user)
        {
            string strSql = "INSERT INTO t_users (username,password,name,address,sex,mobile,email,socialNumber,state,date)"+
                            " VALUES ('" + user.Username + "','" + user.Password + "','" + user.Name + "','" + user.Address + "'," + user.Sex + 
                                    ",'" + user.Mobile + "','" + user.Email + "','" + user.SocialNumber + "'," + user.State + ",'" + user.Date + "')";
            if (Utility.MsSqlHelper.ExecuteSql(strSql) > 0)
                return true;
            else
                return false;
        }

        public static bool isUniqueUser(string username) {
            string strSqul = "SELECT * FROM t_users WHERE username='" + username + "'";
            DataTable dataTable = Utility.MsSqlHelper.Query(strSqul).Tables[0];
            if (dataTable.Rows.Count == 0)
                return true;
            else
                return false;
        }

        public static bool login(string username, string password) {
            string strSqul = "SELECT * FROM t_users WHERE username='" + username + "'AND password='" + password + "'";
            DataTable dataTable = Utility.MsSqlHelper.Query(strSqul).Tables[0];
            if (dataTable.Rows.Count == 0)
                return false;
            else
                return true;
        }
    }
}
