using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supraincarcarea_functiilor
{
    internal class Rectangle
    {
        public int calculateArea(int length, int width)
        {
            return length * width;
        }

        public double calculateArea(double diagonal, int length)
        {
            return length * Math.Sqrt(Math.Pow(diagonal, 2) - Math.Pow(length, 2));
        }
    }
}
