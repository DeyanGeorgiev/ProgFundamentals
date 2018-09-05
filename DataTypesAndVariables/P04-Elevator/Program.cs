using System;

namespace P04_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1= int.Parse(Console.ReadLine());
            int num2= int.Parse(Console.ReadLine());

            int result = num1 / num2;

            if (num1 % num2 != 0)
            {
                result += 1;
            }

            Console.WriteLine(result);
        }
    }
}