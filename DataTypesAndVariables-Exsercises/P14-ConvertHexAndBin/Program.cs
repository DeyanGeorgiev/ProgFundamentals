using System;

namespace P14_ConvertHexAndBin
{
    class Program
    {
        static void Main(string[] args)
        {
           int num = int.Parse(Console.ReadLine());

            string toHex = Convert.ToString(num, 16).ToUpper();

            string toBin = Convert.ToString(num, 2);

            Console.WriteLine(toHex);
            Console.WriteLine(toBin);
        }
    }
}