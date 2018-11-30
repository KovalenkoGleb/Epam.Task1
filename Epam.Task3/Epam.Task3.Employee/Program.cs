using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Employee
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string fname, sname, pname = null;
                DateTime bdate, edate;
                Console.WriteLine("Enter First Name: ");
                fname = Console.ReadLine();
                Console.WriteLine("Enter Second Name: ");
                sname = Console.ReadLine();
                Console.WriteLine("Enter Patronymic, if needed: ");
                pname = Console.ReadLine();
                Console.WriteLine("Enter Birth Date: ");
                bdate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employement Date: ");
                edate = DateTime.Parse(Console.ReadLine());

                Employee employee = new Employee(fname, sname, pname, bdate, edate);

                Console.WriteLine($"{Environment.NewLine}Employee Info{Environment.NewLine}Name: {employee.FirstName}{Environment.NewLine}Second Name {employee.SurName}{Environment.NewLine}" +
                    $"Patronymic: {employee.Patronymic}{Environment.NewLine}Birthday:{employee.BirthDay.Day}.{employee.BirthDay.Month}{Environment.NewLine}Age:{employee.Age}{Environment.NewLine}" +
                    $"Experience: {employee.WorkExperience}{Environment.NewLine}");

                Console.WriteLine("Enter new First Name: ");
                employee.FirstName = Console.ReadLine();
                Console.WriteLine("Enter new Second Name: ");
                employee.SurName = Console.ReadLine();
                Console.WriteLine("Enter new Patronymic, if needed:: ");
                employee.Patronymic = Console.ReadLine();
                Console.WriteLine("Enter new Birth Date: ");
                employee.BirthDay = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter new Employement Date: ");
                employee.EmployedDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine($"{Environment.NewLine}Employee Info{Environment.NewLine}Name: {employee.FirstName}{Environment.NewLine}Second Name {employee.SurName}{Environment.NewLine}" +
                    $"Patronymic: {employee.Patronymic}{Environment.NewLine}Birthday:{employee.BirthDay.Day}.{employee.BirthDay.Month}{Environment.NewLine}Age:{employee.Age}{Environment.NewLine}" +
                    $"Experience: {employee.WorkExperience}{Environment.NewLine}");
            }
            catch
            {
                Console.WriteLine("Incorrect input data");
            }
        }
    }
}