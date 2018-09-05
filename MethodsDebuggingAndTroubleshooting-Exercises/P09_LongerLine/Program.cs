using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace P09_LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is one line
            double x1 = double.Parse(Console.ReadLine()); //2
            double y1 = double.Parse(Console.ReadLine()); //4
            double x2 = double.Parse(Console.ReadLine()); //-1
            double y2 = double.Parse(Console.ReadLine()); //2
            // this is other line
            double x3 = double.Parse(Console.ReadLine()); //-5
            double y3 = double.Parse(Console.ReadLine()); //-5
            double x4 = double.Parse(Console.ReadLine()); //4
            double y4 = double.Parse(Console.ReadLine()); //-3


            if (LenghtLine(x1, y1, x2, y2) >= LenghtLine(x3, y3, x4, y4))
            {
                Console.WriteLine("({0}, {1})({2}, {3})", GetClosest(x1, y1, x2, y2).Item1,
                    GetClosest(x1, y1, x2, y2).Item2, GetClosest(x1, y1, x2, y2).Item3,
                    GetClosest(x1, y1, x2, y2).Item4);
            }

            
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", GetClosest(x3, y3, x4, y4).Item1,
                    GetClosest(x3, y3, x4, y4).Item2, GetClosest(x3, y3, x4, y4).Item3,
                    GetClosest(x3, y3, x4, y4).Item4);
            }
        }

        static double LenghtLine(double pX1, double pY1, double pX2, double pY2)
        {
            double lineLenght = Math.Sqrt((pX1 - pX2) * (pX1 - pX2) + (pY1 - pY2) * (pY1 - pY2));

            return lineLenght;
        }

        static Tuple<double, double, double, double> GetClosest(double x1, double y1, double x2, double y2)
        {
            if (Math.Abs(x1) <= Math.Abs(x2) && Math.Abs(y1) <= Math.Abs(y2))
            {
                return Tuple.Create(x1, y1, x2, y2);
            }
            
                return Tuple.Create(x2, y2, x1, y1);
            

           
        }
    }
}

// todo: need improvement LongerLine