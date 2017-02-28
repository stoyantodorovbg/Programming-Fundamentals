
using System;
using System.Linq;

namespace ConsoleApplication6
{
   public class Program
    {
        public static void Main(string[] args)
        {
            var drivers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var track = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            var checkPoints = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            foreach (var driver in drivers)
            {
                double fuel = driver.First();
                for (int i = 0; i < track.Length; i++)
                {
                    var curentZoneFuel = track[i];
                    if (checkPoints.Contains(i))
                    {
                        fuel += curentZoneFuel;
                    }
                    else
                    {
                        fuel -= curentZoneFuel;
                    }
                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{driver} - reached {i}");
                        break;
                    }
                }

                if (fuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:f2}");
                }


            }
        }

    }
}
