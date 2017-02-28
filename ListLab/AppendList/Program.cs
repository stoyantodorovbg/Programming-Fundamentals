using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendList
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').ToList();
            var part = new List<string>();
            var result = new List<string>();

            for (int i = input.Count - 1; i >= 0; i--)
            {

                part = input[i]
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                
                result.AddRange(part);
              
            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
