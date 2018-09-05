using System;
using System.Drawing;
using System.Linq;

namespace P04_DistanceBetweenTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();
            
            double distance = CalcDistance(p1, p2);
            
            Console.WriteLine("{0:f3}", distance);


        }

        private static double CalcDistance(Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

        }

        private static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            Point point = new Point
            {
                X = pointInfo[0],
                Y = pointInfo[1]
            };
            return point;

        }
    }
}