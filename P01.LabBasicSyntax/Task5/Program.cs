using System;

namespace Task5
{
    class Program
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());
            int thirNum = int.Parse(Console.ReadLine());
            int fourNum = int.Parse(Console.ReadLine());

            string secRaw = "|" + new string('|', firstNum) + new string('.', secNum - firstNum) + "|";
            string thirdRaw = "|" + new string('|', thirNum) + new string('.', fourNum - thirNum) + "|";

            Console.WriteLine($"Name: {name}\r\nHealth: {secRaw}\r\nEnergy: {thirdRaw}");
        }
    }
}