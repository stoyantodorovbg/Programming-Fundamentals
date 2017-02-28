using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var counter = 0;
            while (input.Count > 0)
            {
                if (counter == 3)
                {
                    break;
                }
                counter++;
                var max = input.Max();
                Console.Write($"{max} ");
                input.Remove(max);
            }
        }
    }
}
