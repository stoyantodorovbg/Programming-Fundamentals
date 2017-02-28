using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            string[] splitFirstString = firstString.Split(' ');
            string[] splitSecondString = secondString.Split(' ');


            int stringLengthMin = Math.Min(splitFirstString.Length, splitSecondString.Length);
            bool firstStringPriority = false;
            bool secondStringPriority = false;

            for (int i = 0; i < stringLengthMin; i ++)
            {

                string firstStringCurrentChar = splitFirstString[i];
                char charCurrentFirstString = char.Parse(firstStringCurrentChar);

                string secondStringCurrentChar = splitSecondString[i];
                char charCurrentSecondString = char.Parse(secondStringCurrentChar);

                if (charCurrentFirstString < charCurrentSecondString)
                {
                    firstStringPriority = true;
                    break;
                }
                else if (charCurrentFirstString > charCurrentSecondString)
                {
                    secondStringPriority = true;
                    break;
                }

            }

            if (firstStringPriority == false && secondStringPriority == false)
            {
                if (splitFirstString.Length <= splitSecondString.Length)
                {
                    firstStringPriority = true;
                }
                if (splitFirstString.Length > splitSecondString.Length)
                {
                    secondStringPriority = true;
                }
            }

            Console.WriteLine();

            if (firstStringPriority)
            {
                for (int i = 0; i < splitFirstString.Length; i++)
                {
                    Console.Write($"{splitFirstString[i]}");
                }

                Console.WriteLine();

                for (int i = 0; i < splitSecondString.Length; i++)
                {
                    Console.Write($"{splitSecondString[i]}");
                }
                

            }

            else
            {
                for (int i = 0; i < splitSecondString.Length; i++)
                {
                    Console.Write($"{splitSecondString[i]}");
                }

                Console.WriteLine();

                for (int i = 0; i < splitFirstString.Length; i++)
                {
                    Console.Write($"{splitFirstString[i]}");
                }
            }
        }
    }
}
