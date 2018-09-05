using System;

namespace P04_DrawFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            PrintBotomAndTop(num);
            for (int i = 0; i < num-2; i++)
            {
                PrintMiddle(num);
            }
            PrintBotomAndTop(num);
            
            
        }

        static void PrintBotomAndTop(int num)
        {
            Console.WriteLine(new string('-', num*2));
           
        }

        static void PrintMiddle(int num)
        {
            Console.Write("-");

            for (int i = 1; i < num; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine("-");
        }
    }
}