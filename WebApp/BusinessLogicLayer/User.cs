using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    /// <summary>
    /// 业务逻辑层
    /// </summary>
    public class User
    {
        public static bool add(Model.User user) {
            return DataAccess.User.add(user);
        }

        public static bool isUniqueUser(string username) {
            return DataAccess.User.isUniqueUser(username);
        }
    }
}
