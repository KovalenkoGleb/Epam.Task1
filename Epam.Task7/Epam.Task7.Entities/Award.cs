using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.Entities
{
    public class Award
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string url = "https://pp.userapi.com/c850616/v850616590/b329c/QytFqA3czgQ.jpg";

        public override string ToString()
        {
            return $"{Id} {Title}";
        }
    }
}
