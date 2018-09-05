using System;
using System.Linq;

namespace P03_SumMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLenght= int.Parse(Console.ReadLine());
            int[] input= new int[arrLenght];
            
            for (int i = 0; i < input.Length; i++)
            {
                input[i]= int.Parse(Console.ReadLine());
            }

            var sum = input.Sum();
            var min = input.Min();
            var max = input.Max();
            var aver = input.Average();
            var first = input.First();
            var last = input.Last();

            Console.WriteLine($"Sum = {sum}"+Environment.NewLine+$"Min = {min}"+ Environment.NewLine+
            $"Max = {max}\r\nAverage = {aver}");





        }
    }
}