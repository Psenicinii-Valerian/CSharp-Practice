using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supraincarcarea_constructorilor
{
    internal class Animal
    {
        string name;
        int age;
        string favFood;

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Animal(string name, int age, string favFood)
        {
            this.name = name;
            this.age = age;
            this.favFood = favFood;
        }

        public void showAnimal()
        {
            if (name != null)
            {
                {
                    Console.WriteLine($"Name: {name}");
                }
            }

            if (age > 0)
            {
                {
                    Console.WriteLine($"Age: {age} years old");
                }
            }

            if (favFood != null)
            {
                {
                    Console.WriteLine($"Favourite food: {favFood}");
                }
            }
        }
    }
}
