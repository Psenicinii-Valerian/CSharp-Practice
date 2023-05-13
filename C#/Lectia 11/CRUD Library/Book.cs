using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Library
{
    internal class Book
    {
        string id { set; get; }
        string title { set; get; }
        string author { set; get; }
        int pages { set; get; }
        double price { set; get; }

        public Book() { }
        public Book(string id, string title, string author, int pages, double price)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.price = price;
        }

        public string getBook()
        {
            return $"Book: {id}\nTitle: {title}\nAuthor: {author}\nPages: {pages}\nPrice: {price}\n";
        }
    }
}
