using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Assisment_7
{
        public class BookStore
        {
            private Dictionary<int, string> _books = new Dictionary<int, string>();

            public void AddBook(int id, string name)
            {
                if (_books.ContainsKey(id))
                {
                    Console.WriteLine($"A book with ID {id} already exists.");
                    return;
                }

                _books.Add(id, name);
                Console.WriteLine($"Added book with ID {id}: {name}");
            }

            public void DisplayBooks()
            {
                foreach (var book in _books)
                {
                    Console.WriteLine($"ID: {book.Key}, Name: {book.Value}");
                }
            }
        }
       class Program
        {
            static void Main(string[] args)
            {
                BookStore bookstore = new BookStore();

                // Adding books
                bookstore.AddBook(1, "book name");
                bookstore.AddBook(2, "1984");
                bookstore.AddBook(3, "Authoer");

                // Displaying books
                Console.WriteLine("Current Books:");
                bookstore.DisplayBooks();
            }
        }
}

