using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());

            var initialIndexes = Console.ReadLine()
                .Trim(' ').Split(' ').Select(int.Parse).ToList();

            var field = new int[fieldSize];

            for (int i = 0; i < field.Length; i++)
            {
                field[i] = 0;
            }

            for (int i = 0; i < initialIndexes.Count; i++)
            {
                if (initialIndexes[i] >= 0 && initialIndexes[i] < field.Length)
                {
                    field[initialIndexes[i]] = 1;
                }
            }

            var command = Console.ReadLine();


            while (command != "end")
            {
                var input = command.Trim(' ')
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var initialIndex = int.Parse(input[0]);
                var direction = input[1];
                var flyLength = int.Parse(input[2]);
                var newPlace = -1;

                if (direction == "right")
                {
                    newPlace = initialIndex + flyLength;
                }
                else
                {
                    newPlace = initialIndex - flyLength;
                }
                
                if (initialIndex >= 0 && initialIndex < field.Length && field[initialIndex] == 1)
                {
                    field[initialIndex] = 0;

                    if (direction == "right" && newPlace < field.Length && newPlace >= 0)
                    {
                        for (int i = newPlace; i < field.Length; i += flyLength)
                        {
                            if (field[i] == 0)
                            {
                                field[i] = 1;
                                break;
                            }
                        }
                    }
                    else if (direction == "left" && newPlace >= 0 && newPlace < field.Length)
                    {
                        for (int i = newPlace; i >= 0; i -= flyLength)
                        {
                            if (field[i] == 0)
                            {
                                field[i] = 1;
                                break;
                            }
                        }
                    }
                }
                
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));

        }
    }
}
