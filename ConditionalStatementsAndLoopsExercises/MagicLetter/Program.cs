using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
           
            char firstLetter= char.Parse(Console.ReadLine());
            char secLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());
            

            for (char i = firstLetter; i <= secLetter; i++)
            {
                for (char j = firstLetter; j <= secLetter; j++)
                {
                    for (char k = firstLetter; k <= secLetter; k++)
                    {

                        bool firstCheck = i.Equals(thirdLetter);
                        bool secCheck = j.Equals(thirdLetter);
                        bool thirdCheck = k.Equals(thirdLetter);

                        if (firstCheck == false && secCheck == false && thirdCheck == false)
                        {
                            string first = i.ToString();
                            string sec = j.ToString();
                            string third = k.ToString();
                            Console.Write("{0}{1}{2} ",first, sec, third);
                        }
                    }
                }
            }
            
            
        }
    }
}