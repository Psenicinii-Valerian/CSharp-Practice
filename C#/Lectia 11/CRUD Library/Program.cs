namespace CRUD_Library
{
    internal class Program
    {
        public static Client addClient()
        {
            string id, name, lastname;
            int age;

            Console.Write("ID:: ");
            id = Console.ReadLine();

            Console.Write("Name:: ");
            name = Console.ReadLine();

            Console.Write("Lastname:: ");
            lastname = Console.ReadLine();

            Console.Write("Age:: ");
            age = Convert.ToInt32(Console.ReadLine());

            return new Client(id, name, lastname, age, new List<Book>() { });
        }

        public static Book addBook()
        {
            string id, title, author;
            int pages;
            double price;

            Console.Write("ID:: ");
            id = Console.ReadLine();

            Console.Write("Title:: ");
            title = Console.ReadLine();

            Console.Write("Author:: ");
            author = Console.ReadLine();

            Console.Write("Pages:: ");
            pages = Convert.ToInt32(Console.ReadLine());

            Console.Write("Price:: ");
            price = Convert.ToDouble(Console.ReadLine());

            return new Book(id, title, author, pages, price);
        }

        public static void sellBook(Library library)
        {
            int bookIndex, clientIndex;
            Console.Write("Book Index:: ");
            bookIndex = Convert.ToInt32(Console.ReadLine());
            Console.Write("Client Index:: ");
            clientIndex = Convert.ToInt32(Console.ReadLine());

            library.clients[clientIndex].books.Add(library.books[bookIndex]);
        }
        public static void showBooks(Library library)
        {
            int clientIndex;
            Console.Write("Client Index:: ");
            clientIndex = Convert.ToInt32(Console.ReadLine());

            foreach (var book in library.clients[clientIndex].books)
            {
                Console.WriteLine(book.getBook());
            }
        }

        
        static void Main(string[] args)
        {
            // CRUD Library - recap
            // 1. Book Class
            // 2. Client Class
            // 3. Library Class
            // 4. Worker Class

            /*
                Book b1 = new Book();
                Client c1 = new Client("1", "1", "2", 20, new List<Book>() {});
            */

            Library library1 = new Library(
                "L1",
                "Decebal 199",
                new List<Book>()
                {
                    new Book("B1", "Idiot", "Dostoevskiy", 650, 90),
                    new Book("B2", "Sapiens", "Yuval Noah Harari", 270, 400),
                    new Book("B3", "C++ for dummies", "Unknown", 100, 1000)
                },

                new List<Worker>()
                {
                    new Worker("W1", "Ana", "Maria", 20),
                    new Worker("W2", "Antonela", "Lungu", 36)
                },

                new List<Client>()
                {
                    new Client("C1", "Costel", "Mandru", 24, new List<Book>() {}),
                    new Client("C2", "Valeria", "Anuca", 17, new List<Book>() {})
                }
            );

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Show everything");
                Console.WriteLine("2. Add client");
                Console.WriteLine("3. Add book");
                Console.WriteLine("4. Sell book");
                Console.WriteLine("5. Show books");
                char choice;
                Console.Write("Enter your choice:: ");
                choice = Console.ReadLine()[0];

                switch (choice)
                {
                    case '1':
                        Console.Clear();
                        library1.getBooks();
                        Console.WriteLine("***********************************\n");
                        library1.getClients();
                        Console.WriteLine("***********************************\n");
                        library1.getWorker();
                        Console.WriteLine("Enter any key to continue: ");
                        choice = Console.ReadLine()[0];
                        break;

                    case '2':
                        Console.Clear();
                        library1.addClient(addClient());
                        Console.WriteLine("Enter any key to continue: ");
                        choice = Console.ReadLine()[0];
                        break;

                    case '3':
                        Console.Clear();
                        library1.addBook(addBook());
                        Console.WriteLine("Enter any key to continue: ");
                        choice = Console.ReadLine()[0];
                        break;

                    case '4':
                        Console.Clear();
                        sellBook(library1);
                        Console.WriteLine("Enter any key to continue: ");
                        choice = Console.ReadLine()[0];
                        break;

                    case '5':
                        Console.Clear();
                        showBooks(library1);
                        Console.WriteLine("Enter any key to continue: ");
                        choice = Console.ReadLine()[0];
                        break;
                }
            }
        }
    }
}