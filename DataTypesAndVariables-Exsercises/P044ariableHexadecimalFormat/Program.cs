using System;

namespace P044ariableHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int result = Convert.ToInt32(input, 16);

            Console.WriteLine(result);
        }
    }
}