using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace footbalStanding
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            key = Regex.Escape(key);
            var regex = new Regex($@"{key}(.*?){key}.+?{key}(.*?){key}.+?(\d+):(\d+)");

            var standingByPoints = new Dictionary<string, int>();
            var standingByGoals = new Dictionary<string, long>();

            while (true)
            {
                var text = Console.ReadLine();

                if (text == "final")
                {
                    break;
                }

                var match = regex.Match(text);

                var first = new string (match.Groups[1].Value.Reverse().ToArray()).ToUpper();
                var second = new string(match.Groups[2].Value.Reverse().ToArray()).ToUpper();
                var resultF = int.Parse(match.Groups[3].Value);
                var resultS = int.Parse(match.Groups[4].Value);

                if (resultF > resultS)
                {
                    if (!standingByPoints.ContainsKey(first))
                    {
                        standingByPoints[first] = 0;
                    }
                    standingByPoints[first] += 3;
                }
                else if (resultF == resultS)
                {
                    if (!standingByPoints.ContainsKey(first))
                    {
                        standingByPoints[first] = 0;
                    }
                    standingByPoints[first] += 1;

                    if (!standingByPoints.ContainsKey(second))
                    {
                        standingByPoints[second] = 0;
                    }
                    standingByPoints[second] += 1;
                }
                else
                {
                    if (!standingByPoints.ContainsKey(second))
                    {
                        standingByPoints[second] = 0;
                    }
                    standingByPoints[second] += 3;
                }

                if (!standingByPoints.ContainsKey(second))
                {
                    standingByPoints[second] = 0;
                }

                if (!standingByPoints.ContainsKey(first))
                {
                    standingByPoints[first] = 0;
                }

                if (!standingByGoals.ContainsKey(first))
                {
                    standingByGoals[first] = 0;
                }
                standingByGoals[first] += resultF;

                if (!standingByGoals.ContainsKey(second))
                {
                    standingByGoals[second] = 0;
                }
                standingByGoals[second] += resultS;

            }
            Console.WriteLine("League standings:");

            var number = 1;
            foreach (var item in standingByPoints.OrderByDescending(t => t.Value).ThenBy(t => t.Key))
            {
                Console.WriteLine($"{number}. {item.Key} {item.Value}");
                number++;
            }
            Console.WriteLine("Top 3 scored goals:");

            var counter = 0;

            foreach (var item in standingByGoals.OrderByDescending(t => t.Value).ThenBy(t => t.Key))
            {
                Console.WriteLine($"- {item.Key} -> {item.Value}");
                counter++;

                if(counter == 3)
                {
                    break;
                }
            }


        }
    }
}
