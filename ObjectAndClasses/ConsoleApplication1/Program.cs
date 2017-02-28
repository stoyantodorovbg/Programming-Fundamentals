using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random rnd = new Random();

            for (int posOne = 0; posOne < words.Length; posOne++)
            {
                int posTwo = rnd.Next(words.Length);
                string temp = words[posOne];
                words[posOne] = words[posTwo];
                words[posTwo] = temp;
            }

            Console.WriteLine(string.Join("\r\n", words));
        }
    }
}
