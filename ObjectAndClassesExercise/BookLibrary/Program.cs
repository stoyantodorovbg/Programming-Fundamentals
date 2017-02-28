using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int booksCount = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, double>();

            for (int i = 0; i < booksCount; i++)
            {
                var bookInfo = Console.ReadLine().Split(' ').ToList();

                var tittle = bookInfo[0];
                var author = bookInfo[1];
                var publisher = bookInfo[2];
                var releaseDate = bookInfo[3];
                var iSBN = bookInfo[4];
                var price = bookInfo[5];

                var currentBook = new Book(tittle, author, publisher, releaseDate, iSBN, price);

                foreach (var item in Library.PriceList(currentBook))
                {
                    if (!result.ContainsKey(item.Key))
                    {
                        result[item.Key] = item.Value;
                    }
                    else
                    {
                        result[item.Key] += item.Value;
                    }

                }

            }

            foreach (var item in result.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
