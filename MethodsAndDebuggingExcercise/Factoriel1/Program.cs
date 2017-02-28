using System;
using System.Numerics;


namespace factoriel
{
    class Program
    {
        public static void Main(string[] args)
        {
             BigInteger number = BigInteger.Parse(Console.ReadLine());

            CalculateFactoriel(number);
        }

        private static void CalculateFactoriel(BigInteger number)
        {
            BigInteger result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
