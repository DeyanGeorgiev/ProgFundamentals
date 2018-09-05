using System;

namespace P08_RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengh, wight, hight = 0;
            Console.Write("Length: ");
            lengh = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            wight = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            hight = double.Parse(Console.ReadLine());
            hight = ((lengh*wight)*hight)/3;
            Console.WriteLine("Pyramid Volume: {0:F2}", hight);

        }
    }
}
