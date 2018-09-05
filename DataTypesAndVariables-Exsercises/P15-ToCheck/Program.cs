using System;

namespace P15_ToCheck
{
    class Program
    
    // prime number check
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            
            for (int currentNum = 2; currentNum <= num; currentNum++)
            {
                bool isTrue = true;

                for (int devider = 2; devider <= Math.Sqrt(currentNum); devider++)
                {
                    if (currentNum % devider == 0)
                    {
                        isTrue = false;

                        break;
                    }
                }

                Console.WriteLine($"{currentNum} -> {isTrue}");
            }
        }
    }
}