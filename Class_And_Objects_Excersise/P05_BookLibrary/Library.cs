using System.Collections.Generic;

namespace P05_BookLibrary
{
    public class Library
    {
        public string Book { get; set; }
        public List<Book> Books { get; set; }

        public Library(string book, List<Book> books)
        {
            Book = book;
            Books = books;
        }
    }
}