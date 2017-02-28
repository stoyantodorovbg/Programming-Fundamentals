using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int countOfProductsInMenu = int.Parse(Console.ReadLine());
            var menuDict = new Dictionary<string, Menu>();

            for (int i = 0; i < countOfProductsInMenu; i++)
            {
                var product = Console.ReadLine().Trim().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                var productName = product[0];
                var productPrice = decimal.Parse(product[1]);

                var menu = new Menu(productName, productPrice);
                menuDict[menu.Product] = menu;

            }
            var input = Console.ReadLine().Trim();
            var clientsDict = new Dictionary<string, Clients>();

            while (input != "end of clients")
            {
                var inputList = input.Split(new char[]{ '-', ','}, StringSplitOptions.RemoveEmptyEntries).ToList();
                var client = inputList[0];
                var purchase = inputList[1];
                var quentity = inputList[2];

                var clients = new Clients(client, purchase, decimal.Parse(quentity));

                if (menuDict.ContainsKey(purchase))
                {
                    clientsDict[client] = clients;
                }

                input = Console.ReadLine().Trim();
            }

            var total = 0M;
            foreach (var item in clientsDict.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"-- {item.Value.Purchase} - {item.Value.Quentity}");

                foreach (var it in menuDict)
                {
                    if (it.Value.Product == item.Value.Purchase)
                    {
                        Console.WriteLine($"Bill: {(it.Value.Price * item.Value.Quentity):f2}");
                        total += it.Value.Price * item.Value.Quentity;
                    }
                }
            }

            Console.WriteLine($"Total bill: {total:f2}");
        }
    }
}
