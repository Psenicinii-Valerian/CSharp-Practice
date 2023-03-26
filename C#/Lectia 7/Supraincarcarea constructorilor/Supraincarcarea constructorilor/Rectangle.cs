using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supraincarcarea_constructorilor
{
    internal class Rectangle
    {
        int length;
        int width;
        double diagonal;
        double rectangleArea;

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
            this.rectangleArea = width * length;
        }

        public Rectangle(double diagonal, int length)
        {
            this.diagonal = diagonal;
            this.length = length;
            this.rectangleArea = length * Math.Sqrt(Math.Pow(diagonal, 2) - Math.Pow(length, 2));

        }

        public void showRectangleArea()
        {
            if (length > 0 && width > 0)
            {
                Console.WriteLine($"Knowing the diagonal and length, rectangle's area = {rectangleArea}cm2");
            }

            if (diagonal > 0 && length > 0)
            {
                Console.WriteLine($"Knowing the diagonal and length, rectangle's area = {Math.Round(rectangleArea,2)}cm2");
            }
        }
    }
}
