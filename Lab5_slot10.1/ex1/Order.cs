using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project23
{
    class GroceryItems
    {
        public static void ProcessGroceryOrder(string customerName)
        {
            CustomerOrder.PlaceOrder(customerName, "Grocery Items");
        }
        public class BakeryProducts
        {
            public static void ProcessBakeryOrder(string customerName)
            {
                CustomerOrder.PlaceOrder(customerName, "Bakery Products");
            }
        }
    }
}
