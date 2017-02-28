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
            var inputComands = Console.ReadLine()
                .Split(' ')
                .ToList();

            var repository = new Dictionary<string, string>();

            while (inputComands[0] != "END")
            {
                if (inputComands[0] == "A")
                {
                    repository[inputComands[1]] = inputComands[2];
                }
                else
                {
                    bool check = repository.ContainsKey(inputComands[1]);

                    if (check)
                    {
                        Console.WriteLine();
                        Console.Write($"{inputComands[1]} -> {repository[inputComands[1]]}");
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
