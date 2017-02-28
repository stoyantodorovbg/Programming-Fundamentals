using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            var result = new Dictionary<string, double>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                var grades = Console.ReadLine().Trim().Split(' ').ToList();
                string name = grades[0];

                grades.Remove(grades[0]);

                var gradesDouble = grades.Select(double.Parse).ToList();

                Student student = new Student(name, gradesDouble);
                var studentAverageGrade = new Dictionary<string, double>();

                studentAverageGrade = (student.HighGrades(student));
                foreach(var item in studentAverageGrade)
                {
                    if (!result.ContainsKey(item.Key))
                    {
                        result[item.Key] = item.Value;
                    }  
                    else
                    { 
                        result[item.Key + "*"] = item.Value;
                    }  
                }
               
            }

            foreach(var item in result.OrderBy(x => x.Key).ThenByDescending(x => x.Value))
            {
                if (!item.Key.Contains('*'))
                {
                    Console.WriteLine($"{item.Key} -> {item.Value:f2}");
                }
                else
                {
                    Console.WriteLine($"{item.Key.Remove(item.Key.Length-1)} -> {item.Value:f2}");
                }
            }
        }
    }
}
