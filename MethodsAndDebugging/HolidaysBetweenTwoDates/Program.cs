
using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    public static void Main()
    {
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture); //convert input to DateTime
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
        var holidaysCount = 0;

        for (var date = firstDate; date <= secondDate; date = date.AddDays(1))  //search for holidays
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;

            }

        Console.WriteLine(holidaysCount); //print result
    }

}
