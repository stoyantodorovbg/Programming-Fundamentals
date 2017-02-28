using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniKaraoki1
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var songs = Console.ReadLine()
                .Split(',')
                .Select(s => s.Trim(' '))
                .ToArray();

            var result = new Dictionary<string, List<string>>();
            var containsPerformance = false;

            while (true)
            {
                var performance = Console.ReadLine()
                .Split(',')
                .Select(s => s.Trim(' '))
                .ToArray();

                if (performance[0] == "dawn")
                {
                    break;
                }

                if (performance[0] != "dawn")
                {
                    containsPerformance = true;
                }

                var participant = performance[0];
                var song = performance[1];
                var award = performance[2];

                var awards = new List<string>();
                awards.Add(award);
               

                if (participants.Contains(participant) && songs.Contains(song))
                {
                    if (!result.ContainsKey(participant))
                    {

                        result[participant] = awards;
                    }
                    else
                    {
                        var contains = false;
                        for (int i = 0; i < result[participant].Count; i++)
                        {
                            if (result[participant][i] == award)
                            {
                                contains = true;
                            }

                        }
                        if (!contains)
                        {
                            result[participant].AddRange(awards);
                        }

                    }

                }
            }

            if (containsPerformance)
            {
                foreach (var item in result.OrderByDescending(i => i.Value.Count).ThenBy(i => i.Key))
                {

                    Console.WriteLine($"{item.Key}: {item.Value.Count} awards");
                     
                    foreach (var award in item.Value.OrderBy(n => n))
                    {
                        Console.WriteLine($"--{award}");
                    }

                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
            
        }
    }
}
