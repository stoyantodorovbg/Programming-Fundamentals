using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var repositoty = new Dictionary<string, string>();

            while(input != "stop")
            {
                var email = Console.ReadLine();

                var lastLetter = email[email.Length - 1];
                var beforeLastLetter = email[email.Length - 2];

                if (!((lastLetter == 's' && beforeLastLetter == 'u')
                    || (lastLetter == 'k' && beforeLastLetter == 'u')))
                {
                    repositoty[input] = email;
                }

                input = Console.ReadLine();
            }

            foreach (var item in repositoty)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
