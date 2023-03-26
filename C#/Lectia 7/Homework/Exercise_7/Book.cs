using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    internal class Book
    {
        string title;
        string author;
        int pages;

        public Book()
        {

        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public void setAuthor(string author)
        {
            this.author = author;
        }

        public void setPages(int pages)
        {
            this.pages = pages;
        }

        public string getTitle()
        {
            return this.title;
        }

        public string getAuthor()
        {
            return this.author;
        }

        public int getPages()
        {
            return this.pages;
        }

        public void read()
        {
            Console.WriteLine($"The book \"{this.title}\" written by {this.author} ({this.pages} pages) is being read");
        }
    }
}
