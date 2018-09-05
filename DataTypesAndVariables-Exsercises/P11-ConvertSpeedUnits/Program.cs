using System;

namespace P11_ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int secondsToConvert = hours * 60 * 60 + minutes * 60 + seconds;
            
            float meterPerScecond = (float) distance / secondsToConvert;
            float hoursConverted = (float) (hours + ((minutes / 60.0) + (seconds / 60.0) / 60.0));
            float kmPerHour = ((float) (distance) / 1000) / hoursConverted;
            float milesPerHour = (float) (distance / 1609.0) / hoursConverted;

            Console.WriteLine($"{meterPerScecond}");
            Console.WriteLine($"{kmPerHour}");
            Console.WriteLine($"{milesPerHour}");
        }
    }
}