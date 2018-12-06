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

        private string post;

        public Employee(string name, string sname, string post, DateTime bdate, DateTime edate) : base(name, sname, bdate)
        {
            if (edate.Year > 1900 && edate < DateTime.Now && this.TestName(post))
            {
                this.emplDate = edate;
                this.post = post;
            }
            else
            {
                throw new Exception();
            }
        }

        public Employee(string name, string sname, string patro, string post, DateTime bdate, DateTime edate) : base(name, sname, patro, bdate)
        {
            if (edate.Year > 1900 && edate < DateTime.Now && this.TestName(post))
            {
                this.emplDate = edate;
                this.post = post;
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

        public string Post
        {
            get
            {
                return this.post;
            }

            set
            {
                if (this.TestName(this.post))
                {
                    this.post = value;
                }
                else
                {
                    throw new Exception();
                }
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
