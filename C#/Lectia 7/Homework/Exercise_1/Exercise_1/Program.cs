
namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // Create a class called "Person" that has a string variable "name", an integer
            // variable "age", and a method "greet" that prints a message with the person's
            // name and age.

            Person pers = new Person("Mike", 23);
            pers.greet();
        }
    }
}