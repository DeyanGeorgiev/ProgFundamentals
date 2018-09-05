using System;

namespace P07_Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string lastName= Console.ReadLine();
            int year= int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {name} {lastName}. You are {year} years old.");
        }
    }
}