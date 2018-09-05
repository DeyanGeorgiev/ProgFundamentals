using System;

namespace P11_GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figType = Console.ReadLine();

            if (figType == "triangle")
            {
                double parameter1 = double.Parse(Console.ReadLine());
                double parameter2 = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:f2}", CalculatorArea(figType, parameter1, parameter2));
            }
            else if (figType == "rectangle")
            {
                double parameter1 = double.Parse(Console.ReadLine());
                double parameter2 = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:f2}", CalculatorArea(figType, parameter1, parameter2));
            }
            else if (figType == "square")
            {
                double parameter1 = double.Parse(Console.ReadLine());
                double parameter2 = 1.0;
                
                Console.WriteLine("{0:f2}", CalculatorArea(figType, parameter1,parameter2));
            }
            else if (figType == "circle")
            {
                double parameter1 = double.Parse(Console.ReadLine());

                double parameter2 = 1.0;
                
                Console.WriteLine("{0:f2}", CalculatorArea(figType, parameter1, parameter2));
            }
        }

        static double CalculatorArea(string type, double parameter1, double parameter2)
        {
            double result = 0;
            if (type == "triangle")
            {
                result = 1.0 / 2.0 * parameter1 * parameter2;
            }
            else if (type == "rectangle")
            {
                result = parameter1 * parameter2;
            }
            else if (type == "square")
            {
                result = Math.Pow(parameter1, 2);
            }
            else if (type == "circle")
            {
                result = Math.PI * parameter1 * parameter1;
            }

            return result;
        }
    }
}