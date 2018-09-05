using System;


namespace CakeIngradients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingradients = Console.ReadLine();

            int count = 0;


            while (ingradients != "Bake!")
            {
                count++;

                Console.WriteLine("Adding ingredient {0}.", ingradients);
                ingradients = Console.ReadLine();
            }

            Console.WriteLine("Preparing cake with {0} ingredients.", count);
        }
    }
}