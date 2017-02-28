using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            var drivers = Console.ReadLine()
                .Trim(' ')
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var zonesFuel = Console.ReadLine()
                .Trim(' ')
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToArray();
            var checkPointIndexes = Console.ReadLine()
                .Trim(' ')
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).Select(x => Math.Abs(x)).ToArray();

            if (drivers.Length == 0)
            {
                Console.WriteLine(" - reached 0");
            }

            var driversFuelSave = new Dictionary<string, decimal>();
            var driversFuel = new Dictionary<string, decimal>();
            var unfinished = new Dictionary<string, int>();

            for (int i = 0; i < drivers.Length; i++)
            {
                var letter = drivers[i][0];
                var fuel = (int)letter;
                driversFuel[drivers[i]] = fuel;
                driversFuelSave[drivers[i]] = fuel;

            }

            for (int i = 0; i < zonesFuel.Length; i++)
            {
                foreach (var driver in driversFuel)
                {
                    if (checkPointIndexes.Contains(i) && driversFuelSave.ContainsKey(driver.Key))
                    {

                        var fuel = driversFuelSave[driver.Key];
                        var outlay = zonesFuel[i];
                        driversFuelSave[driver.Key] = fuel + outlay;

                    }
                    else if (!checkPointIndexes.Contains(i) && driversFuelSave.ContainsKey(driver.Key))
                    {

                        var fuel = driversFuelSave[driver.Key];
                        var outlay = zonesFuel[i];
                        driversFuelSave[driver.Key] = fuel - outlay;

                    }

                    if (driversFuelSave.ContainsKey(driver.Key))
                    {
                        if (driversFuelSave[driver.Key] <= 0)
                        {
                            unfinished[driver.Key] = i;
                            driversFuelSave.Remove(driver.Key);
                        }
                    }
                }
            }

                foreach (var driver in driversFuel)
                {
                    if (unfinished.ContainsKey(driver.Key))
                    {
                        driversFuelSave[driver.Key] = unfinished[driver.Key];
                    }
                }

                foreach (var driver in driversFuelSave)
                { 
                    if (!unfinished.ContainsKey(driver.Key))
                    {
                        Console.WriteLine($"{driver.Key} - fuel left {driver.Value:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"{driver.Key} - reached {driver.Value}");
                    }
                }
            }
        }
    }
