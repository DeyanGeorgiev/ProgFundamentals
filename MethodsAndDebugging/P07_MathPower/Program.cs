using System;

namespace P07_MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double num= double.Parse(Console.ReadLine());
            double power= double.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(num, power));
        }

        static double MathPower(double num, double power)
        {
            double result = 1.0;

            for (int i = 1; i <= power; i++)
            {
                result *= num;
            }

            return result;
        }
        
        
        
    }
}