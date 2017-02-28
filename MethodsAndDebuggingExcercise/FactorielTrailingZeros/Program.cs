using System;
using System.Numerics;

namespace FactorielTrailingZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine()); // get number

            CalculateFactoriel(number);
        }

        private static void CalculateFactoriel(BigInteger number)
        {
            BigInteger result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            CountZeros(result);
        }

        public static void CountZeros(BigInteger result)
        {
            int count = -1;
            BigInteger lastDigit = 0;

            while (lastDigit == 0)
            {
                lastDigit = result % 10;
                result /= 10;
                count++;
            }

            Console.WriteLine(count); // print result
        }
    }
}
