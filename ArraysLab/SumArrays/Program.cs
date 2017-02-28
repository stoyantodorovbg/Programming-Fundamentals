using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var inputTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var maxLength = Math.Max(inputOne.Length, inputTwo.Length);
            var minLength = Math.Min(inputOne.Length, inputTwo.Length);

            var sum = new int[maxLength];
            var e = 0;
            int counter = 0;

            while (e <= minLength)
            {
                
                if (inputOne.Length > inputTwo.Length)
                {
                    sum[counter] = inputOne[counter] + inputTwo[e];
                }
                else if (inputOne.Length < inputTwo.Length)
                {
                    sum[counter] = inputOne[e] + inputTwo[counter];
                }
                else if (inputOne.Length == inputTwo.Length)
                {
                    sum[counter] = inputOne[counter] + inputTwo[counter];
                }

                e++;
                if (e == minLength)
                {
                    e = 0;
                }
                counter++;
                if (counter == maxLength)
                {
                    break;
                }
            }



            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write($"{sum[i]} ");
            }
        }
    }
}
