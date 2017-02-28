using System;

namespace CheckPrime1
{
    class Program
    {
        static void Main(string[] args)
        {

            long number = long.Parse(Console.ReadLine()); // get number
            Console.WriteLine(CheckForPrime(number));
        }

        static bool CheckForPrime(long number)
        {
            bool prime = true;

            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                }
            }
            if (number < 2)
            {
                prime = false;
            }


            return prime;
        }

    }


}
