using System;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1= int.Parse(Console.ReadLine());
            int num2= int.Parse(Console.ReadLine());

            int start = Math.Min(num1, num2);
            int final = Math.Max(num1, num2);


            for (int i = start; i <= final; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}