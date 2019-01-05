using Epam.Task7.Entities;
using Epam.Task7.Users.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.ConsolePL
{
    class Program
    {
        private static void ShowUsers(UserLogic userLogic)
        {
            Console.WriteLine("Id Name Age");
            foreach (var user in userLogic.GetAll())
            {
                Console.WriteLine(user);
            }
        }

        static void Main(string[] args)
        {
            var userLogic = new UserLogic();

            var user = new User
            {
                Name = "Gleb",
                DateOfBirth = DateTime.Parse("29.08.1995"),
            };

            userLogic.Add(user);
            ShowUsers(userLogic);
            
        }
    }
}
