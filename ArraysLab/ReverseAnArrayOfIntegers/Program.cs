using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLength = int.Parse(Console.ReadLine());

            var arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                int number = int.Parse(Console.ReadLine());
                arr[i] = number;
            }
            int index = 0;
            var reverseArr = new int[arr.Length];

            for (int i = reverseArr.Length - 1; i >= 0; i--)
            {
                reverseArr[i] = arr[index];
                index++;
            }

            for (int i = 0; i < reverseArr.Length; i++)
            {
                Console.Write($"{reverseArr[i]} ");
            }
        }
    }
}
