using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                   .Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries)
                   .ToList();

            var start = 0;
            var count = 0;
            

            while (true)
            {
                var command = Console.ReadLine()
                    .Split(new[] { ' ' })
                    .ToList();

                if (command[0] == "end")
                {
                    break;
                }

                switch(command[0])
                {

                    case "reverse":

                        start = int.Parse(command[2]);
                        count = int.Parse(command[4]);
                        if(start < 0 || start >= input.Count || count < 0 || (count + start) > input.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            var reversed = new List<string>();
                            reversed.AddRange(input.Skip(start));
                            reversed.RemoveRange(count, reversed.Count - count);
                            reversed.Reverse();
                            input.RemoveRange(start, count);
                            input.InsertRange(start, reversed);

                        }

                        break;
                    case "sort":
                        start = int.Parse(command[2]);
                        count = int.Parse(command[4]);
                        if (start < 0 || start >= input.Count || count < 0 || (count + start) > input.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        else
                        {
                            var sorted = new List<string>();
                            sorted.AddRange(input.Skip(start));
                            sorted.RemoveRange(count, sorted.Count - count);
                            sorted.Sort();
                            input.RemoveRange(start, count);
                            input.InsertRange(start, sorted);
                        }

                            break;
                    case "rollLeft":
                        long rollLeft = 0;
                        rollLeft = long.Parse(command[1]);

                        rollLeft %= input.Count;

                        
                            var rolledLeft = new List<string>();
                            for (int i = 0; i < rollLeft; i++)
                            {
                                for (int e = 0; e < input.Count; e++)
                                {
                                    if (e < input.Count - 1)
                                    {
                                        rolledLeft.Add(input[e + 1]);
                                    }
                                    else
                                    {
                                        rolledLeft.Add(input[0]);
                                    }

                                }
                                input.Clear();
                                input.AddRange(rolledLeft);
                                rolledLeft.Clear();
                            }
                        
                        break;
                    case "rollRight":
                        var rolledRight = new List<string>();
                        var rollRight = long.Parse(command[1]);

                        rollRight %= input.Count;

                            for (int i = 0; i < rollRight; i++)
                            {
                                for (int e = input.Count - 1; e >= 0; e--)
                                {
                                    if (e >= 1)
                                    {
                                        rolledRight.Add(input[e - 1]);
                                    }
                                    else
                                    {
                                        rolledRight.Add(input[input.Count - 1]);
                                    }

                                }
                                rolledRight.Reverse();
                                input.Clear();
                                input.AddRange(rolledRight);
                                rolledRight.Clear();
                            }
                        
                        break;

                }
            }

            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
    }
}
