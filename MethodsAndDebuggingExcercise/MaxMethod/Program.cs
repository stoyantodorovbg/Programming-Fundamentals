using System;


namespace MaxMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());  // get numbers
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int biggerNumber = GetMax(firstNumber, secondNumber);
            int biggestNumber = GetMax(biggerNumber, thirdNumber);

            Console.WriteLine(biggestNumber); // print result
        }

        static int GetMax(int firstNumber, int secondNumber)  //calculate max value
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }

    }
}
