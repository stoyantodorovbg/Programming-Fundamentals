using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorGroup
{
    public class Student
    {
        public string Name { get; set; }
        public List<string> Dates { get; set; }

        public Student(string name, List<string> dates)
        {
            Name = name;
            Dates = dates;
        }
    }
}
