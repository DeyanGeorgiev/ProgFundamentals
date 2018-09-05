using System;

namespace P12_RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width= double.Parse(Console.ReadLine());
            double high = double.Parse(Console.ReadLine());

            double perimeter = 2*(high + width);
            double area = high * width;
            double diagonal = Math.Sqrt(Math.Pow(high, 2) + Math.Pow(width, 2));


            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}