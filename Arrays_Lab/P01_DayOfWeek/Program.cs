using System;

namespace P01_DayOfWeek
{
    class Program
    {
        static void Main()
        {
            int day = int.Parse(Console.ReadLine());
            string[] dayOfWeek = new string[7]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            
            if (day >= 1 && day <= 7)
            {
                
                Console.WriteLine(dayOfWeek[day-1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}