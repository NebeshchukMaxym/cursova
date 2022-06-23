using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }

        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Surname} {Name}, {Year} курс";
        }
    }
}
