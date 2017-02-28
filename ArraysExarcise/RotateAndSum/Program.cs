using System;

namespace RotateAndSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine(); // get input

            int rotations = int.Parse(Console.ReadLine());

            string[] inputStringMassive = inputString.Split(' '); //remove spaces and convert string to massive

            var inputInt = new int[inputStringMassive.Length]; // convert string to int[]

            for (int i = 0; i <= inputStringMassive.Length - 1; i++)
            {
                int digit = int.Parse(inputStringMassive[i]);
                inputInt[i] = digit;
            }

            var reversedInt = new int[inputInt.Length];  //rotate int[]
            var sum = new int[inputInt.Length];

            for (int r = 0; r < rotations; r++)
            {
                int inputIntI = inputInt.Length - 1;

                for (int i = 0; i < inputInt.Length; i++)
                {
                        reversedInt[i] = inputInt[inputIntI];
                        inputIntI++;

                        if (inputIntI == inputInt.Length) 
                        {
                            inputIntI = 0;
                        }
                }

                for (int i = 0; i < inputInt.Length; i++)  // return the reversed massive for reverse
                {

                    inputInt[i] = reversedInt[i];
                }


                for (int i = 0; i <= inputInt.Length - 1; i++) //sum[]
                {
                    sum[i] += reversedInt[i];
                }
            }

            for (int i = 0; i <= inputInt.Length - 1; i++) // print result
            {
                Console.Write($"{sum[i]} ");
            }

        }
    }
}