using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicode_Characters_With_Select
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var chars = input.Select(c => (int)c).Select(c => $@"\u{c:x4}");

            Console.WriteLine(string.Concat(chars));
        }
    }
}