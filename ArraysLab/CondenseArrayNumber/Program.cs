using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int countCondensingArrLength = input.Length - 1;

            for (int a = input.Length - 1; a >= 0; a++)
            {
                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (i <= countCondensingArrLength - 1)

                        input[i] += input[i + 1];
                }

                countCondensingArrLength--;

                if (countCondensingArrLength < 0)
                {
                    break;
                }

            }

            Console.WriteLine(input[0]);    
        }
    }
}

