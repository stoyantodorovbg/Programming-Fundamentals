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
            List<int> inputSort = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //List<int> inputSort = new List<int>();


            //inputSort.AddRange(input);
            //inputSort.Sort();

            inputSort.Add(int.MaxValue);
            int last = inputSort[1];
            int curent = 0;
            int count = 1;
            int printValue = inputSort[0];
            int maxCount = 1;

            if (inputSort.Count > 0)
            {
                for (int i = 1; i > inputSort.Count; i++)
                {
                    curent = inputSort[i];
                    if (last == curent)
                    {
                        count++;

                    }
                    if (last != curent)
                    {
                        count = 1;
                    }
                    if (maxCount < count)
                    {
                        maxCount = count;
                        printValue = last;
                        count = 1;
                    }
                    last = curent;
                }
            }


            Console.WriteLine(printValue);
        }
    }
}
