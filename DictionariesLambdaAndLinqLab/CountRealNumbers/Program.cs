using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse);

            SortedDictionary<double, int> count = new SortedDictionary<double, int>();

            foreach (var item in input)
            {
                if (!count.ContainsKey(item))
                {
                    count[item] = 0;
                }
                count[item]++;
            }

            foreach(var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
