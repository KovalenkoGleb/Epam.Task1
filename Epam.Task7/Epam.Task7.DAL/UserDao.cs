using Epam.Task7.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.DAL.Interface;

namespace Epam.Task7.DAL
{
    public class UserDao : IUserDao
    {
        private static readonly Dictionary<int, User> repoUsers = new Dictionary<int, User>();

        public void Add(User user)
        {
            int lastId = repoUsers.Any()
                ? repoUsers.Keys.Max()
                : 0;
            user.Id = ++lastId;

            repoUsers.Add(user.Id, user);
        }

        public bool Delete(int id)
        {
            return repoUsers.Remove(id);
        }

        public User GetById(int id)
        {
            if(repoUsers.TryGetValue(id, out var user))
            {
                return user;
            }
            

            return null;
        }

        public IEnumerable<User> GetAll() 
        {
            return repoUsers.Values;
        }
    }
}
