using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .ToList();

            var random = new Random();

            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine(input[random.Next(0, input.Count)]);
            }
        }
    }
}
