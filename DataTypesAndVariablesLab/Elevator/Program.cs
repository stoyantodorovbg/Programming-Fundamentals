using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine()); // get number of people
            int capacity = int.Parse(Console.ReadLine()); // get capacity of elevator

            int courses = people / capacity; // calculate curses

            if (people % capacity != 0)
            {
                courses++;
            }

            Console.WriteLine(courses); // print the result
        }
    }
}
