using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Dog
    {
        string name;
        string breed;

        public Dog()
        {

        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setBreed(string breed)
        {
            this.breed = breed;
        }

        public string getName()
        {
            return this.name;
        }

        public string getBreed()
        {
            return this.breed;
        }

        public void bark()
        {
            Console.WriteLine($"The {this.breed} called {this.name} is barking!");
        }

    }
}
