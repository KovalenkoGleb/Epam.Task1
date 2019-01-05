using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                return (DateTime.Now.Year - DateOfBirth.Year);
            }
        } // проверить правильность

        public override string ToString()
        {
            return $"{Id} {Name} {Age}";
        }
    }
}
