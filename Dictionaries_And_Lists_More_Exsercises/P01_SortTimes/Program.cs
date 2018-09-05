using System;
using System.Collections.Generic;

using System.Globalization;


namespace P01_SortTimes
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine()
                ?.Split();
            
            List<DateTime> result = new List<DateTime>();

            if (input != null)
                for (int i = 0; i < input.Length; i++)
                {
                    var hours = DateTime.ParseExact(input[i], "HH:mm", CultureInfo.InvariantCulture);

                    result.Add(hours);
                }

            result.Sort();
            
            List<string> kkpk= new List<string>();

            foreach (var item in result)
            {
            
                var bau= item.ToString("HH:mm");
                kkpk.Add(bau);
            }

            Console.WriteLine(string.Join(", ", kkpk));

            
        }
    }
}