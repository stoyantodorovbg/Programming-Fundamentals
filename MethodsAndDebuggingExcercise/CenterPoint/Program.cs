using System;


namespace CenterPoint
{
    public class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine()); // get coordinates
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            FindClosestCoordinates(x1, y1, x2, y2);

        }

        static void FindClosestCoordinates(double x1, double y1, double x2, double y2)
        {
            double x1Abs = Math.Abs(x1);
            double y1Abs = Math.Abs(y1);
            double x2Abs = Math.Abs(x2);
            double y2Abs = Math.Abs(y2);

            if (x1Abs + y1Abs > x2Abs + y2Abs)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else if (x1Abs + y1Abs < x2Abs + y2Abs)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
    }
}
