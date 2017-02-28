using System;

class PriceChangeAlert
{
    static void Main()
    {
        int priceCount = int.Parse(Console.ReadLine());
        double treshold = double.Parse(Console.ReadLine());

        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < priceCount - 1; i++)
        {
            double price = double.Parse(Console.ReadLine());
            double difference = GetDifference(lastPrice, price);
            bool isSignificantDifference = GetDifferenceSignificance(difference, treshold);
            string message = GetOutputMessage(price, lastPrice, difference, isSignificantDifference);
            Console.WriteLine(message);

            lastPrice = price;
        }
    }

    private static string GetOutputMessage(double price, double lastPrice, double difference, bool isSignificantDifference)

    {
        string message = "";
        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", price);
        }
        else if (!isSignificantDifference)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, price, difference * 100);
        }
        else if (isSignificantDifference && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, price, difference * 100);
        }
        else if (isSignificantDifference && (difference < 0))
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, price, difference * 100);
        return message;
    }

    private static bool GetDifferenceSignificance(double difference, double treshold)
    {
        if (Math.Abs(difference) >= treshold)
        {
            return true;
        }
        return false;
    }

    private static double GetDifference(double lastPrice, double price)
    {
        double difference = (price - lastPrice) / lastPrice;
        return difference;
    }
}
