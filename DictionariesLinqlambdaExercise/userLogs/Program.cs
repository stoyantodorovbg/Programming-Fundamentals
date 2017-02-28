using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('=', ' ').ToList(); // get data

            var usersIpEntries = new SortedDictionary<string, Dictionary<string, int>>();

            while (input[0] != "end") // check for end comand
            {

                var iP = input[1]; // find data
                var user = input[input.Count - 1];


                if (!usersIpEntries.ContainsKey(user)) // order data
                {
                    usersIpEntries[user] = (new Dictionary<string, int>());
                }

                if (!usersIpEntries[user].ContainsKey(iP))
                {
                    usersIpEntries[user].Add(iP, 1);
                }
                else
                {
                    usersIpEntries[user][iP]++;
                }

                input = Console.ReadLine().Split('=', ' ').ToList(); //get new data
            }


            foreach (var user in usersIpEntries) //print result
            {
                Console.WriteLine();
                Console.WriteLine(user.Key + ":");
                var result = new List<string>();

                foreach (var iP in user.Value)
                {
                    
                    result.Add($"{iP.Key} => {iP.Value.ToString()}");
             
                }
                Console.Write(String.Join(", ", result));
                Console.Write(".");
            }
        }
    }
}
