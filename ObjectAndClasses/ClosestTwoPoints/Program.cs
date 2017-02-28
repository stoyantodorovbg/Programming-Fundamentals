using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = ReadPoints();
            Point[] closestPoints = FindClosestTwoPoints(points);

            PrintDistance(closestPoints);

            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);

        }

        private static void PrintPoint(Point point)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }

        private static void PrintDistance(Point[] closestPoints)
        {
            double distance = CalcDistance(closestPoints[0], closestPoints[1]);

            Console.WriteLine($"{distance:f3}");
        }

        static Point[] ReadPoints()
        {
            int count = int.Parse(Console.ReadLine());

            Point[] points = new Point[count];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = ReadPoint();
            }

            return points;

        }

        static Point[] FindClosestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = new Point[2];

            for (int pointOne = 0; pointOne < points.Length; pointOne++)
            {
                for (int pointTwo = pointOne + 1; pointTwo < points.Length; pointTwo++)
                {
                    double distance = CalcDistance(points[pointOne], points[pointTwo]);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints[0] = points[pointOne];
                        closestTwoPoints[1] = points[pointTwo];
                    }
                }
            }

            return closestTwoPoints;


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
            Point point = new Point(pointInfo[0], pointInfo[1]);

            return point;
        }

    }

    class Point
    {
        public int X;
        public int Y;

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

    }
}
