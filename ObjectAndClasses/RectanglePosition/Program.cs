using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangleFirst = ReadRectangle();
            Rectangle rectangleSecond = ReadRectangle();

            Console.WriteLine(rectangleFirst.IsInside(rectangleSecond) ? "Inside" : "Not inside");
        }

        static Rectangle ReadRectangle()
        {
            double[] rectangleInfo = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Rectangle rectangle = new Rectangle(rectangleInfo[0], rectangleInfo[1], rectangleInfo[2], rectangleInfo[3]);
            return rectangle;
        }
    }

    class Rectangle
    {
        public double Top { get; set; }
        public double Left { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public double Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        public double Right
        {
            get
            {
                return Left + Width;
            }
        }

        public bool IsInside(Rectangle second)
        {
            return (second.Left <= Left) && (second.Right >= Right) &&
                        (second.Top <= Top) && (second.Bottom >= Bottom);
        }

        public Rectangle(double Left, double Top, double Width, double Height)
        {
            this.Top = Top;
            this.Left = Left;
            this.Width = Width;
            this.Height = Height;
        }
    }
}
