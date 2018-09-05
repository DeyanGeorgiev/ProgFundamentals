using System;
using System.Numerics;


namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte num1= sbyte.Parse(Console.ReadLine());
            byte num2 = byte.Parse(Console.ReadLine());
            short num3 = short.Parse(Console.ReadLine());
            ushort num4 = ushort.Parse(Console.ReadLine());
            long  num5= long.Parse(Console.ReadLine());
            BigInteger num6= BigInteger.Parse(Console.ReadLine());
            BigInteger num7 = BigInteger.Parse(Console.ReadLine());


            Console.WriteLine(num1+Environment.NewLine+
                              num2+Environment.NewLine+
                              num3+Environment.NewLine+
                              num4+Environment.NewLine+
                              num5+Environment.NewLine+
                              num6+Environment.NewLine+
                              num7 );
            




        }
    }
}