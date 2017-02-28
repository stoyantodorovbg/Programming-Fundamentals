using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            var reversed = new string[input.Length];
            var counter = input.Length - 1;

            for (int i = 0; i < input.Length; i++)
            {
                reversed[i] = input[counter];
                counter--; 
            }

            for (int i = 0; i < reversed.Length; i++)
            {
                Console.Write($"{reversed[i]} ");
            }
        }
    }
}
