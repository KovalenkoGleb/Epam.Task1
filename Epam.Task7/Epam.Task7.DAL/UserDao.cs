using Epam.Task7.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.DAL.Interface;
using System.IO;

namespace Epam.Task7.DAL
{
    public class UserDao : IUserDao
    {
        private static Dictionary<int, User> repoUsers = ReadStorage();

        private static Dictionary<int, User> ReadStorage()
        {
            Dictionary<int, User> tempRepo = new Dictionary<int, User>();
            using (StreamReader sr = new StreamReader("Storage.txt"))
            {
                while (!sr.EndOfStream)
                {
                    int sid = int.Parse(sr.ReadLine());
                    string sname = sr.ReadLine();
                    DateTime sbdate = DateTime.Parse(sr.ReadLine());

                    User tempuser = new User
                    {
                        Id = sid,
                        Name = sname,
                        DateOfBirth = sbdate,
                    };

                    tempRepo.Add(sid, tempuser);
                }
            }
            return tempRepo;
        }

        public void SaveStorage()
        {
            using (StreamWriter sw = new StreamWriter("Storage.txt"))
            {
                foreach (var user in repoUsers)
                {
                    sw.WriteLine($"{user.Value.Id}{Environment.NewLine}{user.Value.Name}{Environment.NewLine}{user.Value.DateOfBirth}");
                }
            }
        }

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
            if (repoUsers.TryGetValue(id, out var user))
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
