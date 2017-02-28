using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string[] week = new string[7];
            week[0] = "Monday";
            week[1] = "Tuesday";
            week[2] = "Wednesday";
            week[3] = "Thursday";
            week[4] = "Friday";
            week[5] = "Saturday";
            week[6] = "Sunday";

            if (input > 0 && input <= 7)
            {
                Console.WriteLine(week[input - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }

        }
    }
}