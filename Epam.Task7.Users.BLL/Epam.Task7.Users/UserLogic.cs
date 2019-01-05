using Epam.Task7.DAL;
using Epam.Task7.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.Users.BLL
{
    public class UserLogic
    {
        private readonly UserDao UserDao = new UserDao();

        public void Add(User user)
        {
            UserDao.Add(user);
        }

        public void Delete(int id)
        {
            UserDao.Delete(id);
        }

        public User GetById(int id)
        {
            return UserDao.GetById(id);
        }

        public IEnumerable<User> GetAll()
        {
            return UserDao.GetAll();
        }
    }
}
