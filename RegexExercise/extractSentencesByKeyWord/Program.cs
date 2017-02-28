using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace extractSentencesByKeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine()
                .Trim(' ').Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var pattern = "\\b" + word + "\\b";
            Regex regex = new Regex(pattern);

            foreach (var item in text)
            {
                if (regex.IsMatch(item))
                {
                    Console.WriteLine(item.Trim(' '));
                }
            }
        }
    }
}
