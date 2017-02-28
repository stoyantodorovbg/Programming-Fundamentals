using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfCircle
{
    public class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public static bool Intersect(Circle circleOne, Circle circleTwo)
        {
            bool intersect = false;

            double distance = Point.Distance(circleOne.Center, circleTwo.Center);
            if (distance <= circleOne.Radius + circleTwo.Radius)
            {
                intersect = true;
            }

            return intersect;
        }
    }
}
