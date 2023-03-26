namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a class called "Car" that has string variables "make" and "model", an
            //integer variable "year", and a method "start" that prints a message indicating that
            //the car has started.

            Car car = new Car();
            Console.Write("Enter the mark of your car: ");
            string carMake = Console.ReadLine();
            car.setMake(carMake);

            Console.Write("Enter the model of your car: ");
            string carModel = Console.ReadLine();   
            car.setModel(carModel);

            Console.Write("Enter the year of your car: ");
            int carYear = Convert.ToInt32(Console.ReadLine());  
            car.setYear(carYear);

            car.start();
        }
    }
}