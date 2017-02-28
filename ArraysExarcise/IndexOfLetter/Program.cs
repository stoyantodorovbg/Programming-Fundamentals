using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabetString = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
            string alphabetLower = alphabetString.ToLower();
            string[] alphabetArray = new string[alphabetString.Length];

            alphabetArray = alphabetLower.Split(new char[] { ' ' });
            char[] alphabetArrayChar = new char[alphabetArray.Length];

            for (int i = 0; i < alphabetArrayChar.Length; i++)
            {
                string curentString = alphabetArray[i];
                char curentChar = char.Parse(curentString);
                alphabetArrayChar[i] = curentChar; 
            }
            string input = Console.ReadLine();

            var result = new StringBuilder();
            for (int i = 0; i < input.Length; i ++)
            {
                char curentLetter = input[i];
                 
                for (int e = 0; e < alphabetArrayChar.Length; e++)
                {
                    if (curentLetter == alphabetArrayChar[e])
                    {
                        result.Append($"{curentLetter} -> {e} \n");
                    }
                }
            }

            Console.WriteLine(result);

        }
    }
}
