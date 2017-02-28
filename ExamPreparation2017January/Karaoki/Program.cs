
namespace Karaoki
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var participants = Console.ReadLine()
                .Trim(' ')
                .Split(',')
                .ToList();
            
            for (int i = 0; i < participants.Count; i++)
            {
                participants[i] = participants[i].Trim(' ');
            }

            var songs = Console.ReadLine()
                 .Trim(' ')
                 .Split(',')
                 .ToList();
            
            for (int i = 0; i < songs.Count; i++)
            {
                songs[i] = songs[i].Trim(' ');
              
            }

            var input = Console.ReadLine();

            var result = new Dictionary<string, List<Participant>>();

            while (input != "dawn")
            {
                var singerList = new List<string>();
                singerList = input.Trim(' ', ' ')
                       .Split(',')
                       .ToList();

                for (int i = 0; i < singerList.Count; i++)
                {
                    singerList[i] = singerList[i].Trim(' ');
                  
                }

                var singer = singerList[0];
                var song = singerList[1];
                var award = singerList[2];

                var participant = new Participant(singer, song, award);

                var participentList = new List<Participant>();
                participentList.Add(participant);

                if (participants.Contains(singer) && songs.Contains(song))
                {
                    if (!result.ContainsKey(singer))
                    {
                        result[singer] = participentList;
                    }
                    else
                    {
                        result[singer].AddRange(participentList);
                    }

                }

                input = Console.ReadLine();
            }

            foreach (var item in result)
            {
                var singerAward = new List <Dictionary<string, string>>();
                for (int i = 0; i < item.Value.Count; i++)
                {
                    var awardes = new Dictionary<string, string>();
                    awardes[item.Key] = item.Value[i].Award;
                    singerAward[i] = awardes;
                }
                var countAwards = 0;
        
                for (int i = 0; i < item.Value.Count; i++)
                {
                    if (singerAward[i][item.Key] != item.Value[i].Award)
                    {
                        countAwards++;
                    }
                }
                
                Console.WriteLine($"{item.Key}: {countAwards} awards");

                  for (int i = 0; i < singerAward.Count; i++)
                    {
                        Console.WriteLine($"--{singerAward[i][item.Key]}");

                    }
               
            }
        }
    }
}
