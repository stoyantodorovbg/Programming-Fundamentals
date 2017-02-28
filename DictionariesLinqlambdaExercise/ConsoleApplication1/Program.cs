using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine() //gets data
                .ToLower()
                .Split(' ')
                .ToList();

            var score = new SortedDictionary<string, int>();
            int shards = 0;
            int fragments = 0;
            int motes = 0;

            for (int i = 0; i < input.Count; i++) //writes data in dictionary
            {
                string material = "a";
                int quentity = 0;
                if (material != "a" & quentity != 0)
                {
                    if (!score.ContainsKey(material))
                    {
                        score[material] = quentity;
                    }
                    score[material] += quentity;
                }

                if (i % 2 != 0)
                {
                    material = input[i];
                }
                else
                {
                    quentity = int.Parse(input[i]);
                }

                if (material == "fragents")
                {
                    fragments += quentity;
                }
                if (material == "shards")
                {
                    shards += quentity;
                }
                if (material == "motes")
                {
                    motes += quentity;
                }
                if (shards >= 250 || fragments>= 250 || motes >= 250)
                    {
                        break; //checks from win
                    }
                
            }

            var keyMaterials = new Dictionary<string, int>(); //sorts results 
            foreach (var item in score)
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine();
            //int shards = score["shards"];
            //keyMaterials["shards"] = shards;
            //score.Remove("shards");
            //int fragments = score["fragments"];
           // keyMaterials["fragments"] = fragments;
            //score.Remove("fragments");
            //int motes = score["shards"];
            //keyMaterials["motes"] = motes;
            //score.Remove("motes");

            keyMaterials.OrderBy(n => n.Key).ThenBy(n => n.Key);

            Console.WriteLine($"{score.Max()} obtained!"); // prints results

            foreach (var item in keyMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in score)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }


        }
    }
}
