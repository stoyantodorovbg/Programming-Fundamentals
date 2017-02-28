using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard1
{
   public class Clients
    {
        public string Name { get; set; }
        public string Purchase { get; set; }
        public decimal Quentity { get; set; }

        public Clients(string name, string purchase, decimal quentity)
        {
            Name = name;
            Purchase = purchase;
            Quentity = quentity;
        }

    }
}
