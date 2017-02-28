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
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var inputCommand = Console.ReadLine()
                .Split(' ')
                .ToList();




            while (inputCommand[0] != "print")
            {
                if (inputCommand[0] == "add")
                {
                    int index = int.Parse(inputCommand[1]);
                    int element = int.Parse(inputCommand[2]);
                    inputList.Insert(index, element);
                }

                if (inputCommand[0] == "addMany")
                {
                    int index = int.Parse(inputCommand[1]);

                    for (int i = inputCommand.Count - 1; i > 1; i--)
                    {
                        int element = int.Parse(inputCommand[i]);
                        inputList.Insert(index, element);
                    }
                }

                if (inputCommand[0] == "contains")
                {
                    int containsIndex = -1;
                    int element = int.Parse(inputCommand[1]);

                    for (int i = 0; i < inputCommand.Count; i++)
                    {
                        if (inputList[i] == element)
                        {
                            containsIndex = i;
                            break;
                        }
                    }
                    Console.WriteLine(containsIndex);
                }

                if (inputCommand[0] == "remove")
                {
                    int index = int.Parse(inputCommand[1]);

                    for (int i = 0; i < inputCommand.Count; i++)
                    {
                        if (i == index)
                        {
                            inputList.Remove(inputList[i]);
                            break;
                        }
                    }
                }
                var shiftedArray = new int[inputList.Count];
                if (inputCommand[0] == "shift")
                {
                    int step = int.Parse(inputCommand[1]);

                    for (int i = 0; i < inputList.Count; i++)
                    {
                        if (i - step < 0)
                        {
                            shiftedArray[inputList.Count - step + i - 1] = inputList[i];

                        }
                        else
                        {
                            shiftedArray[i] = inputList[i - step];
                        }
                    }
                    inputList.Clear();
                    inputList.AddRange(shiftedArray);
                }
                var sumList = new List<int>();
                if (inputCommand[0] == "sumPairs")
                {

                    if (inputList.Count % 2 != 0)
                    {
                        for (int i = 0; i < inputList.Count - 1; i += 2)
                        {
                            int j = 0;
                            j = inputList[i] + inputList[i + 1];
                            sumList.Add(j);
                        }
                    }
                    else
                    {
                        for (int i = 1; i < inputList.Count; i += 2)
                        {
                            int j = 0;
                            j = inputList[i] + inputList[i - 1];
                            sumList.Add(j);

                        }

                        sumList.Add(inputList[inputList.Count - 1]);
                    }
                    inputList.Clear();
                    inputList.AddRange(sumList);
                }

                if (inputCommand[0] == "print")
                {
                    break;
                }

                inputCommand = Console.ReadLine()
                .Split(' ')
                .ToList();
            }

            var stringInputlist = new List<string>();

            // for (int i = 0; i < inputList.Count; i ++)
            // {
            // string toString = inputList[i].ToString();
            // stringInputlist[i] = toString;
            // }
            Console.Write('[');
            for (int i = 0; i < inputList.Count - 1; i++)
            {
                Console.Write($"{inputList[i]}, ");
            }
            Console.Write(inputList[inputList.Count - 1]);
            Console.Write(']');
            //Console.WriteLine(string.Join(", ", $"[{stringInputlist}]"));
        }
    }
}

