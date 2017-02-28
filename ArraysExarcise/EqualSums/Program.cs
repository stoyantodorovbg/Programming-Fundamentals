
namespace EqualSums
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int previousElement = 0;
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int curentElement = input[i];
                sum += curentElement;
            }

            bool check = false;
            for (int i = 0; i < input.Length; i++)
            {
                int curentElement = input[i];
                previousElement += curentElement;

                if ((sum - previousElement) == previousElement - curentElement)
                {
                    check = true;
                    Console.WriteLine(i);
                }

                

            }

            if (check == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
