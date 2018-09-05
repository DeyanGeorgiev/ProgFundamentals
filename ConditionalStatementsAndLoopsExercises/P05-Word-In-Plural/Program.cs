using System;

namespace P05_Word_In_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();


            if (word.EndsWith("y"))
            {
                word = word.Replace("y", "ies");
            }

            else if (word.EndsWith("o") || word.EndsWith("s") || word.EndsWith("x") || word.EndsWith("z")|| word.EndsWith("ch")|| word.EndsWith("sh") )

            {
                
                word = word + "es";
            }

           
            else
            {
                word = word + "s";
            }

            Console.WriteLine(word);
        }
    }
}