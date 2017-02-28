using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine()); // get number and power
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculatePower(number, power));

        }

        static double CalculatePower (double number, int power) // calculate power of number
        {
            double result = 1;

            for (int i = 1; i <= power; i++ ) 
            {
                result *= number; 
            }

            return result;
        }
    }
}
