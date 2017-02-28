using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinningTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            var match = @"(@|#|\$|\^){6,12}(\w+|)\1{6,12}";

            Regex regex = new Regex(match);

            for (int i = 0; i < input.Length; i++)
            {
                var counterA = 0;
                var counterDies = 0;
                var counterDolar = 0;
                var counterCovka = 0;

                if (input[i].Length == 20)
                {

                    for (int e = 0; e < input[i].Length; e++)
                    {
                        if (input[i][e] == '@')
                        {
                            counterA++;
                        }
                        else if (input[i][e] == '#')
                        {
                            counterDies++;
                        }
                        else if (input[i][e] == '$')
                        {
                            counterDolar++;
                        }
                        else if (input[i][e] == '^')
                        {
                            counterCovka++;
                        }

                    }
                }

                var currency = "";

                if (counterA >= 12)
                {
                    currency = "@";
                }
                else if (counterDies >= 12)
                {
                    currency = "#";
                }
                else if (counterDolar >= 12)
                {
                    currency = "$";
                }
                else if (counterCovka >= 12)
                {
                    currency = "^";
                }


                var isMatch = regex.IsMatch(input[i]);

                if (input[i][0].ToString() != currency && input[i][input[i].Length - 1].ToString() != currency)
                {
                    var regCount = new Regex(@"^(\@|\$|\^|\#){6,10}");

                    var sb = new StringBuilder();

                    var length = input[i];
                    var lengthResult = "";

                    for (int e = 0; e < input[i].Length; e++)
                    {
                        if (input[i][e].ToString() != currency)
                        {
                            sb.Append(input[i][e]);

                        }
                        else
                        {
                            break;
                        }
                    }
                    lengthResult = length.Replace(sb.ToString(), string.Empty);

                    var winLengthFirst = regCount.Match(lengthResult);


                    var sbEnd = new StringBuilder();
                    var regCountEnd = new Regex(@"(\@|\$|\^|\#){6,10}$");

                    var lengthEnd = input[i];
                    var lengthResultEnd = "";

                    for (int e = input[i].Length - 1; e >= 0; e--)
                    {
                        if (input[i][e].ToString() != currency)
                        {
                            sbEnd.Append(input[i][e]);

                        }
                        else
                        {
                            break;
                        }
                    }

                    var sbReverse = new StringBuilder();
                    for (int e = sbEnd.Length - 1; e >= 0; e--)
                    {
                        sbReverse.Append(sbEnd[e]);
                    }

                    lengthResultEnd = lengthEnd.Replace(sbReverse.ToString(), string.Empty);

                    var winLengthEnd = regCountEnd.Match(lengthResultEnd);

                    var resultLenght = Math.Min(winLengthEnd.Length, winLengthFirst.Length);

                    if (input[i].Length != 20)
                    {
                        Console.WriteLine("invalid ticket");
                    }
                    else if (counterA >= 12 && counterA < 20 && isMatch && counterA % 2 == 0)
                    {
                        Console.WriteLine($@"ticket ""{input[i]}"" - {counterA / 2}{currency}");
                    }
                    else if (counterCovka >= 12 && counterCovka < 20 && isMatch && counterCovka % 2 == 0)
                    {
                        Console.WriteLine($@"ticket ""{input[i]}"" - {counterCovka / 2}{currency}");
                    }
                    else if (counterDies >= 12 && counterDies < 20 && isMatch && counterDies % 2 == 0)
                    {
                        Console.WriteLine($@"ticket ""{input[i]}"" - {counterDies / 2}{currency}");
                    }
                    else if (counterDolar >= 12 && counterDolar < 20 && isMatch && counterDolar % 2 == 0)
                    {
                        Console.WriteLine($@"ticket ""{input[i]}"" - {resultLenght}{currency}");
                    }
                    else if (counterA == 20 || counterCovka == 20 || counterDies == 20 || counterDolar == 20)
                    {
                        Console.WriteLine($@"ticket ""{input[i]}"" - {counterDolar / 2}{currency} Jackpot!");
                    }
                    else
                    {
                        Console.WriteLine($@"ticket ""{input[i]}"" - no match");
                    }
                    
                }
                else
                {

                    if (input[i].Length != 20)
                    {
                        Console.WriteLine("invalid ticket");
                    }
                    else if (counterA >= 12 && counterA < 20 && isMatch && counterA % 2 == 0)
                    {
                        Console.WriteLine($@"ticket ""{input[i]}"" - {counterA / 2}{currency}");
                    }
                    else if (counterCovka >= 12 && counterCovka < 20 && isMatch && counterCovka % 2 == 0)
                    {
                        Console.WriteLine($@"ticket ""{input[i]}"" - {counterCovka / 2}{currency}");
                    }
                    else if (counterDies >= 12 && counterDies < 20 && isMatch && counterDies % 2 == 0)
                    {
                        Console.WriteLine($@"ticket ""{input[i]}"" - {counterDies / 2}{currency}");
                    }
                    else if (counterDolar >= 12 && counterDolar < 20 && isMatch && counterDolar % 2 == 0)
                    {
                        Console.WriteLine($@"ticket ""{input[i]}"" - {counterDolar}{currency}");
                    }
                    else if (counterA == 20 || counterCovka == 20 || counterDies == 20 || counterDolar == 20)
                    {
                        Console.WriteLine($@"ticket ""{input[i]}"" - {counterDolar / 2}{currency} Jackpot!");   
                    }
                    else
                    {
                        Console.WriteLine($@"ticket ""{input[i]}"" - no match");
                    }
                }
 
            }

        }
    }
}
