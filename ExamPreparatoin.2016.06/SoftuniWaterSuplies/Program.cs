using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniWaterSuplies
{
    class Program
    {
        static void Main(string[] args)
        {
            var allWater = decimal.Parse(Console.ReadLine());
            var bottles = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            var capacity = decimal.Parse(Console.ReadLine());

            var filledBottles = 0m;
            var even = false;
            if (allWater % 2 == 0)
            {
                even = true;
                for (int i = 0; i < bottles.Length; i++)
                {
                    if (allWater >= (capacity - bottles[i]))
                    {
                        filledBottles++;
                    }
                    allWater -= (capacity - bottles[i]);
                    
                }
                
            }
            else
            {
                for (int i = bottles.Length - 1; i >= 0;  i--)
                {
                    if (allWater >= (capacity - bottles[i]))
                    {
                        filledBottles++;
                    }
                    allWater -= (capacity - bottles[i]);
                    

                }
            }

            if (filledBottles == bottles.Length)
            {
                Console.WriteLine($"Enough water!");
                Console.WriteLine($"Water left: {allWater}l.");
            }
            else
            {
                Console.WriteLine($"We need more water!");
                Console.WriteLine($"Bottles left: {bottles.Length - filledBottles}");
                if (even)
                {
                    var indexes = new List<int>();
                    for (int i = 0; i < bottles.Length - filledBottles; i++)
                    {
                        indexes.Add((bottles.Length - 1) - i);
                    }
                    indexes.Reverse();

                    Console.WriteLine($"With indexes: {string.Join(", ", indexes)}");

                }
                else
                {
                    var indexes = new List<int>();
                    for (int i = 0; i < bottles.Length - filledBottles; i++)
                    {
                        indexes.Add(i);
                    }
                    indexes.Reverse();

                    Console.WriteLine($"With indexes: {string.Join(", ", indexes)}");
                }

                Console.WriteLine($"We need {Math.Abs(allWater)} more liters!");
            }
        }
    }
}
