using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;
using System.Reflection.Emit;

namespace P05_BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> operative = new Dictionary<string, List<double>>();


            for (int i = 0; i < input; i++)
            {
                string[] incomeInfo = Console.ReadLine()
                    .Split()
                    .ToArray();

                DateTime realise = DateTime.Parse(incomeInfo[3]);
                int isdn = int.Parse(incomeInfo[4]);
                double singlePrice = double.Parse(incomeInfo[5]);

                Book book = new Book(incomeInfo[1], incomeInfo[0], incomeInfo[2], realise, isdn, singlePrice);

                //List<double> prices = new List<double>();

                if (operative.ContainsKey(book.Autor) == false)
                {
                    operative.Add(book.Autor, new List<double>());
                    //operative[book.Autor].Add(book.Price);
                    
                }
                
                    operative[book.Autor].Add(book.Price);
                
                
            }


            Dictionary<string, double> endLine = new Dictionary<string, double>();
            foreach (var autor in operative)
            {
                double totalPrice = autor.Value.Sum();
                endLine.Add(autor.Key, totalPrice);
            }

            foreach (var item in endLine.OrderByDescending(y => y.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1:F2}",item.Key ,item.Value);
            }
        }
    }
}