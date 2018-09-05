using System;
using System.Linq;

namespace P04_DistanceBetweenTwoPoints
{
    public class ReadPoints
    {
        static int[] pointsInfo = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();


        Points point= new Points(pointsInfo[0], pointsInfo[1]);


        

    }
}