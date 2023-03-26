using System.Net.NetworkInformation;

namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a class called "Book" that has string variables "title" and "author", and
            //integer variable "pages", and a method "read" that prints a message indicating
            //that the book is being read.

            Book book = new Book();
            Console.Write("Enter book's title: ");
            string bookTitle = Console.ReadLine();
            book.setTitle(bookTitle);

            Console.Write("Enter book's author: ");
            string bookAuthor = Console.ReadLine();
            book.setAuthor(bookAuthor);

            Console.Write("Enter book's number of pages: ");
            int bookPages = Convert.ToInt32(Console.ReadLine());
            book.setPages(bookPages);

            book.read();
        }
    }
}