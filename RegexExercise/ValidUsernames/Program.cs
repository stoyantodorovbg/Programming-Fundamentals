using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var inputArr = input
                .Split(new[] { '(', ')', ' ', '/', '\\' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var pattern = @"[\w][\w|\d]+";
            var regex = new Regex(pattern);

            var matches = regex.Matches(input);

            var resultMatch = new List<string>();
            
            foreach (Match match in matches)
            {
                if (match.Length > 2 && match.Length < 26)
                {
                    resultMatch.Add(match.ToString());
                }
            }
            var digitPat = @"\d";
            var regDig = new Regex(digitPat);

            for (int i = 0; i < resultMatch.Count; i++)
            {
                var isMatch = false;
                var firstSymbol = resultMatch[i][0];
                if (regDig.IsMatch(firstSymbol.ToString()))
                {
                    isMatch = true;
                }
                
                if (isMatch)
                {
                    resultMatch.Remove(resultMatch[i]);
                }
            }

            var couples = new List<string>();

            for (int i = 1; i < resultMatch.Count; i++)
            {
                couples.Add(resultMatch[i] + " " + resultMatch[i - 1]);
            }
            
            var maxLength = 0;

            for (int i = 0; i < couples.Count; i++)
            {
                if (couples[i].Length > maxLength)
                {
                    maxLength = couples[i].Length;
                }

            }

            var maxString = "";

            for (int i = 0; i < couples.Count; i++)
            {
                if (couples[i].Length == maxLength)
                {
                    maxString = couples[i];
                    break;

                }
            }

            var result = maxString.Split(' ').ToList();

            Console.WriteLine(result[1]);
            Console.WriteLine(result[0]);


        }
    }
}



