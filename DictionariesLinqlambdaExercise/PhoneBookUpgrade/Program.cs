using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputComands = Console.ReadLine().Split(' ').ToList();

            var repository = new SortedDictionary<string, string>();

            while (inputComands[0] != "END")
            {
                if (inputComands[0] == "A")
                {
                    repository[inputComands[1]] = inputComands[2];
                }
                else if (inputComands[0] == "ListAll")
                {
                    foreach (var item in repository)
                    {
                       
                        Console.Write($"{item.Key} -> {item.Value}");
                    }
                }
                else
                {
                    bool check = repository.ContainsKey(inputComands[1]);

                    if (check)
                    {
                        
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write($"Contact {inputComands[1]} does not exist.");
                    }
                }

                inputComands = Console.ReadLine()
               .Split(' ')
               .ToList();

            }

        }
    }
}
