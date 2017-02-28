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
                switch (inputCommand[0])
                {
                    case "add":

                        int indexAdd = int.Parse(inputCommand[1]);
                        int elementAdd = int.Parse(inputCommand[2]);
                        inputList.Insert(indexAdd, elementAdd);
                        break;

                    case "addMany":

                        int indexAddMany = int.Parse(inputCommand[1]);

                        for (int i = inputCommand.Count - 1; i > 1; i--)
                        {
                            int elementAddMany = int.Parse(inputCommand[i]);
                            inputList.Insert(indexAddMany, elementAddMany);
                        }
                        break;

                    case "contains":

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
                        break;

                    case "remove":

                        int index = int.Parse(inputCommand[1]);

                        inputList.RemoveAt(index);
                        break;

                    case "shift":

                        int step = int.Parse(inputCommand[1]);

                        for (int i = 0; i < step; i++)
                        {
                            int shifted = inputList[i];
                            inputList.RemoveAt(i);
                            inputList.Add(shifted);
                        }
                        break;

                    case "sumPairs":

                        var sumList = new List<int>();
                        if (inputList.Count % 2 == 0)
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
                        break;

                    case "print":
                        break;
                }
                inputCommand = Console.ReadLine()
                        .Split(' ')
                        .ToList();
            }

            Console.WriteLine('[' + string.Join(", ", inputList) + ']');
        }
    }
}

