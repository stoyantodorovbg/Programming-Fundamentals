using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine().Trim(' ').TrimStart('0');
            var secondInput = Console.ReadLine().Trim(' ').TrimStart('0'); 

            var minLength = Math.Min(firstInput.Length, secondInput.Length);
            var maxLength = Math.Max(firstInput.Length, secondInput.Length);


            var minList = new List<int>();
            var maxList = new List<int>();

            if (firstInput.Length == minLength)
            {
                for (int i = 0; i < minLength; i++)
                {
                    var digit = int.Parse(firstInput[i].ToString());
                    minList.Add(digit);
                }

                for (int i = 0; i < maxLength; i++)
                {
                    var digit = int.Parse(secondInput[i].ToString());
                    maxList.Add(digit);
                }


            }

            else
            {
                for (int i = 0; i < maxLength; i++)
                {
                    var digit = int.Parse(firstInput[i].ToString());
                    maxList.Add(digit);
                }

                for (int i = 0; i < minLength; i++)
                {
                    var digit = int.Parse(secondInput[i].ToString());
                    minList.Add(digit);
                }
    
            }

            minList.Reverse();
            maxList.Reverse();

            for (int i = 0; i < minLength; i++)
            {
                maxList[i] += minList[i];
            }

            maxList.Reverse();

            for (int i = maxList.Count - 1; i >= 0; i--)
            {
                if (maxList[i] > 9)
                {
                    maxList[i] %= 10;
                    if (i != 0)
                    {
                        maxList[i - 1]++;
                    }
                    else
                    {
                        maxList.Insert(0, 1);
                    }
                }
            }

            maxList.ForEach(Console.Write);

        }
    }
}
