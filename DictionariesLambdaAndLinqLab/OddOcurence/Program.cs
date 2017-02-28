using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOcurence
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                  .ToLower()
                  .Split(' ')
                  .ToList();
            var inputDict = new Dictionary<string, int>();

            foreach (var item in input)
            {

                if (!inputDict.ContainsKey(item))
                {
                    inputDict[item] = 0;
                }
                inputDict[item]++;
            }
            var results = new List<string>();

            foreach (var item in inputDict)
            {
                if (item.Value % 2 != 0)
                {
                    results.Add(item.Key);   
                }
                   
            }

            Console.WriteLine(String.Join(", ", results));
        }
    }
}
