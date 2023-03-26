namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a class called "Dog" that has string variables "name" and "breed", and a
            //method "bark" that prints a message indicating that the dog is barking.

            Dog dog = new Dog();
            Console.Write("Enter the name of the dog: ");
            string dogName = Console.ReadLine();    
            dog.setName(dogName);

            Console.Write("Enter the breed of the dog: ");
            string dogBreed = Console.ReadLine();
            dog.setBreed(dogBreed);

            dog.bark();

        }
}
}