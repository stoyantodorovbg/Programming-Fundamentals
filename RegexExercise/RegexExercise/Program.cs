using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"([\w-.]+\@[a-zA-Z-]+)(\.[a-zA-z-]+)+";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            
            foreach(Match match in matches)
            {
                var matchString = match.ToString();

                if (
                    !(matchString.StartsWith("-")
                    || matchString.StartsWith(".")
                    || matchString.StartsWith("_")
                    || matchString.EndsWith("-")
                    || matchString.EndsWith(".")
                    || matchString.EndsWith("_"))
                    )
                {
                    Console.WriteLine(match);
                }
                
            } 
        }
    }
}
