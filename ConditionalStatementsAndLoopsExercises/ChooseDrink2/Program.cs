using System;

namespace ChooseDrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffesion = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            

            if (proffesion == "Athlete")
            {
                double price = 0.7 * quantity;

                Console.WriteLine($"The {proffesion} has to pay {price:f2}.");

            }
            else if (proffesion == "Businessman" || proffesion== "Businesswoman")
            {
                double price = 1.0 * quantity;

                Console.WriteLine($"The {proffesion} has to pay {price:f2}.");
            }
            else if (proffesion == "SoftUni Student")
            {
                double price = 1.7 * quantity;

                Console.WriteLine($"The {proffesion} has to pay {price:f2}.");
            }
            else 
            {
                double price = 1.2 * quantity;

                Console.WriteLine($"The {proffesion} has to pay {price:f2}.");
            }
        }
    }
}