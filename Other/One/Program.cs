using System;
using System.Globalization;

namespace One
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());


            decimal totalPrice = (decimal) 0.0;
            
            for (int i = 0; i < input; i++)
            {
                
                decimal priceCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int capsulesCount = int.Parse(Console.ReadLine());

                int month = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                decimal priceCoffe = (month * capsulesCount) * priceCapsule;

                Console.WriteLine($"The price for the coffee is: ${priceCoffe:f2}");

                totalPrice += priceCoffe;

            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
            
            
            
            
        }
    }
}