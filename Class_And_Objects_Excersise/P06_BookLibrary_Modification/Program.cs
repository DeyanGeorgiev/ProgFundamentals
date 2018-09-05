using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P06_BookLibrary_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Dictionary<string, DateTime> operative = new Dictionary<string, DateTime>();
            


            for (int i = 0; i < input; i++)
            {
                string[] incomeInfo = Console.ReadLine()
                    .Split()
                    .ToArray();

                DateTime realise = DateTime.ParseExact(incomeInfo[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                int isdn = int.Parse(incomeInfo[4]);
                double singlePrice = double.Parse(incomeInfo[5]);

                Book book = new Book(incomeInfo[1], incomeInfo[0], incomeInfo[2], realise, isdn, singlePrice);
               


                if (operative.ContainsKey(book.Title) == false)
                {
                    operative.Add(book.Title, book.RealiseDate);
                }

               
            }


            DateTime checkerDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);


            foreach (var item in operative.OrderBy(v => v.Value).ThenBy(k => k.Key))

            {
                if (item.Value > checkerDate)
                    Console.WriteLine($"{item.Key} -> {item.Value.ToString("dd.MM.yyyy")}");
            }
        }
    }

    public class Book
    {
        public Book(string autor, string title, string publisher, DateTime realiseDate, int isdn, double price)
        {
            Autor = autor;
            Title = title;
            Publisher = publisher;
            RealiseDate = realiseDate;
            Isdn = isdn;
            Price = price;
        }

        public Book(string autor, double price)
        {
            Autor = autor;
            Price = price;
        }

        public string Autor { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public DateTime RealiseDate { get; set; }
        public int Isdn { get; set; }
        public double Price { get; set; }
    }

    
}