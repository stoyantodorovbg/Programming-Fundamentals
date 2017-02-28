using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pallindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var regex = new Regex("[A-Za-z]+");

            var matches = regex.Matches(text);

            var listMatches = new List<string>();

            foreach(Match match in matches)
            {
                var stringMatch = match.ToString();
                listMatches.Add(stringMatch);
            }

            var result = new HashSet<string>();

            foreach(var item in listMatches)
            {
                var itemToList = item.ToList();
                var firstPart = itemToList.Take(itemToList.Count / 2).ToList();
                var secondPart = itemToList.Skip(itemToList.Count / 2).ToList();
                secondPart.Reverse();

                var equal = true;
                for (int i = 0; i < firstPart.Count; i++)
                {
                    if (firstPart[i] != secondPart[i])
                    {
                        equal = false;
                    }
                }
                if (equal)
                {
                    result.Add(item);
                }
            }
            var resultList = new List<string>();

            foreach(var item in result)
            {
                resultList.Add(item);
            }

            resultList.Sort();
            Console.WriteLine(string.Join(", ", resultList));
        }
    }
}
