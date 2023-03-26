namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a class called "Circle" that has a double variable "radius", and methods
            //"getArea" and "getCircumference" that calculate and return the area and
            //circumference of the circle.

            Circle circle = new Circle();
            Console.Write("Enter the radius of your circle (in cm2): ");
            double circleRadius = Convert.ToDouble(Console.ReadLine());
            circle.setRadius(circleRadius);
            Console.WriteLine("Circle's area = " + Math.Round(circle.getArea(circle.getRadius()), 2) + "cm2");
            Console.WriteLine("Circle's circumference = " + 
                               + Math.Round(circle.getCircumference(circle.getRadius()), 2) + "cm2");
        }
    }
}