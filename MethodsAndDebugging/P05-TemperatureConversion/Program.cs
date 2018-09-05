using System;

namespace P05_TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit= double.Parse(Console.ReadLine());

            double celsius = ReturnFahrenheitToCelsius(fahrenheit);

            Console.WriteLine($"{celsius:f2}");


        }

        static double ReturnFahrenheitToCelsius(double fahrenheit)
        {
            double result = (fahrenheit - 32.0) * 5.0 / 9.0;

            return result;
        }
    }
}