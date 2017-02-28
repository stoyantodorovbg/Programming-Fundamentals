using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace useYourChains
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var patternPtag = @"<p>.+?<\/p>";
            var regexPtag = new Regex(patternPtag);

            var matches = regexPtag.Matches(input);
            var matchesList = new List<string>();

            foreach(Match match in matches)
            {
                var matchToString = match.
                    ToString().
                    TrimStart('<', 'p', '>').
                    TrimEnd('<', '/', 'p', '>');
                matchesList.Add(matchToString);
            }

            var convertToSpaces = new List<string>();

            foreach(var item in matchesList)
            {
                var convertToSpaceStr = Regex.Replace(item, @"[^a-z\d]", " ");
                convertToSpaces.Add(convertToSpaceStr);
            }
            
            var removeSpaces = new List<string>();

            foreach(var item in convertToSpaces)
            {
                var removeSpacesString = Regex.Replace(item, @"\s{2,1000}", " ");
                removeSpaces.Add(removeSpacesString);
            }
            
            var alphabet = "abcdefghijklmnopqrstuvwxyz";

            var convertLetterAtoN = new Dictionary<char, char>();
            var convertLetterNtoA = new Dictionary<char, char>();

            for (int i = 0; i < 13; i++)
            {
                convertLetterAtoN[alphabet[i]] = alphabet[i + 13];
                convertLetterNtoA[alphabet[i + 13]] = alphabet[i];
            }

            var convertLetterList = new List<string>();

            foreach (var item in removeSpaces)
            {
                var sb = new StringBuilder();
                var convertLetterString = item;
                
                for(int i = 0; i < convertLetterString.Length; i++)
                {
                    var letter = convertLetterString[i];

                    if (convertLetterAtoN.ContainsKey(letter))
                    {
                        sb.Append(convertLetterAtoN[letter]);
                    }
                    else if (convertLetterNtoA.ContainsKey(letter))
                    {
                        sb.Append(convertLetterNtoA[letter]);
                    }
                    else
                    {
                        sb.Append(letter);
                    }
                    
                }
                convertLetterList.Add(sb.ToString());
            }

            convertLetterList.ForEach(Console.Write);
           
        }
    }
}
