using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MostFriquentElement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> inputSort = new List<int>();
            inputSort.AddRange(input);
            inputSort.Sort();

            inputSort.Add(int.MaxValue);
            int last = inputSort[0];
            int curent = 0;
            int count = 1;
            int printValue = input[0];
            int maxCount = 1;
            List<int> findFirstSequence = new List<int>();
            List<int> search = new List<int>();

            if (inputSort.Count > 0)
            {
                for (int i = 1; i < inputSort.Count; i++)
                {
                    curent = inputSort[i];

                    if (last == curent)
                    {
                        count++;
                        search.Add(curent);
                    }

                    if (last != curent)
                    {
                        count = 1;
                    }

                    if (maxCount < count)
                    {
                        maxCount = count;
                        printValue = last;
                        findFirstSequence.Add(printValue);
                        count = 1;
                    }

                    last = curent;
                }
            }
            
            Console.WriteLine(printValue);

            for (int i = 0; i < search.Count; i++)
            {
                Console.WriteLine(search[i]);
            }
        }
    }
}
