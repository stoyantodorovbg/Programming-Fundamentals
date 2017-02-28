using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim(' ').Split(' ').ToArray();
            var firstString = input[0];
            var secondString = input[1];

            var firstList = new List<int>();
            var secondList = new List<int>();

            foreach (var item in firstString)
            {
                var numberItem = (int)item;
                firstList.Add(numberItem);

            }

            foreach (var item in secondString)
            {
                var numberItem = (int)item;
                secondList.Add(numberItem);

            }
            
            var minCount = Math.Min(firstList.Count, secondList.Count);
            var maxCount = Math.Max(firstList.Count, secondList.Count);
            var sum = new List<int>();

            for (int i = 0; i < minCount; i++)
            {
                sum.Add(firstList[i] * secondList[i]);
            }

            if (firstList.Count == maxCount)
            {
                for (int i = minCount; i < maxCount; i ++)
                {
                    sum.Add(firstList[i]);
                }
                
            }
            else
            {
                for (int i = minCount; i < maxCount; i++)
                {
                    sum.Add(secondList[i]);
                }
            }

            Console.WriteLine(sum.Sum());
   
        }
    }
}
