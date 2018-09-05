using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Tri
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            Regex regex =
                new Regex(
                    "[%](?<customer>[A-Z][a-z]+)[%][<](?<product>[\\w]+)[>][|](?<count>[0-9+])[|](?<price>[0-9+]+?.[0-9+]+|[0-9+]+)[$]");

            double total = 0;

            while (input != "end of shift")
            {
                var match = regex.Matches(input);

                string name = "";
                string product = "";
                int count = 0;
                double price = 0.0;


                foreach (Match item in match)
                {
                    name = item.Groups["customer"].Value;
                    product = item.Groups["product"].Value;
                    count = int.Parse(item.Groups["count"].Value);
                    price = double.Parse(item.Groups["price"].Value);
                }

                double sum = count * price;

                Console.WriteLine($"{name}: {product} - {sum:f2}");

                total += sum;
                
                input= Console.ReadLine();

            }

            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}