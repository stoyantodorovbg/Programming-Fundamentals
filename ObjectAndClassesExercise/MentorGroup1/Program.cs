using System;
using System.Collections.Generic;
using System.Linq;

namespace MentorGroup
{
    public class Program
    {
        public static void Main()
        {
            var inputUser = Console.ReadLine().Split(' ').ToList();

            var nameDate = new Dictionary<string, List<string>>();
            var nameComments = new Dictionary<string, string>();

            while (inputUser[0] != "end")
            {
                var userName = inputUser[0];

                var dates = inputUser[1]
                    .Split(',').ToList();
                dates.Sort();

                nameDate[userName] = dates;

                inputUser = Console.ReadLine().Split(' ').ToList();
            }

            var inputComments = Console.ReadLine().Split('-').ToList<string>();

            while (inputComments[0] != "end of comments")
            {

                var userName = inputComments[0];

                var comment = inputComments[1];

                nameComments[userName] = comment;

                inputComments = Console.ReadLine().Split('-').ToList<string>();
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
