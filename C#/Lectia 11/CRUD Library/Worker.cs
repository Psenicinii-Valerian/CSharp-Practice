using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CRUD_Library
{
    internal class Worker
    {
        string id { get; set; }
        string name { get; set; }
        string lastname { get; set; }
        int age { get; set; }

        public Worker() { }
        public Worker(string id, string name, string lastname, int age)
        {
            this.id = id;

            // Regex name
            string pattern = @"^[A-Z][a-z]{1,15}$";
            Match match = Regex.Match(name, pattern);
            string newName = name;
            while (!match.Success)
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
        }

        public string getWorker()
        {
            return $"Name: {name}\nLastname: {lastname}\nAge: {age}\n";
        }
    }
}
