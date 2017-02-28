using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstractingOccurence
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();

            var counter = 0;
            
            for (int i = 0; i < text.Length; i++)
            {
                if (i + pattern.Length <= text.Length)
                {
                    var substring = text.Substring(i, pattern.Length);
                    
                    if (substring == pattern)
                    {
                        counter++;
                    }
                }
                
            }

            Console.WriteLine(counter);

        }
    }
}
