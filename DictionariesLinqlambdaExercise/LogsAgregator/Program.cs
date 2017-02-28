using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAgregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int logsNumber = int.Parse(Console.ReadLine());
            var usersLogsCount = new SortedDictionary<string, int>();
            var usersIp = new SortedDictionary<string, HashSet<string>>();

            for (int i = 0; i < logsNumber; i ++)
            {
                var input = Console.ReadLine()
                    .Split(' ')
                    .ToList();

                if (!usersLogsCount.ContainsKey(input[1]))
                {
                    usersLogsCount[input[1]] = int.Parse(input[2]);
                }
                else
                {
                    usersLogsCount[input[1]] += int.Parse(input[2]);
                }

                var iP = new HashSet<string>();

                iP.Add(input[0]);

                if (!usersIp.ContainsKey(input[1]))
                {
                    usersIp[input[1]] = iP;
                }
                else
                {
                    foreach (var item in usersIp)
                    {
                        if (item.Key == input[1])
                        {
                            item.Value.Add(input[0]);
                        }
                    }
                }

            }

            foreach (var item in usersLogsCount)
            {
                var name = item.Key;
                Console.Write($"{item.Key}: {item.Value} [");
                foreach (var iPs in usersIp)
                {
                    if (iPs.Key == name)
                    {
                        var sorted = new List<string>();
                        sorted.AddRange(iPs.Value);
                        sorted.Sort();
                        Console.Write(string.Join(", ", sorted));
                    }
                }
                Console.Write(']');
                Console.WriteLine();
            }

        }
    }
}
