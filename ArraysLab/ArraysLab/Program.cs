using System;


namespace ArraysLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string[] week = new string[] {
                "Invalid Day!",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"} ;

                Console.WriteLine(week[input]);
           
        }
    }
}
