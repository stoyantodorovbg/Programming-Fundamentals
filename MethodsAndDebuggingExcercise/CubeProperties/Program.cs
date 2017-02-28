using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine()); // get data
            string property = Console.ReadLine();

            ChoiseProperty(property, side); //print result

        }

        static void ChoiseProperty(string property, double side)
        {
            double result = 0;

            switch (property)
            {
                case "face":
                   result = FindFaceDiagonals(side);
                    break;

                case "space":
                    result = FindSpaceDiagonals(side);
                    break;
                case "volume":
                    result = FindVolume(side);
                    break;
                case "area":
                    result = FindArea(side);
                    break;
            }

            Console.WriteLine($"{result:f2}");
        }

        static double FindFaceDiagonals(double side)
        {
            double faceDiagonal = (side * side) * 2;
            return Math.Sqrt(faceDiagonal);
        }

        static double FindSpaceDiagonals(double side)
        {
            double faceDiagonal = (side * side) * 2;
            faceDiagonal = Math.Sqrt(faceDiagonal);

            double spaceDiagonal = (side * side) + (faceDiagonal * faceDiagonal);
            spaceDiagonal = Math.Sqrt(spaceDiagonal);
            return spaceDiagonal;
        }

        static double FindVolume(double side)
        {
            double volume = side * side * side;
            return volume;
        }

        static double FindArea(double side)
        {
            double area = (side * side) * 6;
            return area;
        }
    }

}