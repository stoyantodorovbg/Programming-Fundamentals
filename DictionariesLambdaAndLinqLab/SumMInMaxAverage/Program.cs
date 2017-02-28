using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMInMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = int.Parse(Console.ReadLine());
            var list = new List<double>();

            for (int i = 0; i < inputs; i++)
            {
                var number = double.Parse(Console.ReadLine());
                list.Add(number);
            }

            var sum = list.Sum();
            var min = list.Min();
            var max = list.Max();
            var average = list.Average();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
