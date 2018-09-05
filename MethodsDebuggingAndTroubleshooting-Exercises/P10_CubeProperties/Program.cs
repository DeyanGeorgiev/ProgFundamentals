using System;

namespace P10_CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string cubeParameter = Console.ReadLine();

            if (cubeParameter == "face")
            {
                Console.WriteLine($"{CubeFace(cubeSide):f2}");
            }
            else if (cubeParameter == "space")
            {
                Console.WriteLine($"{CubeSpaceDiagonal(cubeSide):f2}");
            }
            else if (cubeParameter == "volume")
            {
                Console.WriteLine($"{CubeVolume(cubeSide):f2}");
            }
            else if (cubeParameter == "area")
            {
                Console.WriteLine($"{CubeSurface(cubeSide):f2}");
            }
        }


        static double CubeFace(double side)
        {
            double result = Math.Sqrt(2 * Math.Pow(side, 2));

            return result;
        }

        static double CubeSpaceDiagonal(double side)
        {
            double result = Math.Sqrt(3 * Math.Pow(side, 2));

            return result;
        }

        static double CubeVolume(double side)
        {
            double result = Math.Pow(side, 3);

            return result;
        }

        static double CubeSurface(double side)
        {
            double result = 6 * Math.Pow(side, 2);

            return result;
        }
    }
}

