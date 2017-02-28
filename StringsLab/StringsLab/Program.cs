using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var reversed = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                reversed.Add(input[i]);
            }

            reversed.Reverse();
            reversed.ForEach(Console.Write);
        }
    }
}
