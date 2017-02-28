using System;

namespace AddName
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine(); //get name

            Console.WriteLine($"Hello, {PrintName(name)}!"); // print result
        }

        static string PrintName(string name)
        {
            return name;
        }
    }
}
