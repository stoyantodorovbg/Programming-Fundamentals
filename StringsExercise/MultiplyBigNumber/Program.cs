using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim(' ').TrimStart('0');
            var number = int.Parse(Console.ReadLine());
            if (number != 0)
            {

                var bigNumber = new List<int>();

                for (int i = 0; i < input.Length; i++)
                {
                    bigNumber.Add(int.Parse(input[i].ToString()));
                }

                for (int i = 0; i < bigNumber.Count; i++)
                {
                    bigNumber[i] *= number;
                }


                for (int i = bigNumber.Count - 1; i >= 0; i--)
                {
                    if (bigNumber[i] > 9)
                    {
                        var digit = bigNumber[i];
                        var firstDigit = digit / 10;
                        digit %= 10;
                        bigNumber[i] = digit;

                        if (i != 0)
                        {
                            bigNumber[i - 1] += firstDigit;
                        }
                        else
                        {
                            bigNumber.Insert(0, firstDigit);
                        }
                    }
                }

                for (int i = 0; i < bigNumber.Count; i++)
                {
                    Console.Write(bigNumber[i]);
                }
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}

