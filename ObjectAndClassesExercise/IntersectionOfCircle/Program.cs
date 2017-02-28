using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfCircle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputOne = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var inputTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            double x1 = inputOne[0];
            double x2 = inputTwo[0];
            double y1 = inputOne[1];
            double y2 = inputTwo[1];
            double radius1 = inputOne[2];
            double radius2 = inputTwo[2];

            var firstCenter = new Point(x1, y1);
            var secondCenter = new Point(x2, y2);

            var circleOne = new Circle(firstCenter, radius1);
            var circleTwo = new Circle(secondCenter, radius2);

            if (Circle.Intersect(circleOne, circleTwo))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
       
    }

}
