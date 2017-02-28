using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var runners = int.Parse(Console.ReadLine());
            var lapsByRunner = int.Parse(Console.ReadLine());
            var trackLengthMeters = int.Parse(Console.ReadLine());
            var capacity = int.Parse(Console.ReadLine());
            var moneyPerKM = decimal.Parse(Console.ReadLine());
            var capacityForAllDays = capacity * days;

            if (runners > capacityForAllDays)
            {
                runners = capacityForAllDays;
            }

            decimal sumAllLaps = runners * lapsByRunner;
            decimal sumAllMeters = sumAllLaps * trackLengthMeters;
            decimal sumAllKm = sumAllMeters / 1000m;
            decimal sumAllMoney = sumAllKm * moneyPerKM;

            Console.WriteLine($"Money raised: {sumAllMoney:f2}");

        }
    }
}
