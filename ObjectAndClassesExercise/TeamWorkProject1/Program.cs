using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWorkProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfTeams = int.Parse(Console.ReadLine());

            var teamDict = new Dictionary<string, Team>();

            var members = new List<string>();

            var teamNamesAndCreator = new Dictionary<string, string>();

            

            for (int i = 0; i < countOfTeams; i++)
            {
                var inputTeams = Console.ReadLine().Trim().Split('-').ToList();

                var creator = inputTeams[0];
                var name = inputTeams[1];

                var team = new Team(name, creator, members);
                teamDict[name] = team;

                if (!teamNamesAndCreator.ContainsKey(inputTeams[0])
                    && !teamNamesAndCreator.ContainsKey(inputTeams[1]))
                {
                    teamNamesAndCreator[inputTeams[1]] = inputTeams[0];

                    Console.WriteLine($"Team {inputTeams[1]} has been created by {inputTeams[0]}!");
                }
                else if (teamNamesAndCreator.ContainsKey(inputTeams[0]))
                {
                    Console.WriteLine($"Team {inputTeams[0]} was already created!");
                }
                else if (teamNamesAndCreator.ContainsKey(inputTeams[1]))
                {
                    Console.WriteLine($"{inputTeams[1]} cannot create another team");
                }

            }

            var inputM = Console.ReadLine().Trim();

            while (inputM != "end of assignment")
            {
                var inputMembers = inputM.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var member = inputMembers[0];
                var teamName = inputMembers[1];

                if (!teamDict.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else
                {
                    teamDict[teamName].Members.Add(member);
                }

                foreach (var item in teamDict)
                {
                    if (item.Value.Creator.Contains(member))
                    {
                        Console.WriteLine($"Member {member} cannot join team {teamName}");
                        item.Value.Members.Remove(member);
                        for (int i = 0; i < item.Value.Members.Count; i++)
                        {
                            if (item.Value.Members[i] == member)
                            {
                                item.Value.Members.Remove(item.Value.Members[i]);
                            }
                            
                            Console.WriteLine(item.Value.Members[i]);
                        }    
                    }
                }

                inputM = Console.ReadLine().Trim();
            }

            foreach (var item in teamDict)
            {
                if (item.Value.Members.Count > 0)
                {
                    Console.WriteLine(item.Key);
                    Console.WriteLine($"- {item.Value.Creator}");
                    for (int i = 0; i < item.Value.Members.Count; i++)
                    {
                        Console.WriteLine($"-- {item.Value.Members[i]}");
                    }
                }
            }

            foreach (var item in teamDict)
            {
                if (item.Value.Members.Count == 0)
                {
                    Console.WriteLine("Teams to disband:");
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
