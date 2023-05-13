using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Library
{
    internal class Library
    {
        string id { get; set; }
        string address { get; set; }

        public List<Book> books = new List<Book>();
        List<Worker> workers = new List<Worker>();
        public List<Client> clients = new List<Client>();
        public Library() { }

        public Library(string id, string address, List<Book> books, List<Worker> workers, List<Client> clients)
        {
            this.id = id;
            this.address = address;
            this.books = books;
            this.workers = workers;
            this.clients = clients;
        }   

        public void getBooks()
        {
            foreach(var book in books)
            {
                Console.WriteLine(book.getBook());
            }
        }

        public void getClients()
        {
            foreach (var client in clients)
            {
                Console.WriteLine(client.getClient());
            }
        }

        public void getWorker()
        {
            foreach (var worker in workers)
            {
                Console.WriteLine(worker.getWorker());
            }
        }

        public void addBook(Book b)
        {
            books.Add(b);
        }

        public void addWorker(Worker w)
        {
            workers.Add(w);
        }

        public void addClient(Client c)
        {
            clients.Add(c);
        }
    }
}
