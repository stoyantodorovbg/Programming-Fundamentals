using System;


namespace SieveOfEratsthones
{
    public class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine()); //get input

            bool[] checkPrime = new bool[inputNumber]; // check for prime

            for (int i = 2; i < checkPrime.Length; i++)
            {
                checkPrime[i] = true;
            }

            for (int n = 2; n < checkPrime.Length; n++)
            {
                for (int i = 2; i < checkPrime.Length; i++)
                {
                    if ((n * i) < checkPrime.Length)
                    {
                        checkPrime[n * i] = false;
                    }
                }
            }

            for (int i = 0; i < checkPrime.Length; i++) //print result
            {
                bool check = checkPrime[i];
                if (check)
                {
                    Console.Write($"{i} ");   
                }
            }
            bool checkN = true;
            for (int i = 2; i < inputNumber; i++)
            {
                if (inputNumber % i == 0)
                {
                    checkN = false;
                }
            }

            if (checkN)
            {
                Console.Write(inputNumber);
            }
        }
    }
}
