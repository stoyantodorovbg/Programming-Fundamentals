using System;


namespace NumbersInreversedOrder
{
    public class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine()); // read a number

            Console.WriteLine(ReverseNumber(number)); // print result
            
        }

        static double ReverseNumber(double number)
        {
            string numberToString = number.ToString();
            string revercedString = string.Empty;

            for (int i = numberToString.Length - 1; i >= 0; i--)
            {
                revercedString += numberToString[i];
            }

            double revercedNumber = double.Parse(revercedString);

            return revercedNumber;
        }
    }
}
