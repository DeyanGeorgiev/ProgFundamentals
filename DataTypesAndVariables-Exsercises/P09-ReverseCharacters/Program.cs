using System;

namespace P09_ReverseCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstCh = char.Parse(Console.ReadLine());
            char secondCh = char.Parse(Console.ReadLine());
            char thirdCh = char.Parse(Console.ReadLine());


            Console.WriteLine(thirdCh+""+secondCh+""+firstCh);
            
        }
    }
}