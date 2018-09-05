using System;

namespace SnowBall
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int snowBall = int.Parse(Console.ReadLine());


            int maxValue = 0;
            int printSnow = 0;
            int printTime = 0;
            int printQuality = 0;
            

            for (int i = 0; i < snowBall; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                int snowballValue = (int) Math.Pow(snowballSnow / snowballTime, snowballQuality);

                if (snowballValue >= maxValue)
                {
                    maxValue = snowballValue;
                    printSnow = snowballSnow;
                    printTime = snowballTime;
                    printQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{printSnow} : {printTime} = {maxValue} ({printQuality})");
        }
    }
}