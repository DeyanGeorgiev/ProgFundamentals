using System;

namespace P16_ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1= double.Parse(Console.ReadLine());
            double num2= double.Parse(Console.ReadLine());

            double eps = 0.000001;

            double result = Math.Abs(num1 - num2);


            if (result >= eps)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
        }
    }
}