using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var inputCount = input.Count;

            var first = input.Take(inputCount / 4).ToList();
            var last = input.Skip((inputCount / 4) * 3).ToList();
            //;
            first.Reverse();
            last.Reverse();
            first.AddRange(last);
            first.ForEach(Console.WriteLine);

            for (int i = (inputCount / 4) * 3; i < inputCount; i++)
            {
                input.Remove(i);
            }

            var inputCountPoDve = inputCount * 2;
            var middle = input.Skip(inputCount / 4).Take(inputCountPoDve).ToList();
            
            for (int i = 0; i < middle.Count; i++)
            {
                var a = middle[i];
                var b = first[i];
                middle[i] += first[i];
            }
            middle.ForEach(Console.WriteLine);

            Console.WriteLine(string.Join(" ", middle));
        }
    }
}
