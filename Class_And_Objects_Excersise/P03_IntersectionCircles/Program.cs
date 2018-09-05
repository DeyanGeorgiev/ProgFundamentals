using System;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace P03_doubleersectionCircles
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] firsLine = Console.ReadLine()
                .Split()
            .Select(int.Parse)
                .ToArray();
            
            int[] secondLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstX = firsLine[0];
            int firstY= firsLine[1];
            int firstRadius = firsLine[2];
            int secondX = secondLine[0];
            
            int secondY= secondLine[1];
            int secondRadius = secondLine[2];
            
            Point firstCenter= new Point(firstX, firstY);
            Point secondCenter= new Point(secondX, secondY);
            
            //Circle c1= new Circle(firstCenter, firstRadius);
           // Circle c2 = new Circle(secondCenter, secondRadius);
            
            // calc d= distance between two

            double distcance = Math.Sqrt(Math.Pow((secondCenter.X - firstCenter.Y), 2) +
                                          Math.Pow((secondCenter.Y - firstCenter.Y), 2));
            
            
            if(IsIntersect(distcance, firstRadius, secondRadius))
            {
                Console.WriteLine("Yes");
            }
           
            if(IsIntersect(distcance, firstRadius, secondRadius)== false)
            {
                Console.WriteLine("No");
            }
            
            
            
        }

        public static bool IsIntersect(double d, int r1, int r2)
        {
            //if (d > r1 + r2)


            if (d <= r1 + r2)
            {
                return true;
            }

            return false;
        }
    }

//    class Circle
//    {
//        public Point Center { get; set; }
//        
//
//        public Circle(Point center, double radius)
//        {
//            Center = center;
//            
//        }
//    }

    class  Point 
    {
        public  int X { get; set; }
        public  int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}