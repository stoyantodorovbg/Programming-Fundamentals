using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); //get number
            PrintSign(number);
        }

        static void PrintSign(int number)
        {
            if (number > 0) // chech the sign of number
            {
                Console.WriteLine($"The number {number} is positive."); 
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number 0 is zero.");
            }

        }
    }
}
