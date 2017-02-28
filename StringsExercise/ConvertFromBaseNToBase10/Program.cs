using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim(' ').Split(' ').ToList();
            var baseNumber = int.Parse(input[0]);
            var number = (input[1]);

            var baseList = new List<BigInteger>();
            string result = string.Empty;

            for (int i = 0; i < number.Length; i++)
            {
                var digit = int.Parse(number[i].ToString());

                var baseDigit = digit * BigInteger.Pow(baseNumber, number.Length - i - 1);
                result += baseDigit;  
            }

            Console.WriteLine(result);

        }
    }
}
