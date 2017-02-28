using System;


namespace MasterNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); // get a number

            for (int i = 232; i <= number; i++)
            {
                bool symmetric = CheckForSymmetric(i);
                bool devisionBySeven = CheckForDevisionBySeven(i);
                bool evendigit = CheckForEvenDigit(i);

                if (symmetric == true && devisionBySeven == true && evendigit == true)
                {
                    Console.WriteLine(i);
                }
               
            }
            
        }
     
        private static bool CheckForEvenDigit(int i)
        {
            bool check = false;

           while (i > 0)
           { 
                int digit = i % 10;
                i /= 10;

                if (digit % 2 == 0)
                {
                    check = true;
                }
                
            }

            return check;
        }

        private static bool CheckForDevisionBySeven(int i)
        {
            bool check = false;
            int sumOfDigits = 0;
            int digit = 0;

            while (i > 0)
            {

                digit = i % 10;
                i /= 10;

                sumOfDigits += digit;
            }
        
            if (sumOfDigits % 7 == 0)
            {
                    check = true;
            }

            return check;
        }

        private static bool CheckForSymmetric(int i)
        {
            bool checkSymmetric = true;
            string stringNumber = i.ToString();

            for (int e = 0; e < stringNumber.Length; e++)
            {
                if (stringNumber[e] != stringNumber[stringNumber.Length - 1 - e])
                {
                    checkSymmetric = false;
                }
            }

            return checkSymmetric;
        }
    }
}
