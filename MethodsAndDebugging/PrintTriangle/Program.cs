using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTriangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int end = int.Parse(Console.ReadLine()); //get the scope of triangle

            for (int row = 1; row <= end; row++)  //print the triangle
            {
                PrintLineIncreasingNumbers(1, row);
            }

            for (int row = end -1; row >= 1; row--)
            {
                PrintLineIncreasingNumbers(1, row);
            }
        }

        static void PrintLineIncreasingNumbers(int start, int end) //print the rows of triangle
        {
            for (int col = start; col <= end; col++)
            {
                Console.Write($"{col} ");
            }

            Console.WriteLine();
        }
    }
}

