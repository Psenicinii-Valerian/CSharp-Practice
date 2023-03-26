using System.Drawing;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a class called "Rectangle" that has integer variables "length" and "width",
            //and methods "getArea" and "getPerimeter" that calculate and return the area and
            //perimeter of the rectangle.

            Square square = new Square();
            Console.Write("Enter the side length of the square (in cm2): ");
            int squareSideLength = Convert.ToInt32(Console.ReadLine());
            square.setSideLength(squareSideLength);        

            Console.WriteLine($"Square's area: {square.getArea()}cm2");
            Console.WriteLine($"Square's perimeter: {square.getPerimeter()}cm");
        }
    }
}