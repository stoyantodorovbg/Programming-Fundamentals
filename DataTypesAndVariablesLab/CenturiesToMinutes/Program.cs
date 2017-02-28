using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            double centures = double.Parse(Console.ReadLine()); // TODO Get centures

            double years = centures * 100;
            double days = Math.Floor(years * 365.2422);
            double hours = days * 24;
            double minutes = hours * 60;

            Console.WriteLine($"{centures} centures = {years} years = {days} days = {hours} hours = {minutes} minutes "); //TODO Print Result 

        }
    }
}
