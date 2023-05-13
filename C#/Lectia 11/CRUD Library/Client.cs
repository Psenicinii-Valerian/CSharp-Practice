using System.Text.RegularExpressions;

namespace CRUD_Library
{
    internal class Client
    {
        string id { get; set; }
        string name { get; set; }
        string lastname { get; set; }
        int age { get; set; }

        public List<Book> books = new List<Book>();

        public Client() { }
        public Client(string id, string name, string lastname, int age, List<Book> books)
        {
            this.id = id;

            // Regex name
            string pattern = @"^[A-Z][a-z]{1,15}$";
            Match match = Regex.Match(name, pattern);
            string newName = name;
            while(!match.Success)
            {
                Console.Write("Enter a new name:: ");
                newName = Console.ReadLine();
                match = Regex.Match(newName, pattern);
            }
            this.name = newName; // or this.name = match.Value

            // Regex lastname
            match = Regex.Match(lastname, pattern);
            string newLastname = lastname;
            while (!match.Success)
            {
                Console.Write("Enter a new lastname:: ");
                newLastname = Console.ReadLine();
                match = Regex.Match(newLastname, pattern);
            }
            this.lastname = newLastname;
            // Regex end

            this.age = age;
            this.books = books;
        }

        public string getClient()
        {
            return $"Name: {name}\nLastname: {lastname}\nAge: {age}\n";
        }

        public void getClientBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book.getBook());
            }
        }
    }
}
