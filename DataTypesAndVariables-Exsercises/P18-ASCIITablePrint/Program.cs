using System;

namespace P18_ASCIITablePrint
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1= int.Parse(Console.ReadLine());
            int num2= int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                char result = (char) i;
                Console.Write(result+ " ");
            }
        }
    }
}