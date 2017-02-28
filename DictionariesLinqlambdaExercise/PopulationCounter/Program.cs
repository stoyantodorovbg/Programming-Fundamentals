using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine() //get input
                .Split('|')
                .ToList();
           
            var countryTownsDict = new Dictionary<string, Dictionary<string, long>>();
            
            while (input[0] != "report") //checked for end
            {

                var town = input[0];  // find data
                var country = input[1];
                long population = long.Parse(input[2]);



                if (!countryTownsDict.ContainsKey(country)) //classify
                {
                    countryTownsDict.Add(country, new Dictionary<string, long>());

                }

                if (!countryTownsDict[country].ContainsKey(town))
                {
                    countryTownsDict[country].Add(town, population);

                }
                else
                {
                    countryTownsDict[country][town] += population;

                }

                input = Console.ReadLine() // get next input
                .Split('|')
                .ToList();
            }
            
            foreach (var country in countryTownsDict.OrderByDescending(n => n.Value.Values.Sum()))  //arrange and print result
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
       
                foreach (var towns in country.Value.OrderByDescending(n => n.Value))
                {
                    Console.WriteLine($"=>{towns.Key}: {towns.Value}");
                           
                }
            }
        }
    }
}
