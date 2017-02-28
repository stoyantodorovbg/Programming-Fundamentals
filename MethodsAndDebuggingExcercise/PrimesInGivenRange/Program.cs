using System;
using System.Collections.Generic;

namespace PrimesInGivenRange
{
    class Program
    {
        public static void Main(string[] args)
        {

            int number1 = int.Parse(Console.ReadLine()); // get number
            int number2 = int.Parse(Console.ReadLine());

            FindPrimeNumbers(number1, number2);
        }

        public static void FindPrimeNumbers(int number1, int number2)
        {
            List<int> primes = new List<int>();

            if (number1 < 2)
            {
                number1 = 2;
            }

            for (int e = number1; e <= number2; e++)
            {

                bool prime = true;
                for (int i = 2; i < Math.Sqrt(number2); i++)
                {

                    if (e % i == 0)
                    {
                        prime = false;
                        break;
                    }

                }
                if (prime)
                {
                    primes.Add(e);
                }

            }

            for (int i = 0; i < primes.Count; i++)
            {
                Console.Write(primes[i]);

                if (i == primes.Count - 1)
                {
                    Console.WriteLine();
                    break;
                }
                Console.Write(", ");
            }

        }

    }

}
