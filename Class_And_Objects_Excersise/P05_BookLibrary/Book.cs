using System;

namespace P05_BookLibrary
{
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