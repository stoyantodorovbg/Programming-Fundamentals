using System;

class PriceChangeAlert
{
    static void Main()
    {
        var prices = int.Parse(Console.ReadLine()); // get data
        var threshold = decimal.Parse(Console.ReadLine());

        var lastPrice = 0m;
        
        for (int i = 0; i < prices; i++)
        {
            var price = decimal.Parse(Console.ReadLine());
            
            if (lastPrice != 0)
            {
                var difference = Math.Abs(lastPrice - price);
                var biggerPrice = Math.Max(lastPrice, price);
                var differencePercent = (difference * 100) / lastPrice;

                if (lastPrice == price)
                {
                    Console.WriteLine($"NO CHANGE: {price}");
                }
                else if (differencePercent < threshold * 100)
                {
                    
                   
                        differencePercent = (difference * 100) / lastPrice;
                        Console.WriteLine($"MINOR CHANGE: {lastPrice} to {price} ({differencePercent:f2}%)");
                    }
                    
                }
                else
                {
                    if (price > lastPrice)
                    { 
                        Console.WriteLine($"PRICE UP: {lastPrice} to {price} ({ differencePercent:f2}%)");
                    }
                    else
                    {
                        differencePercent = (difference * 100) / price;
                        Console.WriteLine($"PRICE DOWN: {lastPrice} to {price} ({differencePercent:f2}%)");
                    }
                }
            }
            lastPrice = price;
        }
    }

}

