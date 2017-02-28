using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var result = new List<double>();

            for (int i = 0; i < input.Count; i++)
            {
                if (Math.Sqrt(input[i]) == (int)Math.Sqrt(input[i]))
                {
                    result.Add(input[i]);
                }
            }
            result.Sort();

            for (int i = result.Count - 1; i >= 0; i--)
            {
                Console.Write($"{result[i]} ");
            }
        }
    }
}
