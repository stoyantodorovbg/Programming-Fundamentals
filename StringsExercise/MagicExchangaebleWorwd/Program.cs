using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangaebleWord
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Trim(' ').Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var first = input[0];
            var second = input[1];

            var firstDict = new Dictionary<char, char>();
            var secondDict = new Dictionary<char, char>();

            var minLength = Math.Min(first.Length, second.Length);
            var exchengable = true;

            for (int i = 0; i < minLength; i++)
            {
               
                if (firstDict.ContainsKey(first[i]))
                {
                    if (firstDict[first[i]] != second[i])
                    {
                        exchengable = false;
                    }
                }

                if (secondDict.ContainsKey(second[i]))
                {
                    if (secondDict[second[i]] != first[i])
                    {
                        exchengable = false;
                    }
                }

                firstDict[first[i]] = second[i];
                secondDict[second[i]] = first[i];
            }
            if (exchengable)
            {
                if (first.Length != minLength)
                {
                    for (int i = 0; i < first.Length; i++)
                    {
                        var firstList = new List<char>();
                        if (i < minLength)
                        {
                            firstList.Add(first[i]);
                        }
                        else
                        {
                            if (!firstList.Contains(first[i]))
                            {
                                exchengable = false;
                            }
                        }
                    }
                }
                else
                {

                    for (int i = 0; i < second.Length; i++)
                    {
                        var secondList = new List<char>();
                        if (i < minLength)
                        {
                            secondList.Add(second[i]);
                        }
                        else
                        {
                            if (!secondList.Contains(second[i]))
                            {
                                exchengable = false;
                            }
                        }
                    }
                }
            }


            Console.WriteLine(exchengable.ToString().ToLower());
        }
    }
}
