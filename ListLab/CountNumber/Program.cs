using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var dict = new Dictionary<int, int>();
            
            for (int i = 0; i < input.Count; i++)
            {
                if(!dict.ContainsKey(input[i]))
                {
                    dict[input[i]] = 1;
                }
                else
                {
                    dict[input[i]]++;
                }
            }

            foreach(var item in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
