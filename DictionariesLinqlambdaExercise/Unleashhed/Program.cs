using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unleashhed
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('@').ToList();
            var venueSingerIncome = new Dictionary<string, Dictionary<string, long>>(); 

            while(input[0] != "End")
            {
                
                var singer = "";
                var singerList = input[0].Split(' ').ToList();
                for (int i = 0; i < singerList.Count; i++)
                {
                    singer += singerList[i];
                    if (i < singerList.Count - 1)
                    {
                        singer += " ";
                    }
                }
                if (singer[singer.Length - 1] == ' ')
                {
                    var secondPart = input[1].Split(' ').ToList();

                    long ticketsCount = long.Parse(secondPart[secondPart.Count - 1]);
                    long ticketsPrice = long.Parse(secondPart[secondPart.Count - 2]);
                    long income = ticketsCount * ticketsPrice;

                    secondPart.Remove(secondPart[secondPart.Count - 1]);
                    secondPart.Remove(secondPart[secondPart.Count - 1]);

                    var venue = "";
                    for (int i = 0; i < secondPart.Count; i++)
                    {
                        venue += secondPart[i];
                        if (i < secondPart.Count - 1)
                        {
                            venue += " ";
                        }
                    }

                    if (!venueSingerIncome.ContainsKey(venue))
                    {
                        venueSingerIncome.Add(venue, new Dictionary<string, long>());
                    }

                    if (!venueSingerIncome[venue].ContainsKey(singer))
                    {
                        venueSingerIncome[venue].Add(singer, income);
                    }
                    else
                    {
                        venueSingerIncome[venue][singer] += income;
                    }
                }

                input = Console.ReadLine().Split('@').ToList();
            }

            foreach (KeyValuePair<string, Dictionary<string, long>> venues in venueSingerIncome)
            {
                Console.WriteLine($"{venues.Key}");

                foreach (var singers in venues.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singers.Key}-> {singers.Value}");
                }
            }
        }
    }
}
