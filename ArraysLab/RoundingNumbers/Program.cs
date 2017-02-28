using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for (int i = 0; i < input.Length; i++)
            {
                var rounded = Math.Abs(input[i]) + 0.5;
                var roundedArr = rounded.ToString().Split('.').ToArray();
                
                if (input[i] < 0)
                {
                    Console.WriteLine($"{input[i]} => -{roundedArr[0]}");
                }
                else
                {
                    Console.WriteLine($"{input[i]} => {roundedArr[0]}");
                }
                
            }
        }
    }
}
