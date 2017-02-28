using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int countResult = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int e = i; e < input.Length; e++)
                {
                    int check = Math.Abs(input[i] - input[e]);
           
                    if (check == difference)
                    {
                        countResult++;
                    }
                }
            }
            
            Console.WriteLine(countResult);
        }
    }
}
