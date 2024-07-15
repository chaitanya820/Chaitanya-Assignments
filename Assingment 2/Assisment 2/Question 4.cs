using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static Assisment_2.Question_4;
using static System.Formats.Asn1.AsnWriter;

namespace Assisment_2
{
    internal class Question_4
    {
        public class Book
        {
            public string ISBN { get; set; }
            public string BookName { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public int QuantityOfBooks { get; set; }
            public decimal BookPrice { get; set; }
            public decimal CalculateTotalCost()
            {
                return BookPrice * QuantityOfBooks;
            }

            
            public void DisplayDetails()
            {
                Console.WriteLine($"ISBN: {ISBN}");
                Console.WriteLine($"Book Name: {BookName}");
                Console.WriteLine($"Title: {Title}");
                Console.WriteLine($"Author: {Author}");
                Console.WriteLine($"Quantity: {QuantityOfBooks}");
                Console.WriteLine($"Price per book: {BookPrice}");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                
                Book myBook = new Book
                {
                    ISBN = "1234567890",
                    BookName = "The children tails",
                    Title = "jungle book",
                    Author = "Rudyard Kipling",
                    QuantityOfBooks = 5,
                    BookPrice = 500m
                };

                
                myBook.DisplayDetails();

                
                decimal totalCost = myBook.CalculateTotalCost();
                Console.WriteLine($"Total Cost:RS {totalCost:F2}");
            }
        }
    }
}
