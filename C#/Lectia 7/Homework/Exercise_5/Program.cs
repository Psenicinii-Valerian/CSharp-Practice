namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a class called "Rectangle" that has integer variables "length" and "width",
            //and methods "getArea" and "getPerimeter" that calculate and return the area and
            //perimeter of the rectangle.

            Rectangle rectangle = new Rectangle();
            Console.Write("Enter the length of the rectangle (in cm2): ");
            int rectangleLength = Convert.ToInt32(Console.ReadLine());
            rectangle.setLength(rectangleLength);

            Console.Write("Enter the width of the rectangle (in cm2): ");
            int rectangleWidth = Convert.ToInt32(Console.ReadLine());
            rectangle.setWidth(rectangleWidth);

            Console.WriteLine($"Rectangle's area: {rectangle.getArea()}cm2");
            Console.WriteLine($"Rectangle's perimeter: {rectangle.getPerimeter()}cm");
        }
    }
}