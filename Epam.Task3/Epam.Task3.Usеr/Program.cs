using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.User
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string fname, sname, pname = null;
                DateTime bdate;
                Console.WriteLine("Enter First Name: ");
                fname = Console.ReadLine();
                Console.WriteLine("Enter Second Name: ");
                sname = Console.ReadLine();
                Console.WriteLine("Enter Patronymic, if needed: ");
                pname = Console.ReadLine();
                Console.WriteLine("Enter Birth Date: ");
                bdate = DateTime.Parse(Console.ReadLine());

                User user = new User(fname, sname, pname, bdate);
                Console.WriteLine($"{Environment.NewLine}User Info{Environment.NewLine}Name: {user.FirstName}{Environment.NewLine}Second Name {user.SurName}{Environment.NewLine}" +
                    $"Patronymic: {user.Patronymic}{Environment.NewLine}Birthday:{user.BirthDay.Day}.{user.BirthDay.Month}{Environment.NewLine}Age:{user.Age}{Environment.NewLine}");

                Console.WriteLine("Enter new First Name: ");
                user.FirstName = Console.ReadLine();
                Console.WriteLine("Enter new Second Name: ");
                user.SurName = Console.ReadLine();
                Console.WriteLine("Enter new Patronymic, if needed:: ");
                user.Patronymic = Console.ReadLine();
                Console.WriteLine("Enter new Birth Date: ");
                user.BirthDay = DateTime.Parse(Console.ReadLine());

                Console.WriteLine($"{Environment.NewLine}User Info{Environment.NewLine}Name: {user.FirstName}{Environment.NewLine}Second Name {user.SurName}{Environment.NewLine}" +
                     $"Patronymic: {user.Patronymic}{Environment.NewLine}Birthday:{user.BirthDay.Day}.{user.BirthDay.Month}{Environment.NewLine}Age:{user.Age}{Environment.NewLine}");
            }
            catch
            {
                Console.WriteLine("Incorrect input data");
            }
        }
    }
}
