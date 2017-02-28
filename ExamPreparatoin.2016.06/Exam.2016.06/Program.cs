using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._2016._06
{
    class Program
    {
        static void Main(string[] args)
        {
            var flights = int.Parse(Console.ReadLine());
            var overallProfit = 0m;

            for (int i = 0; i < flights; i++)
            {
                var adults = long.Parse(Console.ReadLine());
                var adultPrice = decimal.Parse(Console.ReadLine());
                var youths = long.Parse(Console.ReadLine());
                var youthsPrice = decimal.Parse(Console.ReadLine());
                var fuelPriceHour = decimal.Parse(Console.ReadLine());
                var fuelConsHour = decimal.Parse(Console.ReadLine());
                var flightDuration = long.Parse(Console.ReadLine());

                var income = (adults * adultPrice) + (youths * youthsPrice);
                var extense = fuelConsHour * fuelPriceHour * flightDuration;
                
                if (income >= extense)
                {
                    Console.WriteLine($"You are ahead with {income - extense:f3}$.");
                }
                else
                {
                    Console.WriteLine($"We've got to sell more tickets! We've lost {income - extense:f3}$.");
                }

                
                overallProfit += income - extense;

            }

            var averageProfit = overallProfit / flights;

            Console.WriteLine($"Overall profit -> {overallProfit:f3}$.");
            Console.WriteLine($"Average profit -> {averageProfit:f3}$.");

        }
    }
}
