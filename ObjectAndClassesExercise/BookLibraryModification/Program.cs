using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryModification
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int booksCount = int.Parse(Console.ReadLine());
            var books = new Dictionary<string, string>();

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

                books[currentBook.Tittle] = currentBook.ReleaseDate;
                
            }
            string dateString = Console.ReadLine();
            var date = DateTime.ParseExact(dateString, "dd.mm.yyyy", CultureInfo.InvariantCulture);

            var result = new Dictionary<string, string>();

            result = Library.SortingByDate(books, date);

            var resultWithDate = new Dictionary<string, DateTime>();

            foreach(var item in result)
            {
                DateTime bookDate = DateTime.ParseExact(item.Value, "dd.mm.yyyy", CultureInfo.InvariantCulture);
                resultWithDate[item.Key] = bookDate;
            }

            foreach (var item in resultWithDate.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                string dateWithoutTime = item.Value.ToString("dd.mm.yyyy");
                Console.WriteLine($"{item.Key} -> {dateWithoutTime}");
            }
        }
    }
}
