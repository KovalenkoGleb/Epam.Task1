using Epam.Task7.Common;
using Epam.Task7.Entities;
using Epam.Task7.Users.BLL;
using Epam.Task7.Users.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.ConsolePL
{
    class Program
    {
        private static void ShowUsers(IUserLogic userLogic)
        {
            Console.WriteLine("Id Name Age");
            foreach (var user in userLogic.GetAll())
            {
                Console.WriteLine(user);
            }
        }

        private static void AddUser(IUserLogic userLogic)
        {
            var user = new User
            {
                Name = "Gleb",
                DateOfBirth = DateTime.Parse("29.08.1995"),
            };

            userLogic.Add(user);
        }

        static void Main(string[] args)
        {

            var userLogic = DependencyResolver.UserLogic;

            AddUser(userLogic);
            ShowUsers(userLogic);
            AddUser(userLogic);
            AddUser(userLogic);
            AddUser(userLogic);
            ShowUsers(userLogic);
            userLogic.Delete(1);
            ShowUsers(userLogic);


        }


    }
}
