using Epam.Task7.DAL;
using Epam.Task7.DAL.Interface;
using Epam.Task7.Users.BLL;
using Epam.Task7.Users.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.Common
{
    public static class DependencyResolver
    {
        private static IUserDao userDao;

        public static IUserDao UserDao => userDao ?? (userDao = new UserDao());

        private static IUserLogic userLogic;

        public static IUserLogic UserLogic => userLogic ?? (userLogic = new UserLogic(UserDao));

        public static void Save()
        {
            UserDao.SaveStorage();
        }
    }
}
