using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollyTheCodder
{
    class Program
    {
        static void Main(string[] args)
        {
            var events = new Dictionary<string, List<string>>();
            var idName = new Dictionary<string, string>();

            while(true)
            {
                var input = Console.ReadLine();
                if (input == "Time for Code")
                {
                    break;
                }

                if (input.Contains('#'))
                {
                    var inputArray = input.Split(new[] { '#', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => i.Trim(' ')).ToArray();

                    var id = inputArray[0];
                    var evenT = inputArray[1];

                    var participants = new List<string>();

                    for (int i = 2; i < inputArray.Length; i++)
                    {
                        var participant = inputArray[i];
                        participants.Add(participant);
                    }

                    if (!idName.ContainsKey(id))
                    {
                        idName[id] = evenT;
                        events[evenT] = participants;
                    }
                    else if (idName.ContainsKey(id) && idName[id] == evenT)
                    {
                        events[evenT].AddRange(participants);
                    }
                }
            }
            foreach (var kvp in events)
            {
                kvp.Value.Sort();
            }

            var result = new Dictionary<string, HashSet<string>>();

            foreach (var kvp in events)
            {
                var hashParticipant = new HashSet<string>();

                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    hashParticipant.Add(kvp.Value[i]);
                }

                result[kvp.Key] = hashParticipant;  
            }

            foreach (var kvp in result.OrderByDescending(k => k.Value.Count).ThenBy(k => k.Key))
            { 
                Console.WriteLine($"{kvp.Key} - {kvp.Value.Count}");

                foreach (var item in kvp.Value)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
