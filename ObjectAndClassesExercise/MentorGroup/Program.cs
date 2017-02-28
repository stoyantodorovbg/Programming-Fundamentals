using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MentorGroup
{ 
public class Program
    {
        public static void Main(string[] args)
        {
            var inputUser = Console.ReadLine().Trim();

            var nameDate = new Dictionary<string, List<string>>();
            var nameComments = new Dictionary<string, string>();
       
            while(inputUser != "end of dates")
            {
                var inputArr = inputUser.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var dates = inputArr[1]
                    .Split(',').ToList();
                dates.Sort();

                var student = new Student(inputArr[0], dates);

                nameDate[student.Name] = student.Dates;

                inputUser = Console.ReadLine();
            }

            var inputComments = Console.ReadLine().Trim();

            while (inputComments != "end of comments")
            {
                var inputArr = inputComments.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var comments = new Comments(inputArr[0], inputArr[1]);

                nameComments[comments.Name] = comments.Comment;

                inputComments = Console.ReadLine();
            }

            foreach (var item in nameDate)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine("Comments:");

                if (nameComments.ContainsKey(item.Key))
                {
                    Console.WriteLine($"- {nameComments[item.Key]}");
                }

                Console.WriteLine("Dates attended:");

                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"-- {item.Value[i]}");
                }
            }
        }
    }
}
