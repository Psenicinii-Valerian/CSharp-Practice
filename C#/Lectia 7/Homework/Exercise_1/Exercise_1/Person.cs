
namespace Exercise_1
{
    internal class Person
    {
        string name;
        int age;

        public Person()
        {
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        } 

        public void greet ()
        {
            Console.WriteLine($"Name: {name}, age: {age} y.o.");
        }
    }
}
