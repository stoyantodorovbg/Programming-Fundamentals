using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int countOfProductsInMenu = int.Parse(Console.ReadLine());
            var menu = new Dictionary<string, decimal>();
            var billDict = new Dictionary<string, Dictionary<string, Dictionary<int, decimal>>>();

            for (int i = 0; i < countOfProductsInMenu; i++)
            {
                var product = Console.ReadLine().Split('-').ToList();

                var productName = product[0];
                var productPrice = decimal.Parse(product[1]);

                    menu[productName] = productPrice;

            }
            var clientsInput = Console.ReadLine();

            while(clientsInput != "end of clients")
            {
                var clients = clientsInput.Split('-', ',').ToList();
                var clientName = clients[0];
                var purchase = clients[1];
                var quentity = int.Parse(clients[2]);

                var product = new Product(purchase, menu[purchase]);
                var bill = new Bill(product, clientName, quentity);

                billDict = Bill.CompiteBills(bill);

                clientsInput = Console.ReadLine();
            }
            var total = 0;
            foreach (var client in billDict)
            {
                Console.WriteLine(client.Key);
                foreach (var product in client.Value)
                {
                    Console.Write($"-- {product.Key} - ");
                    foreach (var sum in product.Value)
                  
                        total += (sum.Key);
                        Console.WriteLine(sum.Key);
                        Console.WriteLine($"Bill: {sum.Value:f2}");
                    }
                }
                Console.WriteLine($"Total bill: {total:f2}");

            }
        }
        
    }
}
