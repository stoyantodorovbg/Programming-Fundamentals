using System;


namespace FibonaciNumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); // get number

            Console.WriteLine(FindFibonachiNumber(number)); // print result
        }

        static int FindFibonachiNumber(int number)
        {
            int fibonachiNumberFirst = 0;
            int fibonachiNumberLast = 1;
            int fibonachiNumber = 0;

            for (int i = 1; i <= number; i ++)
            {

                fibonachiNumber = fibonachiNumberFirst + fibonachiNumberLast;
                fibonachiNumberFirst = fibonachiNumberLast;
                fibonachiNumberLast = fibonachiNumber;
            }

            return fibonachiNumberLast;
        }
    }
}
