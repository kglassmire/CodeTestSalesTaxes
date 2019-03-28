using StoreDealerOn.Models;
using System;

namespace StoreDealerOn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Order 1...");
            ProcessOrder1();
            Console.WriteLine("Order 2...");
            ProcessOrder2();
            Console.WriteLine("Order 3...");
            ProcessOrder3();
        }

        static void ProcessOrder1()
        {
            Order order = new Order();
            order.Add(StoreInventory.Book(12.49M));
            order.Add(StoreInventory.Book(12.49M));
            order.Add(StoreInventory.MusicCD(14.99M));
            order.Add(StoreInventory.ChocolateBar(0.85M));

            var receipt = order.Checkout();
            receipt.PrintReceipt();
        }

        static void ProcessOrder2()
        {

            Order order = new Order();
            order.Add(StoreInventory.ImportedBoxChocolates(10.00M));
            order.Add(StoreInventory.ImportedBottleOfPerfume(47.50M));

            var receipt = order.Checkout();
            receipt.PrintReceipt();


        }

        static void ProcessOrder3()
        {
            Order order = new Order();
            order.Add(StoreInventory.ImportedBottleOfPerfume(27.99M));
            order.Add(StoreInventory.BottleOfPerfume(18.99M));
            order.Add(StoreInventory.PacketHeadachePills(9.75M));
            order.Add(StoreInventory.ImportedBoxChocolates(11.25M));
            order.Add(StoreInventory.ImportedBoxChocolates(11.25M));

            var receipt = order.Checkout();
            receipt.PrintReceipt();
        }
    }
}
