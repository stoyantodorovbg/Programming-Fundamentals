using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinoTheWalker1
{
    class Program
    {
        static void Main(string[] args)
        {
            var departTime = DateTime.ParseExact(Console.ReadLine(), ("HH:mm:ss"), CultureInfo.InvariantCulture);
            var steps = ulong.Parse(Console.ReadLine());
            var secondsPerStep = ulong.Parse(Console.ReadLine());

            var allSeconds = steps * secondsPerStep;
            var secondsInDeyOfDeparture = allSeconds % (60 * 60 * 24);

            var arriveTime = departTime.AddSeconds(secondsInDeyOfDeparture);
            var result = arriveTime.ToString("HH:mm:ss");

            Console.WriteLine($"Time Arrival: {result}");

        }
    }
}
