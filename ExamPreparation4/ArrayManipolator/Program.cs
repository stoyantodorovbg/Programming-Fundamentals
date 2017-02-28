using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipolator
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                var command = Console.ReadLine()
                    .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "end")
                {
                    break;
                }

                switch (command[0])
                {
                    case "exchange":
                        var index = int.Parse(command[1]);
                        if (index >= 0 && index < inputList.Count)
                        {
                            var splitIndex = index;
                            var firstList = inputList.Take(splitIndex + 1).ToList();
                            var lastList = inputList.Skip(splitIndex + 1).ToList();
                            inputList.Clear();
                            inputList.AddRange(lastList);
                            inputList.AddRange(firstList);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }

                        break;

                    case "max":
                        var match = false;
                        var resultMax = 0;
                        var resultMaxList = new List<int>();

                        if (command[1] == "even")
                        {
                            if (inputList.Any(x => x % 2 == 0))
                            {
                                resultMax = inputList.Where(n => n % 2 == 0).Max();
                                match = true;
                            }
                            
                        }
                        else
                        {
                            if (inputList.Any(x => x % 2 != 0))
                            {
                                resultMax = inputList.Where(n => n % 2 != 0).Max();
                                match = true;
                            }
                        }
                        
                        if (match)
                        {
                            Console.WriteLine(inputList.LastIndexOf(resultMax));
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }

                        break;

                    case "min":
                        var matchMin = false;
                        var resultMin = 0;
                        if (command[1] == "odd")
                        {
                            if (inputList.Any(x => x % 2 != 0))
                            {
                                resultMin = inputList.Where(n => n % 2 != 0).Min();
                                matchMin = true;
                            }
                                
                        }
                        else
                        {
                            if (inputList.Any(x => x % 2 == 0))
                            {
                                resultMin = inputList.Where(n => n % 2 == 0).Min();
                                matchMin = true;
                            }
                                
                        }
                        
                        if (matchMin)
                        {
                            Console.WriteLine(inputList.LastIndexOf(resultMin));
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                        
                        break;

                    case "first":
                        var elements = new List<int>();
                        var count = int.Parse(command[1]);
                        var counter = 0;
                        var type = command[2];

                        if (count <= inputList.Count)
                        {
                            if (type == "even")
                            {
                                for (int i = 0; i < inputList.Count; i++)
                                {
                                    if (inputList[i] % 2 == 0)
                                    {
                                        counter++;
                                        if (counter <= count)
                                        {
                                            elements.Add(inputList[i]);
                                        }
                                    }
                                }

                            }
                            else
                            {
                                for (int i = 0; i < inputList.Count; i++)
                                {
                                    if (inputList[i] % 2 != 0)
                                    {
                                        counter++;
                                        if (counter <= count)
                                        {
                                            elements.Add(inputList[i]);
                                        }
                                    }
                                }
                            }
                            Console.WriteLine($"[{string.Join(", ", elements)}]");
                            
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }

                        break;

                    case "last":
                        var elementsLast = new List<int>();
                        var countLast = int.Parse(command[1]);
                        var counterLast = 0;
                        var typeLast = command[2];

                        if (countLast <= inputList.Count)
                        {
                            if (typeLast == "even")
                            {
                                for (int i = inputList.Count - 1; i >= 0; i--)
                                {
                                    if (inputList[i] % 2 == 0)
                                    {
                                        counterLast++;
                                        if (counterLast <= countLast)
                                        {
                                            elementsLast.Add(inputList[i]);
                                        }
                                    }
                                }

                            }
                            else
                            {
                                for (int i = inputList.Count - 1; i >= 0; i--)
                                {
                                    if (inputList[i] % 2 != 0)
                                    {
                                        counterLast++;
                                        if (counterLast <= countLast)
                                        {
                                            elementsLast.Add(inputList[i]);
                                        }
                                    }
                                }
                            }

                            elementsLast.Reverse();
                            Console.WriteLine($"[{string.Join(", ", elementsLast)}]");
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                        

                        break;
                     
                }
                
            }

            Console.WriteLine($"[{string.Join(", ", inputList)}]");
        }
    }
}
