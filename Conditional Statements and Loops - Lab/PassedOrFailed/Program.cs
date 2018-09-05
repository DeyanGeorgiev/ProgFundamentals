using System;

namespace PassedOrFailed
{
    class Program
    {
        static void Main(string[] args)
        {
            double num= double.Parse(Console.ReadLine());

            Console.WriteLine(num > 2.99 ? "Passed!" : "Failed!");
        }
    }
}