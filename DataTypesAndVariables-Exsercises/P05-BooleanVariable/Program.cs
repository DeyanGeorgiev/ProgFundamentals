using System;

namespace P05_BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string input =Console.ReadLine();

            bool result = Convert.ToBoolean(input);

            if (result)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


        }
    }
}