using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public Student(string name, List<double> grades)
        {
            Name = name;
            Grades = grades;
        }

        public Dictionary<string, double> HighGrades(Student student)
        {
            double average = student.Grades.Average();
            //string averageString = ($"{average:f2}").ToString();
           // average = double.Parse(averageString);

            var result = new Dictionary<string, double>();

            if (average >= 5.00)
            {
                result[student.Name] = average;
            }

            return result;
        }

       


       
       
    }
}
