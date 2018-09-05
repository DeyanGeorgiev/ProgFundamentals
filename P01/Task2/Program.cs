using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            int sum = numOne + numTwo;

            Console.WriteLine("{0} + {1} = {2}", numOne, numTwo, sum);
        }
    }
}
