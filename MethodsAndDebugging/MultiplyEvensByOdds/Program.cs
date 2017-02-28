using System;

namespace MultiplyEvensByOdds
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultiplyValue(number));

        }

        public static  int GetEvenSum(int number)
        {
            int evenSum = 0;


            do
            {
                int digit = number % 10;
                number /= 10;

                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
            } while (number != 0);
            
            
            return evenSum;
        }

        public static int GetOddSum(int number)
        {
            int oddSum = 0;

            do
            {
                int digit = number % 10;
                number /= 10;

                if (digit % 2 != 0)
                {
                    oddSum += digit;
                }
            } while (number != 0);

            return oddSum;
        }


        public static int GetMultiplyValue(int number)
        {
            int multiplyValue = GetEvenSum(number) * GetOddSum(number);
            return multiplyValue;
        }
    }
}
