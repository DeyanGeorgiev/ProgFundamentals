using System;
using System.Globalization;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int iD = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());


            Console.WriteLine($"Name: {name}\r\nAge: {age}\r\nEmployee ID: {iD:D8}\r\nSalary: {salary:f2}");


        }

    }
}