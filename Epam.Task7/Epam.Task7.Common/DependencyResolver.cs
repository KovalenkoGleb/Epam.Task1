using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.Awards.BLL;
using Epam.Task7.Awards.BLL.Interface;
using Epam.Task7.DAL;
using Epam.Task7.DAL.Interface;
using Epam.Task7.DAL.Interfaces;
using Epam.Task7.Users.BLL;
using Epam.Task7.Users.BLL.Interface;

namespace Epam.Task7.Common
{
    public static class DependencyResolver
    {        
        private static IUserDao userDao;

        private static IUserLogic userLogic;

        private static IAwardDao awardDao;

        private static IAwardLogic awardLogic;

        public static IUserDao UserDao => userDao ?? (userDao = new UserDao());

        public static IAwardDao AwardDao => awardDao ?? (awardDao = new AwardDao());

        public static IAwardLogic AwardLogic => awardLogic ?? (awardLogic = new AwardLogic(AwardDao));

        public static IUserLogic UserLogic => userLogic ?? (userLogic = new UserLogic(UserDao));

        public static void SaveUserInfo()
        {
            UserDao.SaveUserStorage();
        }

        public static void SaveAwardInfo()
        {
            AwardDao.SaveAwardStorage();
        }

        public static void SaveAwardToUserInfo()
        {
            AwardDao.SaveAwardToUserStorage();
        }                  
    }
}
