using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume= double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar= double.Parse(Console.ReadLine());

            double calcKcal = (volume * energy) / 100;
            double calcSugar = (volume * sugar) / 100;

            Console.WriteLine("{0}ml {1}:\r\n{2}kcal, {3}g sugars", volume, name, calcKcal, calcSugar  );
            
        }
    }
}