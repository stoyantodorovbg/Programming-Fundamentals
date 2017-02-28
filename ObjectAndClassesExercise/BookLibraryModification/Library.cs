using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryModification
{
    public class Library
    {
        public List<Book> Books { get; set; }

        public static Dictionary<string, string> SortingByDate (Dictionary<string, string> books, DateTime date)
        {
            var result = new Dictionary<string, string>();
            foreach (var item in books)
            {
                DateTime dateOfRelease = DateTime.ParseExact(item.Value, "dd.mm.yyyy", CultureInfo.InvariantCulture);

                if (dateOfRelease > date)
                {
                    result[item.Key] = item.Value;
                }
            }
          
            return result;
        }
    }
}
