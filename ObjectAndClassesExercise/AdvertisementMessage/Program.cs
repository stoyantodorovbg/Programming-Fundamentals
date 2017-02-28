using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine()); // get a number of messages

            string[] phrase = new string[] //define variants of message
            {
                "Excellent product.",
                "Such a great product",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            string[] events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles.I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            string[] author = new string[]
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            string[] cities = new string[] 
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            for (int i = 0; i < input; i++) //find random phrase
            {

            var random = new Random(i);
            var randomPhrase = random.Next(0, phrase.Length);
            var randomEvents = random.Next(0, events.Length);
            var randomAutor = random.Next(0, author.Length);
            var randomCities = random.Next(0, cities.Length);
                // print result
               Console.WriteLine($"{phrase[randomPhrase]} {events[randomEvents]} {author[randomAutor]} - {cities[randomCities]}");
            }
           
        }
    }
}
