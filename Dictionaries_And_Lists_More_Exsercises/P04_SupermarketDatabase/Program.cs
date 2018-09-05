using System;
using System.Collections.Generic;
using System.Xml.XPath;

namespace P04_SupermarketDatabase
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, double> productPrice = new Dictionary<string, double>();
            Dictionary<string, int> produtQty = new Dictionary<string, int>();


            while (input != "stocked")
            {
                if (input != null)
                {
                    string[] separator = input
                        .Split();

                    string articul = separator[0];
                    double price = double.Parse(separator[1]);
                    int qty = int.Parse(separator[2]);

                    if (productPrice.ContainsKey(articul))
                    {
                        productPrice[articul] = price;
                        produtQty[articul] += qty;
                    }
                    else
                    {
                        productPrice.Add(articul, price);
                        produtQty.Add(articul, qty);
                    }
                }

                input = Console.ReadLine();

                Console.WriteLine();
            }


            double totalSum = 0;


            foreach (var product in productPrice)
            {
                double sum = 0;


                if (produtQty.ContainsKey(product.Key))
                {
                    int contentValue = int.Parse(produtQty[product.Key].ToString());
                    sum = product.Value * contentValue;

                    Console.WriteLine($"{product.Key}: ${product.Value:f2} * {contentValue} = ${sum:f2}");
                }

                totalSum += sum;
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${totalSum:f2}");
        }
    }
}