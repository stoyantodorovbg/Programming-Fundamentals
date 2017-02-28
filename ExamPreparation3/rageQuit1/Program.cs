namespace rageQuit1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToUpper();

            var stringAndNumberRegex = new Regex(@"([^\d]+)(\d+)"); // find couples string-number
            var machesStringAndNumber = stringAndNumberRegex.Matches(input);

            //separate the the word and number


            var wordsList = new List<string>();
            var numbersList = new List<int>();
            var uniqueTokenCount = new HashSet<char>();

            foreach (Match couples in machesStringAndNumber)
            {
                var wordSb = new StringBuilder();
                var numberSb = new StringBuilder();
                var couple = couples.ToString();
                for (int i = 0; i < couple.Length; i++)
                {
                    var token = couple[i];
                    if (!char.IsDigit(token))
                    {
                        wordSb.Append(token);
                        uniqueTokenCount.Add(token);
                    }
                    else
                    {
                        numberSb.Append(token);
                    }

                }
                var word = wordSb.ToString();
                wordsList.Add(word);
                var number = int.Parse(numberSb.ToString());
                numbersList.Add(number);
            }

            var uniqueTokenCounter = 0; //count unique tokens

            foreach (var token in uniqueTokenCount)
            {
                uniqueTokenCounter++;
            }

            //print result

            Console.WriteLine($"Unique symbols used: {uniqueTokenCounter}");

            for (int i = 0; i < wordsList.Count; i++)
            {
                for (int e = 0; e < numbersList[i]; e++)
                {
                    Console.Write(wordsList[i]);
                }
            }


        }
    }
}