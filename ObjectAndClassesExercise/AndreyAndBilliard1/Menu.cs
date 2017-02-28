using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard1
{
    public class Menu
    {
        public string Product { get; set;}
        public decimal Price { get; set; }

        public Menu(string product, decimal price)
        {
            Product = product;
            Price = price;
        }
    }
}
