using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangaebleWorlds
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim(' ').Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var first = input[0];
            var second = input[1];

            var minLength = Math.Min(first.Length, second.Length);
            var exchengable = true;

            for (int i = 0; i < minLength - 1; i++)
            {
                if (first[i] == first[i + 1] && second[i] != second[i + 1])
                {
                    exchengable = false;
                }

                if (first[i] != first[i + 1] && second[i] == second[i + 1])
                {
                    exchengable = false;
                }

                for (int e = i + 1; e < minLength - 1; e++)
                {
                    if (first[i] == first[e] && first[e] != second[e])
                    {
                        exchengable = false;
                    }
                }
                for (int e = i + 1; e < minLength - 1; e++)
                {
                    if (second[i] == second[e] && second[e] != first[e])
                    {
                        exchengable = false;
                    }
                }

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
