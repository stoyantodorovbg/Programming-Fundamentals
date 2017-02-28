using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace CubbicMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var text = Console.ReadLine();

                if (text == "Over!")
                {
                    break;
                }

                var number = int.Parse(Console.ReadLine());

                var regex = new Regex($@"^(\d+)([A-Za-z]{{{number}}})([^A-Za-z]*)$");

                var match = regex.Match(text);
                
                if(match.Success)
                {
                   
                    var left = match.Groups[1].Value;
                    var message = match.Groups[2].Value;
                    var right = match.Groups[3].Value;

                    var indexes = string.Concat(left, right)
                        .Where(char.IsDigit)
                        .Select(c => c - '0');

                    var sb = new StringBuilder();

                    foreach (var item in indexes)
                    {
                        if (item < 0 || item >= message.Length)
                        {
                            sb.Append(' ');
                        }
                        else
                        {
                            sb.Append(message[item]);
                        }
                    }

                    Console.WriteLine($"{message} == {sb}");
                }
            }
            


        }
    }
}
