using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1FirstLine = double.Parse(Console.ReadLine()); // get coordinates of first line
            double y1FirstLine = double.Parse(Console.ReadLine());
            double x2FirstLine = double.Parse(Console.ReadLine());
            double y2FirstLine = double.Parse(Console.ReadLine());

            double x1SecondLine = double.Parse(Console.ReadLine()); // get coordinates of seconds line
            double y1SecondLine = double.Parse(Console.ReadLine());
            double x2SecondLine = double.Parse(Console.ReadLine());
            double y2SecondLine = double.Parse(Console.ReadLine());

            bool line1Bool = GetMax(GetLineLenght(x1FirstLine, y1FirstLine, x2FirstLine, y2FirstLine), // find the bigger line
                GetLineLenght(x1SecondLine, y1SecondLine, x2SecondLine, y2SecondLine));

            if (line1Bool)
            {
                FindClosestCoordinates(x1FirstLine, y1FirstLine, x2FirstLine, y2FirstLine); //print result
            }
            else
            {
                FindClosestCoordinates(x1SecondLine, y1SecondLine, x2SecondLine, y2SecondLine);
            }
        }

        static double GetLineLenght(double x1, double y1, double x2, double y2)
        {
            double kathetus1 = Math.Abs(x1 - x2);
            double kathetus2 = Math.Abs(y1 - y2);
            double hypotenuse = kathetus1 * kathetus1 + kathetus2 * kathetus2;
            hypotenuse = Math.Sqrt(hypotenuse);
            return hypotenuse;
        }

        static bool GetMax(double firstNumber, double secondNumber)  //calculate max value
        {
            bool line1Bool = true;
            if (firstNumber < secondNumber)
            {
                return line1Bool = false;
            }
            else
            {
                return line1Bool = true;
            }
        }

            static void FindClosestCoordinates(double x1, double y1, double x2, double y2)
        {
            double x1Abs = Math.Abs(x1);
            double y1Abs = Math.Abs(y1);
            double x2Abs = Math.Abs(x2);
            double y2Abs = Math.Abs(y2);

            if (x1Abs + y1Abs > x2Abs + y2Abs)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else if (x1Abs + y1Abs < x2Abs + y2Abs)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }
    }
}
