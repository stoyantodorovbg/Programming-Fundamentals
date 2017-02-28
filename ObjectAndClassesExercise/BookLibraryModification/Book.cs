using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryModification
{
    public class Book
    {
        public string Tittle { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public string Price { get; set; }

        public Book(string tittle, string author, string publisher, string releaseDate, string iSBN, string price)
        {
            this.Tittle = tittle;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.ISBN = iSBN;
            this.Price = price;
        }
    }
}
