using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                ;

            Random random = new Random();
            
            for (int i = 0; i < input.Length; i++)
            {

                int pos1 = random.Next(0, input.Length);
                int pos2 = random.Next(0, input.Length);
                    

                string temp = input[pos1];
                 input[pos1]= input[pos2];
                input[pos2] = temp;

                
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}