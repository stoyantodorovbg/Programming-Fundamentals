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
            var inputString = Console.ReadLine();
            decimal inputInt = 0;

            var repository = new Dictionary<string, decimal>();

            int count = 1;

            while (inputString != "stop")
            {
                count++;

                if (count % 2 == 0)

                {
                    inputInt = int.Parse(Console.ReadLine());

                    if (repository.ContainsKey(inputString))
                    {
                        repository[inputString] += inputInt;
                    }
                    else
                    {
                        repository[inputString] = inputInt;
                    }

                }
              
                count++;

                if (count % 2 != 0)
                {
                    inputString = Console.ReadLine();

                }
            }

            foreach (var item in repository)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}"); 
            }
        }
    }
}

