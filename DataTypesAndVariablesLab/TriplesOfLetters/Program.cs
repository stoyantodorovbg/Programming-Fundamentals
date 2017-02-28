using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); // get number

            for (int firstChar = 0; firstChar < number; firstChar++) // find all cases
            {
                for (int secondChar = 0; secondChar < number; secondChar++)
                {
                    for (int thirdChar = 0; thirdChar < number; thirdChar++)
                    {
                        char firstLetter = (char)('a' + firstChar); // convert numbers in letters
                        char secondLetter = (char)('a' + secondChar);
                        char thirdLetter = (char)('a' + thirdChar);

                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}"); // print the result
                    }
                }
            }
        }
    }
}
