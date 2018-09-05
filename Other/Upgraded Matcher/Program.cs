using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> shopList = new Dictionary<string, int>();


            string[] products = Console.ReadLine().Split().ToArray();
            long[] qty = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            long[] newQty = new long[price.Length];

            Inventory inventory = new Inventory();
            List<Inventory> shop = new List<Inventory>(products.Length);

            for (int i = 0; i < qty.Length; i++)
            {
                newQty[i] = qty[i];
            }


            for (int i = 0; i < shop.Capacity; i++)
            {
                inventory.Price = price[i];
                inventory.Quantity = newQty[i];
                inventory.Product = products[i];


                shop.Add(new Inventory(inventory.Product, inventory.Quantity, inventory.Price));
            }

            string input = Console.ReadLine();
            while (input != "done")
            {
                string[] forOperation = input.Split().ToArray();

                string incomeProduct = forOperation[0];
                long incomeQty = long.Parse(forOperation[1]);


                foreach (var item in shop)
                {
                    if (incomeProduct.Equals(item.Product) && incomeQty > item.Quantity)
                    {
                        Console.WriteLine($"We do not have enough {item.Product}");
                    }
                    
                    if (incomeProduct.Equals(item.Product) && item.Quantity>= incomeQty)
                    {
                        var cost = item.Price * incomeQty;

                        Console.WriteLine($"{item.Product} x {incomeQty} costs {cost:f2}");

                        item.Quantity = item.Quantity - incomeQty;
                    }

                    
                        
                }


                input = Console.ReadLine();
            }
        }
    }

    class Inventory
    {
        public string Product { get; set; }
        public long Quantity { get; set; }
        public decimal Price { get; set; }


        public Inventory(string product, long quantity, decimal price)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
        }

        public Inventory()
        {
        }
    }
}