using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var baseNumber = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1].ToString());

            var result = string.Empty;

            while (number > 0)
            {
                var remainder = number % baseNumber;
                result = remainder + result;
                number /= baseNumber;
            }
                Console.Write(result);
        }
    }
}
