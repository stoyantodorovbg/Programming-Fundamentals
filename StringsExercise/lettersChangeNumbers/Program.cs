using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim(' ').Split(new string[] { " ", "\t",""}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var FinalResult = 0m;
            var alphabetLower = "abcdefghijklmnopqrstuvwxyz";
            var alphabetUpper = alphabetLower.ToUpper();

            for (int i = 0; i < input.Length; i++)
            {
                var result = 0m;
                var word = input[i];
                var number = decimal.Parse(input[i].Substring(1, input[i].Length - 2));
                if (alphabetUpper.Contains(word[0]))
                {
                    result += number / (alphabetUpper.IndexOf(word[0]) + 1);
                }
                else
                {
                    result += number * (alphabetLower.IndexOf(word[0]) + 1);
                }

                if (alphabetUpper.Contains(word[word.Length - 1]))
                {
                    result -= alphabetUpper.IndexOf(word[word.Length - 1]) + 1;
                }
                else
                {
                    result += alphabetLower.IndexOf(word[word.Length - 1]) + 1;
                }

                FinalResult += result;
            }

            Console.WriteLine($"{FinalResult:f2}");

        }
    }
}
