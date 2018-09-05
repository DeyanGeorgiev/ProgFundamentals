using System;

namespace P02_GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1= int.Parse(Console.ReadLine());
            int num2= int.Parse(Console.ReadLine());
            int num3= int.Parse(Console.ReadLine());

            int max = GetMax(num1, num2);
            int newMax = GetMax(max, num3);
            

            int result = GetMax(max, newMax);

            Console.WriteLine(result);
        }

        static int GetMax(int a, int b)
        {

            int max = 0;
            if (a > b)
            {
                max=a;
            }
            else
            {
                max = b;
            }
            return max;
        }
    }
}
