using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();
            sb.Append(input);

            while(input != "end")
            {
                input = Console.ReadLine();
                sb.Append(input);
            }
            
            var text = sb.ToString();
            text.Trim(' ').Split('\n');
            var pattern = @"<a.*href=(""|')(.*?)\1>(.*?)<\/a>";
            Regex regex = new Regex(pattern);

            var result = regex.Replace(text,
                @"[URL href=""$2""]$3[/URL]");

            Console.WriteLine(result.Trim('e', 'n', 'd'));

        }
       
    }
}
