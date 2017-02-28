using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    public class Bill
    {
        public Menu CheckMenu { get; set; }
        public Product CheckProduct { get; set; }
        public string Client { get; set; }
        public int Quentity { get; set; }

        public Bill(Product checkProduct, string client, int quentity)
        {
            Client = client;
           // this.CheckMenu = checkMenu;
            CheckProduct = checkProduct;
            Quentity = quentity;
        }

        //public static Dictionary<string, Dictionary<string, Dictionary
        //    <int, decimal>>> CompiteBills(Bill bill)
        //{
        //    var billDict = new Dictionary<string, Dictionary<string, Dictionary<int, decimal>>>();
        //    var dict = new Dictionary<int, decimal>();
        //    var productInfo = new Dictionary<string, Dictionary<int, decimal>>();
        //    var qP = new Dictionary<int, decimal>();
        //
        //    var productQuentityDict = new Dictionary<string, int>();
        //    var productPriceDict = new Dictionary<string, decimal>();
        //
        //    if (!productQuentityDict.ContainsKey(bill.CheckProduct.ProductName)) // find quentity of products
        //    {
        //        productQuentityDict[bill.CheckProduct.ProductName] = bill.Quentity;
        //    }
        //    else
        //    {
        //        productQuentityDict[bill.CheckProduct.ProductName] += bill.Quentity;
        //    }
        //
        //    productPriceDict[bill.CheckProduct.ProductName] = 
        //        bill.CheckProduct.ProductPrice * //find price of purchase
        //        bill.Quentity;
        //
        //   // productPriceDict[bill.Client] = productQuentityDict[bill.CheckProduct.ProductName];
        //
        //
        //    qP[productQuentityDict[bill.CheckProduct.ProductName]] =  //find client -
        //                                                              //product - quentity - price
        //        productPriceDict[bill.CheckProduct.ProductName];
        //
        //    productInfo[bill.CheckProduct.ProductName] = qP;
        //
        //    billDict[bill.Client] = productInfo;
        //
        //    //billDict[bill.Client][bill.CheckProduct.ProductName]
        //      //  [productQuentityDict[bill.CheckProduct.ProductName]] = 
        //        //productPriceDict[bill.CheckProduct.ProductName]; 
        //
        //    return billDict;

        }
    }
}
