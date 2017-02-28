using System;


namespace EnglishNameOfLastDigit
{
    class Program
    {
        public static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine()); // get number

            Console.WriteLine(GetNameOfLastDigit(number)); // print result

        }

        static string GetNameOfLastDigit(long number)
        {
            int digit = (int)Math.Abs(number % 10);
      
            string name = null;

            switch (digit)
            {
                case 0:
                    name = "zero";
                    break;
                case 1:
                    name = "one";
                    break;

                case 2:
                    name = "two";
                    break;

                case 3:
                    name = "three";
                    break;

                case 4:
                    name = "four";
                    break;

                case 5:
                    name = "five";
                    break;

                case 6:
                    name = "six";
                    break;

                case 7:
                    name = "seven";
                    break;

                case 8:
                    name = "eight";
                    break;

                case 9:
                    name = "nine";
                    break;
            }
            return name;
        }
    }
}
