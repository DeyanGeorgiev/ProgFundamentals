using System;

namespace P10_MultiplicationTable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numForCalc= int.Parse(Console.ReadLine());
            int num= int.Parse(Console.ReadLine());

            if (num > 10)
            {
                Console.WriteLine($"{numForCalc} X {num} = {num*numForCalc}");
            }
            else
            {
                for (int i = num; i <=10; i++)
                {
                    Console.WriteLine($"{numForCalc} X {i} = {i * numForCalc}");
                }
            }
        }
    }
}