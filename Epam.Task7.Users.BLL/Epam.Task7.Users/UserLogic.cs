using Epam.Task7.DAL;
using Epam.Task7.DAL.Interface;
using Epam.Task7.Entities;
using Epam.Task7.Users.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.Users.BLL
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserDao userDao;

        public UserLogic (IUserDao inpUserDao)
        {
            userDao = inpUserDao;
        }

        public void Add(User user)
        {
            userDao.Add(user);
        }

        public void Delete(int id)
        {
            userDao.Delete(id);
        }

        public User GetById(int id)
        {
            return userDao.GetById(id);
        }

        public IEnumerable<User> GetAll()
        {
            return userDao.GetAll();
        }
    }
}
