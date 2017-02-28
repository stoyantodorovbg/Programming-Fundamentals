using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Library
    {
        public List<Book> Books { get; set; }

        public static Dictionary<string, double> PriceList(Book book)
        {
            var priceList = new Dictionary<string, double>();
            var priceToDouble = double.Parse(book.Price);

            //if (!priceList.ContainsKey(book.Author))
            //{ 
                priceList[book.Author] = priceToDouble;
            //}
            //else
            //{
              //  priceList[book.Author] += priceToDouble;
            //}

            return priceList;
        }


    }
}
