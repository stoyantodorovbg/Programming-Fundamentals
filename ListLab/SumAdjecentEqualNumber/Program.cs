using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjecentEqualNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            input.Add(int.MaxValue);
            for (int e = 0; e < input.Count; e++)
            {
                var last = input[0];

                for (int i = 1; i < input.Count; i++)
                {
                    var curent = input[i];

                    if (curent == last)
                    {
                        input[i - 1] += input[i];
                        input.Remove(input[i]);
                        break;
                    }
                    last = curent;
                }
            }

            for (int i = 0; i < input.Count - 1; i++)
            {
                Console.Write($"{input[i]} ");
            }
        }
    }
}
