using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(); // get strings
            string[] secondArray = Console.ReadLine().Split();

            int rightSequence = 0;
            int leftSequence = 0;

            while (rightSequence < firstArray.Length && rightSequence < secondArray.Length)
            {
                if (firstArray[firstArray.Length - rightSequence - 1] ==
                    secondArray[secondArray.Length - rightSequence - 1])
                {
                    rightSequence++;
                }
                else break;
            }

            while (leftSequence < firstArray.Length && leftSequence < secondArray.Length)
            {
                if (firstArray[leftSequence] == secondArray[leftSequence])
                {
                    leftSequence++;
                }

                else
                {
                    break;
                }
            }

            if (rightSequence > leftSequence)
            {
                Console.WriteLine(rightSequence);
            }

            else
            {
                Console.WriteLine(leftSequence);
            }
        }
    }
}