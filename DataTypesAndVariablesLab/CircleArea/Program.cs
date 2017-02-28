using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine()); // Get a radius

            double circleArea = Math.PI * radius * radius; // Calculate radius

            Console.WriteLine("{0:f12}", circleArea); // Print Result
        }
    }
}
