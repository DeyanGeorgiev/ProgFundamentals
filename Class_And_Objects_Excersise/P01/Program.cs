using System;
using System.Globalization;
using System.Linq;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate= DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.CurrentCulture);
            DateTime endDate= DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.CurrentCulture);

            DateTime[] holidays= {
                new DateTime(2010, 1, 1),
                new DateTime(2010, 3, 3),
                new DateTime(2010, 5, 1),
                new DateTime(2010, 5, 6),
                new DateTime(2010, 5, 24),
                new DateTime(2010, 9, 6),
                new DateTime(2010, 9, 22),
                new DateTime(2010, 11, 1),
                new DateTime(2010, 12, 24),
                new DateTime(2010, 12, 25),
                new DateTime(2010, 12, 26)
            };
            int count = 0;
            for (DateTime day = startDate; day <= endDate; day= day.AddDays(1))
            {
                if (day.DayOfWeek == DayOfWeek.Sunday || day.DayOfWeek == DayOfWeek.Saturday)
                {
                    continue;
                }

                
                DateTime countTime= new DateTime(2010,day.Month, day.Day);
                if (holidays.Contains(countTime) == false)
                {
                    count++;
                }
                
                
            }

            Console.WriteLine(count);
        }
    }
}