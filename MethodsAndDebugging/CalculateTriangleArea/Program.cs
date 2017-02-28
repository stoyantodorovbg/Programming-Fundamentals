using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseTriangle = double.Parse(Console.ReadLine()); // get dimensions
            double heightTriangle = double.Parse(Console.ReadLine());

            Console.WriteLine(CalculateOfTriangleArea(baseTriangle, heightTriangle)); // print result


        }

        static double CalculateOfTriangleArea(double baseTriangle, double heightTriangle)
        {
            double areaTriangle = (baseTriangle * heightTriangle) / 2;
            return areaTriangle;
        }
    }
}
