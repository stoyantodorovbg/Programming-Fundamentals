using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            CheckFigureType(figureType);
        }

        public static void CheckFigureType(string figureType)
        {
            switch(figureType)
            {
                case "triangle":
                    CalculateTriangleArea();
                    break;
                case "square":
                    CalculateSquareArea();
                    break;
                case "rectangle":
                    CalculateRectangleArea();
                    break;
                case "circle":
                    CalculateCircleArea();
                    break;

            }
        }

        public static void CalculateTriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = (side * height) / 2;
            Console.WriteLine($"{area:F2}");
        }

        public static void CalculateSquareArea()
        {
            double side = double.Parse(Console.ReadLine());

            double area = side * side;
            Console.WriteLine($"{area:F2}");
        }

        public static void CalculateRectangleArea()
        {
            double firstSide = double.Parse(Console.ReadLine());
            double seconSide = double.Parse(Console.ReadLine());

            double area = firstSide * seconSide;
            Console.WriteLine($"{area:F2}");
        }

        public static void CalculateCircleArea()
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;
            Console.WriteLine($"{area:F2}");
        }
    }
}
