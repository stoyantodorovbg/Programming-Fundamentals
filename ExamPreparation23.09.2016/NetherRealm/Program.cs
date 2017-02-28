using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NetherRealm
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(i => i.Trim(' '))
                .ToList();
            
            var result = new SortedDictionary<string, Dictionary<int, decimal>>();
            

            for (int i = 0; i < input.Count; i++)
            {
                var name = input[i];
                var health = Regex.Replace(name, "[0123456789+-/*.]+", "");
                var healthValue = 0;

                for (int e = 0; e < health.Length; e++)
                {
                    healthValue += (int)health[e];
                }

                var damege = Regex.Replace(name, "[^[0123456789+-/*.]+]*", "");

                var pattern = @"\d*\.\d*|-\d*\.\d*|-\d*^[-]";
                var regex = new Regex(pattern);

                var decimalAndNegative = regex.Matches(damege);

                var damegeDigits = Regex.Replace(damege, @"\d*\.\d*|-\d*\.\d*|-\d*^[-]", "");
                damege = regex.Replace(damegeDigits, @"[+|-|*|/]");
                var damegeSigns = Regex.Replace(damege, "[0123456789+.-]", "");
                var sumDigits = 0m;

                for (int k = 0; k < damegeDigits.Length; k++)
                {
                    var digit = decimal.Parse(damegeDigits[k].ToString());
                    sumDigits += digit;
                }

                for (int l = 0; l < decimalAndNegative.Count; l++)
                {
                    var digit = decimal.Parse(decimalAndNegative[l].ToString());
                    sumDigits += digit;
                }

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

            foreach(var item in result)
            {
                foreach(var itemItem in item.Value)
                {
                    Console.WriteLine($"{item.Key} - {itemItem.Key} health, {itemItem.Value:F2} damage");
                }
                
            }
        }
    }
}
