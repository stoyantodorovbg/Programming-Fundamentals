using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NRealm
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(i => i.Trim(' '))
            .ToList();

            var result = new SortedDictionary<string, Dictionary<int, decimal>>();

            for (int i = 0; i < input.Count; i++)
            {
                var name = input[i];
                var health = Regex.Replace(name, @"[0123456789+-/*.]+", "");
                var healthValue = 0;

                for (int e = 0; e < health.Length; e++)
                {
                    healthValue += (int)health[e];
                }

                //var damege = Regex.Replace(name, @"[^[0123456789+-/*.]+]*", "");

                var regexDigit = new Regex(@"-?\d+\.?\d*");
                var matchesDigits = regexDigit.Matches(name);

                var digitsList = new List<decimal>();

                foreach( Match match in matchesDigits)
                {
                    var item = decimal.Parse(match.ToString());
                    digitsList.Add(item);
                }
                var sumDigits = 0m;

                foreach(var item in digitsList)
                {
                    sumDigits += item;
                }

                var damegeSigns = Regex.Replace(name, "[0123456789+.-]", "");

                for (int j = 0; j < damegeSigns.Length; j++)
                {
                    if (damegeSigns[j] == '*')
                    {
                        sumDigits *= 2;
                    }
                    else if (damegeSigns[j] == '/')
                    {
                        sumDigits /= 2;
                    }
                }

                var resultValue = new Dictionary<int, decimal>();

                resultValue[healthValue] = sumDigits;

                result[name] = resultValue;

            }

            foreach (var item in result)
            {
                foreach (var itemItem in item.Value)
                {
                    Console.WriteLine($"{item.Key} - {itemItem.Key} health, {itemItem.Value:F2} damage");
                }

            }
        }
    }
}
