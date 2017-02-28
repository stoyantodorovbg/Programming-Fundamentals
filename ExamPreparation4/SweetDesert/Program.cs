using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDesert
{
    class Program
    {
        static void Main(string[] args)
        {
            var cash = decimal.Parse(Console.ReadLine());
            var guests = int.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());
            var eggsPrice = decimal.Parse(Console.ReadLine());
            var beriesPrice = decimal.Parse(Console.ReadLine());

            var pricePerPortion = (bananaPrice * 2) + (eggsPrice * 4) + (beriesPrice * 0.2m);

            var countOfPortion = guests / 6;
            if (guests % 6 != 0)
            {
                countOfPortion++;
            }

            var totalPrice = countOfPortion * pricePerPortion;
            var difference = Math.Abs(totalPrice - cash);

            if (cash >= totalPrice)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:f2}lv.");
            }
            else if(cash < totalPrice)
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {difference:f2}lv more.");
            }
        }
    }
}


