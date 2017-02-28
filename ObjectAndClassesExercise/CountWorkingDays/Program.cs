using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace CountWorkingDays
{
    public class Program
    {
        public static void Main(string[] args)
        { 

            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture); //convert input to DateTime
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var countDays = 0;

            int curentYear = firstDate.Year;

            var officialHolidays = new List<DateTime>() {
                     DateTime.ParseExact("01-01-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                     DateTime.ParseExact("03-03-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                     DateTime.ParseExact("01-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                     DateTime.ParseExact("06-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                     DateTime.ParseExact("24-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                     DateTime.ParseExact("06-09-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                     DateTime.ParseExact("22-09-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                     DateTime.ParseExact("01-11-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                     DateTime.ParseExact("24-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                     DateTime.ParseExact("25-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                     DateTime.ParseExact("26-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture)
                };

            while (firstDate <= secondDate) //check days
            {
                DateTime checkDate = new DateTime(2016, firstDate.Month, firstDate.Day);
                string dayOfWeek = firstDate.DayOfWeek.ToString();

                if (dayOfWeek != "Saturday" && dayOfWeek != "Sunday" && !officialHolidays.Contains(checkDate))
                {
                    countDays++;
                }

                firstDate = firstDate.AddDays(1); //shift date
            }

            Console.WriteLine(countDays); //print result
        }
    }
}
