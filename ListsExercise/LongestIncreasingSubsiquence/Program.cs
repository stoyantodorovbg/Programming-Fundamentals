using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSubsiquence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var allIncreaseElement = new List<int>();
            int last = input[0];
            //input.Add(int.MaxValue);

            for (int i = 1; i < input.Count; i++)
            {
                int curent = input[i];

                if (curent > last)
                {
                    allIncreaseElement.Add(input[i]);
                }
            }

            var sequences = new Dictionary<string, int>();

            last = allIncreaseElement[0];
            //allIncreaseElement.Add(int.MaxValue);
            int count = 0;
            string name = "1";

            for (int i = 1; i < allIncreaseElement.Count;  i++)
            {
                int curent = allIncreaseElement[i];

                if (curent > last)
                {
                    count++;
                    name += string.Join(" ", allIncreaseElement[i]);

                }
                if (!(curent > last))
                {
                    sequences[name] = count;
                    count = 0;
                    name = "1";
                }
                last = curent;
            }

            var stringNamesToInt = new List<long>();

            foreach (var item in sequences)
            {
                string keyString = item.Key;
                Console.WriteLine(keyString);
                keyString.Replace(" ", string.Empty);

                long keyInt = long.Parse(keyString);

                stringNamesToInt.Add(keyInt);
                stringNamesToInt.ForEach(Console.WriteLine);
            }
        }
    }
}
