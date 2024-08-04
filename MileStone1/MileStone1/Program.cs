using System;
using System.Collections.Generic;
using System.Linq;
using Books;

class Program
{
    static List<BooksDetails> books = new List<BooksDetails>();

    static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Book Management System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Display Books");
            Console.WriteLine("3. Delete Book");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    DisplayBooks();
                    break;
                case "3":
                    DeleteBook();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void AddBook()
    {
        try
        {
            BooksDetails newBook = new BooksDetails();
            newBook.AcceptBookDetails();
            books.Add(newBook);
            Console.WriteLine("Book added successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    static void DisplayBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available.");
        }
        else
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Book ID: {book.BookID}");
                Console.WriteLine($"Book Name: {book.BookName}");
                Console.WriteLine($"ISBN No: {book.ISBNNo}");
                Console.WriteLine($"Price: {book.Price}");
                Console.WriteLine($"Publisher: {book.Publisher}");
                Console.WriteLine($"Number of Pages: {book.NumberOfPages}");
                Console.WriteLine($"Language: {book.Language}");
                Console.WriteLine($"LoT: {book.LoT}");
                Console.WriteLine($"Summary: {book.Summary}");
                Console.WriteLine();
            }
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    static void DeleteBook()
    {
        Console.Write("Enter Book ID to delete: ");
        string bookID = Console.ReadLine();
        var bookToRemove = books.FirstOrDefault(b => b.BookID == bookID);

        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
            Console.WriteLine("Book deleted successfully!");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}