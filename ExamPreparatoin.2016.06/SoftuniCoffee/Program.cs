using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoftuniCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            var keys = Console.ReadLine().Split(' ').ToArray();
            var nameType = new Dictionary<string, string>();
            var typeQuentity = new Dictionary<string, int>();
            var nameQuentityConsume = new Dictionary<string, int>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end of info")
                {
                    break;
                }

                var personalKey = keys[0];
                var typeKe = keys[1];
                personalKey = Regex.Escape(personalKey);
                typeKe = Regex.Escape(typeKe);

                var persReg = new Regex($"{personalKey}");
                var typeReg = new Regex($"{typeKe}");


                if (persReg.IsMatch(input))
                {
                    var regex = new Regex($"(.*){personalKey}(.*)");

                    var name = regex.Match(input).Groups[1].Value;
                    var type = regex.Match(input).Groups[2].Value;

                    nameType[name] = type;

                }
                else if (typeReg.IsMatch(input))
                {
                    var regex = new Regex($"(.*){typeKe}(.*)");

                    var type = regex.Match(input).Groups[1].Value;
                    var quentity = regex.Match(input).Groups[2].Value;

                    if (!typeQuentity.ContainsKey(type))
                    {
                        typeQuentity[type] = int.Parse(quentity);
                    }
                    else
                    {
                        typeQuentity[type] += int.Parse(quentity);
                    } 
                }
            }

            foreach (var name in nameType)
            {
                if (!typeQuentity.ContainsKey(name.Value))
                {
                    typeQuentity[name.Value] = 0;
                }
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end of week")
                {
                    break;
                }

                var inputArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var name = inputArr[0];
                var quentity = int.Parse(inputArr[1]);

                if (!nameQuentityConsume.ContainsKey(name))
                {
                    nameQuentityConsume[name] = quentity;
                }
                else
                {
                    nameQuentityConsume[name] += quentity;
                }
                var chechShortag = false;
                var typeKe = "";
                foreach (var type in typeQuentity)
                {
                    if (type.Value <= 0)
                    {
                        Console.WriteLine($"Out of {type.Key}");
                        chechShortag = true;
                        typeKe = type.Key;
                    }
                }
                if (chechShortag)
                {
                    typeQuentity.Remove(typeKe);
                }

            }

            foreach (var names in nameType)
            {
                foreach (var nam in nameQuentityConsume)
                {
                    if (names.Key == nam.Key)
                    {
                        
                            typeQuentity[names.Value] -= nam.Value;
                      
                    }
                }
            }
            var chechShortage = false;
            var typeKey = "";
            foreach (var type in typeQuentity)
            {
                if (type.Value <= 0)
                {
                    Console.WriteLine($"Out of {type.Key}");
                    chechShortage = true;
                    typeKey = type.Key;
                }
            }
            if (chechShortage)
            {
                typeQuentity.Remove(typeKey);
            }

            Console.WriteLine("Coffee Left:");

            foreach(var type in typeQuentity.OrderByDescending(t => t.Value))
            {
                
                    Console.WriteLine($"{type.Key} {type.Value}");
                
                    
            }

            Console.WriteLine("For:");

            foreach (var name in nameType.OrderBy(n => n.Value).ThenByDescending(n => n.Key))
            {
                if (typeQuentity.ContainsKey(name.Value))
                {
                    Console.WriteLine($"{name.Key} {name.Value}");
                }
                    
                
            }

        }
    }
}
