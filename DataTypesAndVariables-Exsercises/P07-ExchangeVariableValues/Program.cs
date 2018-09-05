using System;

namespace P07_ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1= 5;
            int num2= 10;

            Console.WriteLine("Before:"+Environment.NewLine+"a = "+num1 + Environment.NewLine + "b = " + num2);

            int temp = 0;
            if (num1 < num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }

            Console.WriteLine("After:"+Environment.NewLine+"a = "+num1 + Environment.NewLine + "b = " + num2);
        }
    }
}