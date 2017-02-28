using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace removeNegativesAndRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var elements = false;
            

            for (int i = 0; i < input.Count; i++)
            {
                int number = input[i];
                if (number < 0)
                {
                    input.Remove(number);
                    i--;
                }
                else
                {
                    elements = true;
                }
            }

            input.Reverse();

            if(!elements)
            {
                Console.WriteLine("empty");
            }
            else
            {
                for (int i = 0; i < input.Count; i++)
                {
                    Console.Write($"{input[i]} ");
                }
            }
            

        }
    }
}
