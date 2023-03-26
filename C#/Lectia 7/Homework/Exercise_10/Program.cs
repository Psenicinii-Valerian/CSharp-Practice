namespace Exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a class called "Computer" that has string variables "brand" and "model", a
            // double variable "price", and a method "turnOn" that prints a message indicating
            // that the computer is turning on.Add a static method "comparePrices" that takes
            // two "Computer" objects and returns the one with the lower price

            Computer comp1 = new Computer();
            Console.Write("Enter the brand of the first computer: ");
            string computerBrand = Console.ReadLine();
            comp1.setBrand(computerBrand);

            Console.Write("Enter the model of the first computer: ");
            string computerModel = Console.ReadLine();
            comp1.setModel(computerModel);

            Console.Write("Enter the price(in $) of the first computer: ");
            double computerPrice = Convert.ToDouble(Console.ReadLine());
            comp1.setPrice(computerPrice);

            comp1.turnOn();

            Console.WriteLine();

            Computer comp2 = new Computer();
            Console.Write("Enter the brand of the second computer: ");
            computerBrand = Console.ReadLine();
            comp2.setBrand(computerBrand);

            Console.Write("Enter the model of the second computer: ");
            computerModel = Console.ReadLine();
            comp2.setModel(computerModel);

            Console.Write("Enter the price(in $) of the second computer: ");
            computerPrice = Convert.ToDouble(Console.ReadLine());
            comp2.setPrice(computerPrice);

            comp2.turnOn();

            Console.WriteLine();

            Computer.comparePrices(comp1, comp2);
        }
    }
}