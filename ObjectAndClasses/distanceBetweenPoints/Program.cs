using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pointFirst = ReadPoint();
            Point pointSecond = ReadPoint();

            double distance = CalcDistance(pointFirst, pointSecond);

            Console.WriteLine($"Distance: {distance:f3}");
        }

        static double CalcDistance(Point pointFirst, Point pointSecond)
        {
            int deltaX = pointSecond.X - pointFirst.X;
            int deltaY = pointSecond.Y - pointFirst.Y;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return distance;
        }

        static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point point = new Point() { X = pointInfo[0], Y = pointInfo[1] };

            return point;
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}