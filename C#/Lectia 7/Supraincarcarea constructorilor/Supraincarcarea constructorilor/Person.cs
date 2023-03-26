using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supraincarcarea_constructorilor
{
    internal class Person
    {
        private string name;
        private string lastname;
        private string email;
        private string country;
        private string address;
        private string hobby;
        private int age;
        private string[] friends = {};

        public Person()
        {
            this.name = "Unknown";
            this.lastname = "Name";
        }

        public Person(string name, string lastname, string email)
        {
            this.name = name;
            this.lastname = lastname;
            this.email = email;
        }

        public Person(string name, string lastname, string email, string address, string country)
        {
            this.name = name;
            this.lastname = lastname;
            this.email = email;
            this.address = address;
            this.country = country;
        }

        public Person(string name, string lastname, string email, string address, string country, int age, string[] friends, string hobby)
        {
            this.name = name;
            this.lastname = lastname;
            this.email = email;
            this.address = address;
            this.country = country;
            this.age = age;
            this.friends = friends;
            this.hobby = hobby;
        }

        public void showPerson()
        {
            if (name != null)
            {
                Console.WriteLine($"Name: {name}");
            }

            if (lastname != null)
            {
                Console.WriteLine($"Lastame: {lastname}");
            }

            if (email != null)
            {
                Console.WriteLine($"Email: {email}");
            }

            if (address != null)
            {
                Console.WriteLine($"Address: {address}");
            }

            if (country != null)
            {
                Console.WriteLine($"Country: {country}");
            }

            if (age > 0)
            {
                Console.WriteLine($"Age: {age} years old");
            }

            if (friends.Length > 0)
            {
                Console.WriteLine("Friends::");
                foreach(string friend in friends)
                {
                    Console.WriteLine(friend);
                }
            }

            if (hobby != null)
            {
                Console.WriteLine($"Hobby: {hobby}");
            }
        }
    }   
}
