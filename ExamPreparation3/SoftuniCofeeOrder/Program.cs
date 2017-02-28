using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniCofeeOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var order  = int.Parse(Console.ReadLine());
            var sum = 0m;
            for (int i = 0; i < order; i++)
            {
                var priceperCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsulesTime = int.Parse(Console.ReadLine());

                var month = orderDate.Month;
                var year = orderDate.Year;
                var days = System.DateTime.DaysInMonth(year, month);

                var price = priceperCapsule * days * capsulesTime;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                sum += price;

            }
            Console.WriteLine($"Total: ${sum:f2}");
        }
    }
}

