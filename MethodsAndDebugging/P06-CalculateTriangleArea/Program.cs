using System;

namespace P06_CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double b= double.Parse(Console.ReadLine());
            double h= double.Parse(Console.ReadLine());

            double result = GetArea(b, h);

            Console.WriteLine(result);
        }

        static double GetArea(double b, double h)
        {
            double areaCalc = (b * h) / 2;

            return areaCalc;
        }
    }
}