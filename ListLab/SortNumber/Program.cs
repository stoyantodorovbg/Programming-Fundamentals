using System;
using System.Linq;


namespace SortNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            input.Sort();

            Console.WriteLine(string.Join(" <= ", input));
        }        
    }
}
