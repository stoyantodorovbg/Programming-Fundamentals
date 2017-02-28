using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers1
{
    class Program
    {
        static void Main(string[] args)
        {
            var area = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var bombAndRange = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int bombValue = bombAndRange[0];
            int rangeValue = bombAndRange[1];

            //var newArea = 
                area
                .FindAll(x => x == bombValue)
                .Select(x => x = 0);

            area.ForEach(Console.WriteLine);

          
                
        }
    }
}
