using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            foreach (var ticket in input)
            {
                var leftPart = new string(ticket.Take(10).ToArray());
                var rightPart = new string(ticket.Skip(10).ToArray());

                var pattern = @"(@|\$|\^|\#){6,10}";
                var regex = new Regex(pattern);

                var matchLeft = regex.Match(leftPart).ToString();
                var matchRight = regex.Match(rightPart).ToString();
                var win = Math.Min(matchLeft.Length, matchRight.Length);
                
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else if (matchLeft.Length < 6 || matchRight.Length < 6)
                {
                    Console.WriteLine($@"ticket ""{ticket}"" - no match");
                }
                else if (matchLeft.Length == 10 && matchRight.Length == 10 && matchLeft[0] == matchRight[0])
                {
                    Console.WriteLine($@"ticket ""{ticket}"" - {matchLeft.Length}{matchLeft[0]} Jackpot!");
                }
                else if (matchLeft.Length >= 6 && matchRight.Length >= 6 && matchLeft[0] == matchRight[0])
                {
                    Console.WriteLine($@"ticket ""{ticket}"" - {win}{matchLeft[0]}");
                }
            }

        }
    }
}
