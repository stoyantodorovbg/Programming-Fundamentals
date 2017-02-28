using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArrayString = (Console.ReadLine()).Split(' '); //get numbers

            int[] inputArrayInt = new int[inputArrayString.Length];

            for (int i = 0; i < inputArrayString.Length; i ++) // convert string arrey to int array
            {
                string curentNumberString = inputArrayString[i];
                int curentNumberInt = int.Parse(curentNumberString);
                inputArrayInt[i] = curentNumberInt;
                   
            }

            int firstPart = inputArrayInt.Length / 4; // find the parts of array
            int secondPart = inputArrayInt.Length / 2;
            int thirdPart = inputArrayInt.Length / 4;

            int[] firstPartArray = new int[firstPart];
            int[] thirdPartArray = new int[thirdPart];

            int j = 0;
            for (int i = firstPart - 1; i >= 0; i--)
            {
                int number = inputArrayInt[i];
                firstPartArray[j] = number;
                j++;
            }

            int k = 0;
            for (int i = inputArrayInt.Length -1; i >= inputArrayInt.Length - thirdPart; i--)
            {
                int number = inputArrayInt[i];
                thirdPartArray[k] = number;
                k++;
            }


            for (int i = 0; i < firstPartArray.Length; i++) // sum arrays
            {
                firstPartArray[i] += inputArrayInt[firstPart];
                firstPart++;
            }

            for (int i = 0; i < thirdPartArray.Length; i++)
            {
                thirdPartArray[i] += inputArrayInt[firstPart];
                firstPart++;    
            }


            for (int i = 0; i < firstPartArray.Length; i++) //print result
            {
                Console.Write($"{firstPartArray[i]} ");
            }

            for (int i = 0; i < thirdPartArray.Length; i++)
            {
                Console.Write($"{thirdPartArray[i]} ");
            }

        }
    }
}
