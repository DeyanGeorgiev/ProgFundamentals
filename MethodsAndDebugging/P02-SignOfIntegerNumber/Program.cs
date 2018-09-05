using System;

namespace P02_SignOfIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num= int.Parse(Console.ReadLine());
            Console.WriteLine(GetNumber(num));
        }

        static string GetNumber(int num)
        {
            string numIs = "";
            if (num > 0)
            {
                numIs= "The number "+num+ " is positive.";
            }
            else if (num < 0)
            {
                numIs= "The number "+num+ " is negative.";
            }
            else
            {
                numIs= "The number "+num+ " is zero.";
            }

            return numIs;
        }
    }
}