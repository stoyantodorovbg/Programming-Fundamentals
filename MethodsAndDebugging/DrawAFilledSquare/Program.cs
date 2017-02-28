using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); // get a number

            OuterLine(number); //print the square
            for (int row = 0; row < number - 2; row ++)
            {
                InnerLines(number);
            }
            OuterLine(number);
        }

        static void OuterLine(int number) // print top and bottom rows of the square
        {
            Console.Write(new string('-', number * 2));
            Console.WriteLine();
        }

        static void InnerLines(int number)  // print the middle rows of the square
        {
            Console.Write('-');

            for (int cell = 1; cell < number; cell++)
            {
                Console.Write("\\/");
            }

            Console.Write('-');
            Console.WriteLine();
        }

    }
}
