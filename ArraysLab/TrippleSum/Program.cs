using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrippleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var result = false;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    var sum = input[i] + input[j];
                    
                    for (int a = 0; a < input.Length; a++)
                    {
                        if (sum == input[a])
                        {
                            result = true;
                            Console.WriteLine($"{input[i]} + {input[j]} == {input[a]}");
                            break;
                        }
                           
                    }

                }
            }

            if (!result)
            {
                Console.WriteLine("No");
            }
        }
    }
}
