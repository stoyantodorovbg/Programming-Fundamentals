using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            input.Add(int.MinValue);
            int last = input[0];
            int curent = 0;
            int count = 1;
            int maxCount = 1;

            List<int> sequence = new List<int>();
            List<int> maxSequence = new List<int>();

            if (input.Count > 0)
            {
                for (int i = 1; i < input.Count; i++)
                {
                    curent = input[i];
                    if (last == curent)
                    {
                        count++;
                        sequence.Add(last);

                        if ((i + 1) < input.Count)
                        {
                            if (curent != input[i + 1])
                            {
                                sequence.Add(curent);
                            }
                        }

                    }

                    if (maxCount < count)
                    {
                        maxCount = count;
                        maxSequence.RemoveAll(x => x < int.MaxValue);
                        maxSequence.AddRange(sequence);
                    }

                    if (last != curent)
                    {
                        count = 1;
                        sequence.RemoveAll(x => x < int.MaxValue);
                    }
                    last = curent;
                }
            }
            if (maxCount == 1)
            {
                Console.WriteLine(input[0]);
            }
            else
            {
                for (int i = 0; i < maxSequence.Count; i++)
                {
                    Console.Write($"{maxSequence[i]} ");
                }
            }
            
        }
    }
}