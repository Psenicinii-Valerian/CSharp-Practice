using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace Supraincarcarea_constructorilor
{
    internal class App
    {
        static void Main(string[] args)
        {
            /*        
                1) Create a class called "Rectangle" that has two constructors. The first constructor 
                   should take two integers representing the length and width of the rectangle. 
                   The second constructor should take a double representing the length of the rectangle's diagonal. 
                   In both constructors, calculate and store the area of the rectangle. This exercise demonstrates 
                   constructor overloading with different parameter types.

                2) Create a class called "BankAccount" that has two constructors.The first constructor 
                   should take a string representing the name of the account holder and an integer representing 
                   the initial balance.The second constructor should take a string representing the name of the 
                   account holder, an integer representing the initial balance, and a boolean indicating whether 
                   or not the account is a foreign account. If it is, apply a conversion rate to the balance.
                   This exercise demonstrates constructor overloading with different parameter numbers.

                3) Create a class called "Student" that has two constructors.The first constructor 
                   should take a string representing the name of the student, and an array of integers 
                   representing their grades. The second constructor should take a string representing the 
                   name of the student, an integer representing their age, and an array of integers representing 
                   their grades. In both constructors, calculate and store the average grade of the student.
                   This exercise demonstrates constructor overloading with different parameter types and numbers.

                4) Create a class called "Person" that has three constructors.The first constructor 
                   should take a string representing the name of the person.The second constructor should 
                   take two strings representing the first and last name of the person. The third constructor 
                   should take a string representing the name of the person, an integer representing their age, 
                   and a string representing their gender. This exercise demonstrates constructor overloading 
                   with different parameter types and numbers.

                5) Create a class called "Animal" that has two constructors.The first constructor 
                   should take a string representing the name of the animal, and an integer representing their age. 
                   The second constructor should take a string representing the name of the animal, an integer 
                   representing their age, and a string representing their favorite food.This exercise demonstrates 
                   constructor overloading with different parameter types and numbers.
            */

            Console.WriteLine("\n*****************************TASK 1*****************************\n");
            List<Rectangle> rectangles = new List<Rectangle>()
            {
                new Rectangle(7, 9),
                new Rectangle(8.8, 5)
            };

            foreach(var rectangle in rectangles)
            {
                rectangle.showRectangleArea();
            }

            Console.WriteLine("\n*****************************TASK 2*****************************\n");
            List<BankAccount> bankAccounts = new List<BankAccount>()
            {
                new BankAccount("Mickael", 1300),
                new BankAccount("Jack", 20875, true)
            };

            foreach (var acc in bankAccounts)
            {
                acc.showBankAccount();
                Console.WriteLine();
            }

            Console.WriteLine("\n*****************************TASK 3*****************************\n");
            List<Student> students = new List<Student>()
            {
                new Student("Bob", new int[] {7, 8, 10, 6}),
                new Student("Daniel", 21, new int[] {9, 9, 8, 10, 5})
            };

            foreach (var stud in students)
            {
                stud.showStudent();
                Console.WriteLine();
            }

            Console.WriteLine("\n*****************************TASK 4*****************************\n");
            List<Pers> people = new List<Pers>()
            {
                new Pers("Samantha"),
                new Pers("John", "Smith"),
                new Pers("Nick", 25, "male")
            };

            foreach (var pers in people)
            {
                pers.showPers();
                Console.WriteLine();
            }

            Console.WriteLine("\n*****************************TASK 5*****************************\n");
            List<Animal> animals = new List<Animal>()
            {
                new Animal("Tiger", 7),
                new Animal("Lion", 5, "meat"),
            };

            foreach (var animal in animals)
            {
                animal.showAnimal();
                Console.WriteLine();
            }
        }
    }
}
