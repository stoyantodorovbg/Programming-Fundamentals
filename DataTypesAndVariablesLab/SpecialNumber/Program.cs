using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());  // get number
            
            

            for (int checkedNumber = 1; checkedNumber <= number; checkedNumber++)
            {
                int digit = 0; 
                int restOfNumber = checkedNumber;
                int sumOfDigits = 0;
                
                do // get digits of checkedNumber
                {
                    digit = restOfNumber % 10;  
                    restOfNumber /= 10;
                    sumOfDigits += digit;
                }
                while (restOfNumber > 0);

                bool specialNumber = false;  // check for special number

                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    specialNumber = true;
                }

                Console.WriteLine($"{checkedNumber} -> {specialNumber}"); // print the result

            }
        }
    }
}
