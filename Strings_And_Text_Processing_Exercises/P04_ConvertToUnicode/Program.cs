using System;
using System.Linq;

namespace P03_ConvertToUnicode
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            var result = input.Select(t => $"\\u{Convert.ToUInt16(t):X4}").ToList();


            foreach (var item in result)
            {
                Console.Write(item.ToLower());
            }
           

            
        }
    }
}