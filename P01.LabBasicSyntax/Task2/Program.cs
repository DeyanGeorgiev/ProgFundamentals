using System;

namespace Task2
{
    class Program
    {
        private static void Main()
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2= double.Parse(Console.ReadLine());
            double sum = num1 * num2;

            Console.WriteLine($"{sum:F2}");
        }
    }
}