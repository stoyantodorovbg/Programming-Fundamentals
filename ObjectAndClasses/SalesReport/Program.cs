using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Report
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numberOfSales = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSales; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                var town = input[0];
                var product = input[1];
                var price = decimal.Parse(input[2]);
                var quentity = decimal.Parse(input[3]);

                var sale = new Sales(town, product, price, quentity);
            }
        }
            
    }
}