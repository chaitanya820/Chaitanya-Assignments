namespace Assianment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of books:");
            int numberOfBooks = Convert.ToInt32(Console.ReadLine());

            Book[] books = new Book[numberOfBooks];

            for (int i = 0; i < numberOfBooks; i++)
            {
                Console.WriteLine($"Enter details for book {i + 1}:");
                Console.Write("ISBN: ");
                string isbn = Console.ReadLine();
                Console.Write("Book Name: ");
                string bookName = Console.ReadLine();
                Console.Write("Title: ");
                string bookTitle = Console.ReadLine();
                Console.Write("Author: ");
                string bookAuthor = Console.ReadLine();
                Console.Write("Quantity: ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                books[i] = new Book(isbn, bookName, bookTitle, bookAuthor, quantity, price);
            }

            Console.WriteLine("\nBook Details and Total Amount:");
            double totalAmount = 0;
            foreach (var book in books)
            {
                Console.WriteLine($"ISBN: {book.ISBN}, Book Name: {book.BookName}, Title: {book.BookTitle}, Author: {book.BookAuthor}");
                Console.WriteLine($"Quantity: {book.Quantity}, Price: {book.Price}");
                Console.WriteLine($"Total for this book: {book.CalculateTotal()}");

                totalAmount += book.CalculateTotal();
            }
            Console.WriteLine($"Total Amount: {totalAmount}");
        }
    }

    public class Book
    {
        public string ISBN { get; private set; }
        public string BookName { get; private set; }
        public string BookTitle { get; private set; }
        public string BookAuthor { get; private set; }
        public int Quantity { get; private set; }
        public double Price { get; private set; }

        public Book(string isbn, string bookName, string bookTitle, string bookAuthor, int quantity, double price)
        {
            ISBN = isbn;
            BookName = bookName;
            BookTitle = bookTitle;
            BookAuthor = bookAuthor;
            Quantity = quantity;
            Price = price;
        }

        public double CalculateTotal()
        {
            return Quantity * Price;
        }

    }
}

