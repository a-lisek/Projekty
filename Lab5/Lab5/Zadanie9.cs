using System;
using System.Collections.Generic;

namespace Lab5
{
    public class Zadanie9
    {
        public void Wyw9()
        {
            Book b1 = new Book("123p", "T1", "A1", 24.99);

            Book b2 = new Book("113p", "T2", "A2", 24.99);

            Book b3 = new Book("1s23p", "T3", "A3", 24.99);

            Book b4 = new Book("1243p", "T4", "A4", 24.99);

            BookLibrary Lib = new BookLibrary();
            Lib.AddBook(b1);
            Lib.AddBook(b2);
            Lib.AddBook(b3);
            Lib.AddBook(b4);

            Lib.PrintAll();

            List<Book> n1 =  Lib.SearchAuthor("A2");
            foreach (Book b in n1)
            {
                Console.WriteLine("Informacje o ksiazce:");
                Console.WriteLine(b.GetISBN());
                Console.WriteLine(b.GetTitle());
                Console.WriteLine(b.GetAuthor());
                Console.WriteLine();
            }

        }
    }
    public class Book
    {
        string _title;
        string _author;
        double _price;
        string _isbn;
        DateTime _date;

        public Book(string ISBN, string title="", string author = "", double price = 0 , DateTime? date=null)
        {
            _isbn = ISBN;
             _title=title;
             _author=author;
             _price=price;
            if (date.HasValue)
            {
                _date = date.Value;
            }

        }
        public string GetISBN()
        {
            return _isbn;
        }
        public string GetTitle()
        {
            return _title;
        }
        public string GetAuthor()
        {
            return _author;
        }
        public double GetPrice()
        {
            return _price;
        }
    }
    public class BookLibrary
    {
        List<Book> Lib;
        public BookLibrary()
        {
            Lib = new List<Book>();
        }

        public bool isinLib(Book b1)
        {
            if(Lib.FindIndex(b => b.GetISBN() == b1.GetISBN()) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddBook(Book b1)
        {
            if (isinLib(b1))
            {
                Console.WriteLine("ta książka juz jest");
            }
            else
            {
                Lib.Add(b1);
            }
        }
        public void RemoveBook(Book b1)
        {
            Lib.Remove(b1);
        }
        public List<Book> SearchISBN(string isbn)
        {
            return Lib.FindAll(b => b.GetISBN() == isbn);
        }
        public List<Book> SearchTitle(string title)
        {
            return Lib.FindAll(b => b.GetTitle() == title);
        }
        public List<Book> SearchAuthor(string author)
        {
            return Lib.FindAll(b => b.GetAuthor() == author);
        }
        public List<Book> SearchPrice(double price)
        {
            return Lib.FindAll(b => Math.Abs(b.GetPrice() - price) < 0.1);
        }
        public void PrintAll()
        {
            foreach(Book b1 in Lib)
            {
                Console.WriteLine("Informacje o ksiazce:");
                Console.WriteLine(b1.GetISBN());
                Console.WriteLine(b1.GetTitle());
                Console.WriteLine(b1.GetAuthor());
                Console.WriteLine();
            }
        }
    }
}
