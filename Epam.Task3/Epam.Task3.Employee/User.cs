using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Employee
{
    public class User
    {
        private string fname;
        private string sname;
        private string pname;
        private DateTime bdate;              

        public User(string name, string sname, DateTime bdate)
        {
            if (bdate.Year > 1900 && bdate < DateTime.Now && this.TestName(name) && this.TestName(sname))
            {
                this.fname = name;
                this.sname = sname;
                this.pname = null;
                this.bdate = bdate;
            }
            else
            {
                throw new Exception();
            }
        }

        public User()
        {
        }

        public User(string name, string sname, string patro, DateTime bdate)
        {
            if (bdate.Year > 1900 && bdate < DateTime.Now && this.TestName(name) && this.TestName(sname) && this.TestName(patro))
            {
                this.fname = name;
                this.sname = sname;
                this.pname = patro;
                this.bdate = bdate;
            }
            else
            {
                throw new Exception();
            }
        }       

        public string FirstName
        {
            get
            {
                return this.fname;
            }

            set
            {
                this.fname = value;
            }
        }

        public string SurName
        {
            get
            {
                return this.sname;
            }

            set
            {
                this.sname = value;
            }
        }

        public string Patronymic
        {
            get
            {
                return this.pname;
            }

            set
            {
                this.pname = value;
            }
        }

        public DateTime BirthDay
        {
            get
            {
                return this.bdate;
            }

            set
            {
                if (value.Year < 1900)
                {
                    throw new Exception("Year must be more than 1900");
                }

                this.bdate = value;
            }
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - this.bdate.Year;
            }
        }

        protected bool TestName(string name)
        {
            if (name.Length < 1)
            {
                return false;
            }

            int separatorTest = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsSeparator(name[i]))
                {
                    separatorTest++;
                }
            }

            if (separatorTest == name.Length)
            {
                return false;
            }

            return true;
        }
    }
}