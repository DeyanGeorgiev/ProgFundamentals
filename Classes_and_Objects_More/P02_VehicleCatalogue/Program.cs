using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.XPath;

namespace P02_VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            List<dynamic> sales = new List<dynamic>();

            for (int i = 0; i < input; i++)
            {
                string[] incomingData = Console.ReadLine().Split();

                string town = incomingData[0];
                string product = incomingData[1];
                int price = int.Parse(incomingData[2]);
                int qty = int.Parse(incomingData[3]);

                dynamic saleTown = new {town, product, price, qty};

                sales.Add(saleTown);
            }

            Dictionary<string, int> report = new Dictionary<string, int>();

            foreach (var item in sales)
            {
                if (report.ContainsKey(item.town) == false)
                {
                    report.Add(item.town, item.price * item.qty);
                }
                else
                {
                    report[item.town] += item.price * item.qty;
                }
            }


            foreach (var item in report.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{item.Key}...{item.Value}");
            }
        }
    }
}

//todo: need complead