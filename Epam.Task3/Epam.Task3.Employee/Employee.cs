using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Employee
{
    public class Employee : User
    {
        private DateTime emplDate;

        public Employee(string name, string sname, DateTime bdate, DateTime edate) : base(name, sname, bdate)
        {
            if (bdate.Year > 1900 && edate.Year > 1900 && edate < DateTime.Now)
            {
                this.emplDate = edate;
            }
            else
            {
                throw new Exception();
            }
        }

        public Employee(string name, string sname, string patro, DateTime bdate, DateTime edate) : base(name, sname, patro, bdate)
        {
            if (bdate.Year > 1900 && edate.Year > 1900 && edate < DateTime.Now)
            {
                this.emplDate = edate;
            }
            else
            {
                throw new Exception();
            }
        }

        public DateTime EmployedDate
        {
            get
            {
                return this.emplDate;
            }

            set
            {
                if (value.Year < 1900)
                {
                    throw new Exception("Year must be more than 1900");
                }

                this.emplDate = value;
            }
        }

        public int WorkExperience
        {
            get
            {
                return DateTime.Now.Year - this.emplDate.Year;
            }
        }
    }
}
