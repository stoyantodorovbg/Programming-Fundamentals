using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Trim(' ')
                .ToLower()
                .Split(new char[] {' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var uniqueValue = new HashSet<string>();

            for (int i = 0; i < text.Count; i++)
            {
                if (text[i].Length < 5)
                {
                    uniqueValue.Add(text[i]);
                }
            }
            var result = new List<string>();

            foreach (var item in uniqueValue)
            {
                result.Add(item);
            }

            result.Sort();
            Console.Write(string.Join(", ", result));
         
        }
    }
}
