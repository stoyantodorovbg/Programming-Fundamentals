using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeLeaves = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            var steps = int.Parse(Console.ReadLine());
            var stepTime = int.Parse(Console.ReadLine());

            long allSeconds = stepTime * steps;
            var allMinutes = (int)allSeconds / 60;
            var hours = allMinutes / 60;
            var minutes = allMinutes % 60;
            long secondsLong = allSeconds % 60;
            var seconds = (int)secondsLong;

            TimeSpan timeLeavesTS = new TimeSpan(timeLeaves[0], timeLeaves[1], timeLeaves[2]);
            TimeSpan timeWalk = new TimeSpan(hours, minutes, seconds);
            var timeArrival = timeLeavesTS.Add(timeWalk);

            var timeArrivalToString = timeArrival.ToString();
            var result = timeArrivalToString;

            Console.Write("Time Arrival: ");
            for (int i = result.Length - 8; i < result.Length; i++)
            {
                Console.Write(result[i]);
            }
        }
    }
}
