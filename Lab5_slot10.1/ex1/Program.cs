using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project23.GroceryItems;

namespace Project23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter customer name: ");
            string customerName = Console.ReadLine();

            Console.WriteLine("1, Grocery items");
            Console.WriteLine("2, Bakery products");
            Console.WriteLine("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    GroceryItems.ProcessGroceryOrder(customerName);
                    break;
                case 2:
                    BakeryProducts.ProcessBakeryOrder(customerName);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
