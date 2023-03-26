using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supraincarcarea_constructorilor
{
    internal class Pers
    {
        string name;
        string lastname;
        int age;
        string gender;

        public Pers(string name)
        {
            this.name = name;
        }

        public Pers(string name, string lastname)
        {
            this.name = name;
            this.lastname = lastname;
        }

        public Pers(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public void showPers()
        {
            if (name != null)
            {
                Console.WriteLine($"Name: {name}");
            }

            {

            if (lastname != null)
                {
                    Console.WriteLine($"Lastname: {lastname}");
                }
            }

            if (age > 0)
            {
                Console.WriteLine($"Age: {age} years old");
            }

            if (gender != null)
            {
                Console.WriteLine($"Gender: {gender}");
            }
        }
    }
}
