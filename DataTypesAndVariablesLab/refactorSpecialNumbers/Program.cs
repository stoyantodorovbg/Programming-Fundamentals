using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); //get number

            int sum = 0;
            int keepCheckNumber = 0;
            bool specialNumber = false;
            for (int checkNumber = 1; checkNumber <= number; checkNumber++) //check for special number
            {
                keepCheckNumber = checkNumber;

                while (checkNumber > 0)
                {
                    sum += checkNumber % 10;
                    checkNumber = checkNumber / 10;
                }

                specialNumber = (sum == 5) || (sum == 7) || (sum == 11);
                sum = 0;
                checkNumber = keepCheckNumber;

                Console.WriteLine($"{keepCheckNumber} -> {specialNumber}"); // print result
               
            }

        }
    }
}
