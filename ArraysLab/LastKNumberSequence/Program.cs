using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            n = Math.Abs(n);
            
          

           long[] arr = new long[n];

            arr[0] = 1;
            if (n > 1)
            {
                arr[1] = 1;
            }
            


            for (int i = 2; i < n; i++)
            {
                for (int b = 0; b <= k; b++)
                {
                    if (b <= i)
                    {
                        arr[i] += arr[i - b];
                       
                    }
                }
                
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            
        }
    }
}
