using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = 0;
            List<int> reversedNumberList = new List<int>();
            int number = 0;
            int digit = 0;
            int reversedDigitInt = 0;
            int reversedNumberInt = 0;

            for (int i = 0; i < input.Count; i++)
            {
                number = input[i];

                while(number > 0)
                {
                    digit = number % 10;
                    number /= 10;
                    reversedNumberList.Add(digit);
                }
                for (int e = 0; e < reversedNumberList.Count; e++)
                {
                    reversedDigitInt = reversedNumberList[e];
                    for (int k = e; k < reversedNumberList.Count; k++)
                    {
                        reversedDigitInt *= 10; 
                    }
                    reversedDigitInt /= 10;
                    reversedNumberInt += reversedDigitInt;
                    
                }
                sum += reversedNumberInt;
                reversedNumberInt = 0;
                reversedNumberList.RemoveAll(x => x < int.MaxValue);
            }

            Console.WriteLine(sum);
        }
    }
}
