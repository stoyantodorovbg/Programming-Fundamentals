using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        { 
            var input = Console.ReadLine().ToUpper();
            var numbers = new Regex(@"[\d]+");
            var other = new Regex(@"[^\d]+");

            var matchesNumbers = numbers.Matches(input);
            var matchesOther = other.Matches(input);

            var numbersList = new List<int>();
            var otherList = new List<string>();

            foreach (Match item in matchesNumbers)
            {
                var number = int.Parse(item.ToString());
                numbersList.Add(number);
            }

            foreach (Match item in matchesOther)
            {
                var symb = item.ToString();
                otherList.Add(symb);
            }

            var uniqueSymbols = new HashSet<char>();

            for (int i = 0; i < otherList.Count; i++)
            {
                for (int e = 0; e < otherList[i].Length; e++)
                {
                    uniqueSymbols.Add(otherList[i][e]);
                }
            }

            var countUniqueSymbols = 0;

            foreach(var item in uniqueSymbols)
            {
                countUniqueSymbols++;
            }

            Console.WriteLine($"Unique symbols used: {countUniqueSymbols}");

            for (int i = 0; i < otherList.Count; i++)
            {
                for (int e = 0; e < numbersList[i]; e++)
                {
                    Console.Write(otherList[i]);
                }
            }

        }
    }
}
