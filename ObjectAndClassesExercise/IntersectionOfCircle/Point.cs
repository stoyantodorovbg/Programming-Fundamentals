using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfCircle
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static double Distance(Point point1, Point point2)
        {
            double distance = 0;
            distance = Math.Sqrt(Math.Pow(Math.Abs(point1.X - point2.X), 2) +
                Math.Pow(Math.Abs(point1.Y - point2.Y), 2));
            return distance;
        }
    }
}
