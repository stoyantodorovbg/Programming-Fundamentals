using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
    public class Sales
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quentity { get; set; }

        public Sales (string town, string product, decimal price, decimal quentity)
        {
            this.Town = town;
            this.Product = product;
            this.Price = price;
            this.Quentity = quentity;
        }
    }
}
