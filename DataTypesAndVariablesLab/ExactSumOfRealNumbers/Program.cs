using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine()); // get a number of inputs

            decimal sum = 0m;

            for (int inputs = 0; inputs < numbers; inputs++)  
            {
                decimal realNumber = decimal.Parse(Console.ReadLine());  
                sum += realNumber;                        // calculate sum                                                       
            }

            Console.WriteLine(sum);                       // print the result
        }
    }
}
