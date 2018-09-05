using System;

namespace P11_OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            
                for (int i = 0; i < 10; i++)
                {
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("Please write an odd number.");
                        num = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("The number is: {0}", Math.Abs(num));
                        break;
                    }
                }
            }
        }
    }
