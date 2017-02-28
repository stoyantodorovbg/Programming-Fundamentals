using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SplitWordByCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, 
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var lower = new List<string>();
            var mix = new List<string>();
            var upper = new List<string>();

            var patternUpper = @"[A-Z][A-Z]+";
            var regexUpper = new Regex(patternUpper);

            for (int i = 0; i < input.Count; i++)
            {
                bool isLower = true;
                bool isUpper = false;
                bool isMix = false;

                for (int e = 0; e < input[i].Length; e++)
                {
                    char check = input[i][e];

                    if (!char.IsLower(check))
                    {
                        isLower = false;
                    }

                }

                if (regexUpper.IsMatch(input[i]))
                {
                    isUpper = true;
                }
                if (!isLower && !isUpper)
                {
                    isMix = true;
                }

                if (isMix)
                {
                    mix.Add(input[i]);
                }
                else if (isLower)
                {
                    lower.Add(input[i]);
                }
                else if (isUpper)
                {
                    upper.Add(input[i]);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lower)}");

            Console.WriteLine($"Mixed-case: {string.Join(", ", mix)}");

            Console.WriteLine($"Upper-case: {string.Join(", ", upper)}");
            
        }
    }
}
