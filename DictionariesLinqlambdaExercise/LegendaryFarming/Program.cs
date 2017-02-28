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
            score["fragments"] = 0;
            score["shards"] = 0;
            score["motes"] = 0;
            int shards = 0;
            int fragments = 0;
            int motes = 0;
            string material = "a";
            int quentity = 0;
            while (input[0] != "")
            {
                for (int i = 0; i < input.Count; i++) //writes data in dictionary
                {

                    if (i % 2 != 0)
                    {
                        material = input[i];
                    }
                    else
                    {
                        quentity = int.Parse(input[i]);
                    }

                    if (i % 2 != 0)
                    {
                        if (!score.ContainsKey(material))
                        {
                            score[material] = quentity;
                        }
                        else
                        {
                            score[material] += quentity;
                        }

                    }

                    if (i % 2 == 0)
                    {
                        //quentity = 0;
                        material = "a";
                    }

                    if (material == "fragments")
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
                    if (shards >= 250 || fragments >= 250 || motes >= 250)
                    {
                        break; //checks from win
                    }

                }
                if (shards >= 250 || fragments >= 250 || motes >= 250)
                {
                    break; //checks from win
                }

                input = Console.ReadLine() //gets data
                .ToLower()
                .Split(' ')
                .ToList();
            }

            var keyMaterials = new Dictionary<string, int>(); //sorts results 
          
            if (score.ContainsKey("shards"))
            {
                shards = score["shards"];
                keyMaterials["shards"] = shards;
                score.Remove("shards");
            }

            if (score.ContainsKey("fragments"))
            {
                fragments = score["fragments"];
                keyMaterials["fragments"] = fragments;
                score.Remove("fragments");
            }

            if (score.ContainsKey("motes"))
            {
                motes = score["motes"];
                keyMaterials["motes"] = motes;
                score.Remove("motes");
            }
           
            
            var max = keyMaterials.FirstOrDefault(x => x.Value == keyMaterials.Values.Max()).Key;
            switch (max)
            {

                case "fragments":
                    Console.WriteLine("Valanyr obtained!"); // prints results
                    keyMaterials["fragments"] -= 250;
                    break;
                case "shards":
                    Console.WriteLine("Shadowmourne obtained!");
                    keyMaterials["shards"] -= 250;
                    break;
                case "motes":
                    Console.WriteLine("Dragonwrath obtained!");
                    keyMaterials["motes"] -= 250;
                    break;
            }

            foreach (var item in keyMaterials.OrderByDescending(n => n.Value).ThenBy(n => n.Key))
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
