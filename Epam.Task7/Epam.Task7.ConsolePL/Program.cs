using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.Awards.BLL.Interface;
using Epam.Task7.Common;
using Epam.Task7.Entities;
using Epam.Task7.Users.BLL;
using Epam.Task7.Users.BLL.Interface;

namespace Epam.Task7.ConsolePL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var userLogic = DependencyResolver.UserLogic;
            var awardLogic = DependencyResolver.AwardLogic;

            Console.WriteLine($"Welcome to my Three-Layer Architecture programm 'Users'{Environment.NewLine}{Environment.NewLine}If you want to add user - enter AU," +
                $"{Environment.NewLine}If you want to delete user - enter DU,{Environment.NewLine}If you want to show all users - enter SU,{Environment.NewLine}" +
                $"If you want to get user by ID - enter GUI{Environment.NewLine}");

            Console.WriteLine($"If you want to add award - enter AA,{Environment.NewLine}If you want to delete award - enter DA,{Environment.NewLine}" +
                $"If you want to show all awards - enter SA,{Environment.NewLine}If you want to get award by ID - enter GAI{Environment.NewLine}" +
                $"If you want to add award to user - enter AAU, {Environment.NewLine}To stop programm - enter S{Environment.NewLine}{Environment.NewLine}");

            string inp_key = "default";

            while (inp_key != "S")
            {
                Console.WriteLine("Enter key: ");
                ReadKey(ref inp_key);
                switch (inp_key)
                {
                    case "AU":
                        {
                            AddUser(userLogic);
                            break;
                        }

                    case "DU":
                        {
                            DeleteUser(userLogic);
                            break;
                        }

                    case "SU":
                        {
                            ShowUsers(userLogic, awardLogic);
                            break;
                        }

                    case "GUI":
                        {
                            ShowUserById(userLogic);
                            break;
                        }

                    case "AA":
                        {
                            AddAward(awardLogic);
                            break;
                        }

                    case "DA":
                        {
                            DeleteAward(awardLogic);
                            break;
                        }

                    case "SA":
                        {
                            ShowAwards(awardLogic);
                            break;
                        }

                    case "GAI":
                        {
                            ShowAwardById(awardLogic);
                            break;
                        }

                    case "AAU":
                        {
                            AddAwardToUser(awardLogic);
                            break;
                        }

                    case "S":
                        {
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("You have entered wrong input data. Try again.");
                        }

                        break;
                }

                Console.WriteLine("____________");
                DependencyResolver.SaveUserInfo();
                DependencyResolver.SaveAwardInfo();
                DependencyResolver.SaveAwardToUserInfo();
            }
        }

        private static void ShowUsers(IUserLogic userLogic, IAwardLogic awardLogic)
        {
            Console.WriteLine("Id|Name|Age");
            foreach (var user in userLogic.GetAll())
            {
                Console.WriteLine(user);
                Console.Write($"User's awards:");
                Dictionary<int, List<int>> awardId_UsersIDs = awardLogic.GetDictOfAwardsAndUsers();
                foreach (var item in awardId_UsersIDs)
                {
                    if (item.Value.Contains(user.Id))
                    {
                        Console.Write(awardLogic.GetById(item.Key));
                    }
                }

                Console.WriteLine();
            }
        }

        private static void ShowAwards(IAwardLogic awardLogic)
        {
            Console.WriteLine("Id|Title");
            foreach (var award in awardLogic.GetAll())
            {
                Console.WriteLine(award);
            }
        }

        private static void ShowUserById(IUserLogic userLogic)
        {
            Console.Write("Enter award ID: ");
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

        private static void ShowAwardById(IAwardLogic awardLogic)
        {
            Console.Write("Enter award ID: ");
            try
            {
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine(awardLogic.GetById(id));
            }
            catch
            {
                Console.WriteLine($"ERROR. Wrong ID!{Environment.NewLine}");
            }
        }

        private static void AddUser(IUserLogic userLogic)
        {
            var user = new User();

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

        private static void AddAward(IAwardLogic awardLogic)
        {
            var award = new Award();

            Console.Write("Enter award title: ");
            award.Title = Console.ReadLine();
            awardLogic.Add(award);
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
                Console.WriteLine($"ERROR. Wrong ID! User was not deleted.{Environment.NewLine}");
            }
        }

        private static void DeleteAward(IAwardLogic awardLogic)
        {
            Console.Write("Enter award ID: ");
            try
            {
                int id = int.Parse(Console.ReadLine());
                awardLogic.Delete(id);
            }
            catch
            {
                Console.WriteLine($"ERROR. Wrong ID! Award was not deleted.{Environment.NewLine}");
            }
        }

        private static void AddAwardToUser(IAwardLogic awardLogic)
        {
            Console.Write("Enter award ID: ");
            int aid = int.Parse(Console.ReadLine());

            Console.Write("Enter user ID: ");
            int uid = int.Parse(Console.ReadLine());

            awardLogic.AddAwardToUser(aid, uid);
        }

        private static string ReadKey(ref string inp_key)
        {
            inp_key = Console.ReadLine().ToUpper();
            return inp_key;
        }
    }
}
