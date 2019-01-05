using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.DAL;
using Epam.Task7.DAL.Interface;
using Epam.Task7.Entities;
using Epam.Task7.Users.BLL.Interface;

namespace Epam.Task7.Users.BLL
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserDao userDao;

        public UserLogic(IUserDao inpUserDao)
        {
            this.userDao = inpUserDao;
        }

        public void Add(User user)
        {
            this.userDao.Add(user);
        }

        public void Delete(int id)
        {
            this.userDao.Delete(id);
        }

        public User GetById(int id)
        {
            return this.userDao.GetById(id);
        }

        public IEnumerable<User> GetAll()
        {
            return this.userDao.GetAll();
        }
    }
}
