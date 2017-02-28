using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FildAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var left = new List<int>();
            var right = new List<int>();

            for (int i = 0; i < input.Count / 4; i++)
            {
                left.Add(input[i]);
            }

            for (int i = input.Count -1; i >= input.Count - input.Count / 4; i--)
            {
                right.Add(input[i]);
            }
            var count = input.Count;

            for (int i = 0; i < count / 4; i++)
            {
                input.Remove(input[count - count / 4]);
            }

            for (int i = 0; i < count / 4; i++)
            {
                input.Remove(input[0]);
            }

            left.Reverse();
            left.AddRange(right);

            for (int i = 0; i < input.Count; i++)
            {
                input[i] += left[i];
            }

            Console.Write(string.Join(" ", input));


        }
    }
}
