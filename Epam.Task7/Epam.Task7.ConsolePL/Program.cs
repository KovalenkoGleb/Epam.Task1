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

        private static void ShowUserById(IUserLogic userLogic)
        {
            Console.Write("Enter user ID: ");
            try
            {
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine(userLogic.GetById(id));
            }
            catch
            {
                Console.WriteLine($"ERROR. Wrong ID!{Environment.NewLine}");
            }
           
        }

        private static void AddUser(IUserLogic userLogic)
        {
            var user = new User
            {
                Name = "Gleb",
                DateOfBirth = DateTime.Parse("29.08.1995"),
            };

            Console.Write("Enter user name: ");
            user.Name = Console.ReadLine();
            Console.Write("Enter user BirthDay(DD/MM/YYYY)): ");
            try
            {
                user.DateOfBirth = DateTime.Parse(Console.ReadLine());
                userLogic.Add(user);
            }
            catch
            {
                Console.WriteLine($"ERROR. Wrong Date! User was not added.{Environment.NewLine}");
            }
        }

        private static void DeleteUser(IUserLogic userLogic)
        {
            Console.Write("Enter user ID: ");
            try
            {
                int id = int.Parse(Console.ReadLine());
                userLogic.Delete(id);
            }
            catch
            {
                Console.WriteLine($"ERROR. Wrong ID! User was not added.{Environment.NewLine}");
            }


        }

        private static char ReadKey(ref char inp_key)
        {
            inp_key = Console.ReadLine()[0];
            return inp_key = char.ToUpper(inp_key);
        }

        static void Main(string[] args)
        {

            var userLogic = DependencyResolver.UserLogic;

            Console.WriteLine($"Welcome to my Three-Layer Architecture programm 'Users'{Environment.NewLine}{Environment.NewLine}If you want to add user - enter A," +
                $"{Environment.NewLine}If you want to delete user - enter D,{Environment.NewLine}If you want to show all users - enter G,{Environment.NewLine}" +
                $"If you want to get user by ID - enter I{Environment.NewLine}To stop programm - enter S{Environment.NewLine}{Environment.NewLine}");

            char inp_key = '_';


            while (inp_key != 'S')
            {
                Console.WriteLine("Press A,D,G,I or S:");
                ReadKey(ref inp_key);
                switch (inp_key)
                {
                    case 'A':
                        {
                            AddUser(userLogic);
                            break;
                        }
                    case 'D':
                        {
                            DeleteUser(userLogic);
                            break;
                        }
                    case 'G':
                        {
                            ShowUsers(userLogic);
                            break;
                        }
                    case 'I':
                        {
                            ShowUserById(userLogic);
                            break;
                        }
                    case 'S':
                        {                           
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You have entered wrong input data. Try again.");
                        }
                        break;
                }
                Console.WriteLine();
                DependencyResolver.Save();
            }
            

        }


    }
}
