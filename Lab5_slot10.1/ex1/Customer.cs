using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project23
{
    class CustomerOrder
    {
        public static void PlaceOrder(String customerName, string orderChoice)
        {
            Console.WriteLine($"Customer: {customerName}");
            Console.WriteLine($"Order Choice: {orderChoice}");
            Console.WriteLine("Processing order...");
        }
    }
}
