using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniKaraoki
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine()
                .Trim(' ')
                .Split(',')
                .ToList();
            //Console.WriteLine(participants.Count);
            for (int i = 0; i < participants.Count; i++)
            {
                participants[i] = participants[i].Trim(' ');
                //Console.WriteLine(participants[i]);
            }

            var songs = Console.ReadLine()
                 .Trim(' ')
                 .Split(',')
                 .ToList();
            //Console.WriteLine(songs.Count);
            for (int i = 0; i < songs.Count; i++)
            {
                songs[i] = songs[i].Trim(' ');
                //Console.WriteLine(songs[i]);
            }

            var result = new List<Dictionary<string, Dictionary<string, string>>>();
            var partSinger = new Dictionary<string, Dictionary<string, string>>();


            var singer = Console.ReadLine();

            var singerList = new List<string>();


            while (singer != "dawn")
            {

                singerList = singer.Trim(' ', ' ')
                       .Split(',')
                       .ToList();
                //Console.WriteLine(singerList.Count);
                for (int i = 0; i < singerList.Count; i++)
                {
                    singerList[i] = singerList[i].Trim(' ');
                    //Console.WriteLine(singerList[i]);
                }

                var participant = singerList[0];
                var song = singerList[1];
                var award = singerList[2];

                if (participants.Contains(participant) && songs.Contains(song))
                {
                    
                    var partSong = new Dictionary<string, string>();

                    partSong[song] = award;

                    partSinger[participant] = partSong;

                    result.Add(partSinger);

                }

                singer = Console.ReadLine();
            }

            var awards = 0;

            var countAwards = new Dictionary<string, int>();

            for (int i = 0; i < result.Count; i++)
            {
                if (countAwards.ContainsKey(result[i].))
            }
          

            foreach (var item in result)
            {
                awards = item.Value.Count;
                Console.WriteLine($"{item.Key}: {awards} awards");

                for (int i = 0; i < awards; i++)
                {
                    foreach (var ite in item.Value[i])
                    {
                        Console.WriteLine($"--{ite.Value}");
                    }
                   
                }

            }

        }
    }
}
