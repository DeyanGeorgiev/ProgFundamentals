using System;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            
            
            int pricePackage ;
            int totalPrice ;
            double discountedPrice ;
            double pricePerPerson = 0;
            string hallName = "";


            if (groupSize <= 50)
            {
                int price = 2500;
                hallName = "Small Hall";

                switch (package)
                {
                    case "Normal":
                         pricePackage = 500;

                       totalPrice = pricePackage + price;
                        discountedPrice = totalPrice - (totalPrice * 5 / 100.0);
                        pricePerPerson = discountedPrice / (groupSize * 1.0);
                        break;

                    case "Gold":
                         pricePackage = 750;

                        totalPrice = pricePackage + price;
                        discountedPrice = totalPrice - (totalPrice * 10 / 100.0);
                        pricePerPerson = discountedPrice / (groupSize * 1.0);
                        break;

                    case "Platinum":
                        pricePackage = 1000;

                        totalPrice = pricePackage + price;
                        discountedPrice = totalPrice - (totalPrice * 15 / 100.0);
                        pricePerPerson = discountedPrice / (groupSize * 1.0);
                        break;
                }

                
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                int price = 5000;
                hallName = "Terrace";
                
                switch (package)
                {
                    case "Normal":
                        pricePackage = 500;

                        totalPrice = pricePackage + price;
                        discountedPrice = totalPrice - (totalPrice * 5 / 100.0);
                        pricePerPerson = discountedPrice / (groupSize * 1.0);
                        break;

                    case "Gold":
                        pricePackage = 750;

                        totalPrice = pricePackage + price;
                        discountedPrice = totalPrice - (totalPrice * 10 / 100.0);
                        pricePerPerson = discountedPrice / (groupSize * 1.0);
                        break;

                    case "Platinum":
                        pricePackage = 1000;

                        totalPrice = pricePackage + price;
                        discountedPrice = totalPrice - (totalPrice * 15 / 100.0);
                        pricePerPerson = discountedPrice / (groupSize * 1.0);
                        break;
                }
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                int price = 7500;
                hallName = "Great Hall";
                
                switch (package)
                {
                    case "Normal":
                        pricePackage = 500;

                        totalPrice = pricePackage + price;
                        discountedPrice = totalPrice - (totalPrice * 5 / 100.0);
                        pricePerPerson = discountedPrice / (groupSize * 1.0);
                        break;

                    case "Gold":
                        pricePackage = 750;

                        totalPrice = pricePackage + price;
                        discountedPrice = totalPrice - (totalPrice * 10 / 100.0);
                        pricePerPerson = discountedPrice / (groupSize * 1.0);
                        break;

                    case "Platinum":
                        pricePackage = 1000;

                        totalPrice = pricePackage + price;
                        discountedPrice = totalPrice - (totalPrice * 15 / 100.0);
                        pricePerPerson = discountedPrice / (groupSize * 1.0);
                        break;
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            
            Console.WriteLine($"We can offer you the {hallName}\r\nThe price per person is {pricePerPerson:f2}$");
            
        }
      

        
    }
}