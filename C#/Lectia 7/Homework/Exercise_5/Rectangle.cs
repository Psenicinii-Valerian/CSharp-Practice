using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    internal class Rectangle
    {
        int length;
        int width;

        public Rectangle()
        {

        }

        public void setLength(int length)
        {
            this.length = length;
        }

        public void setWidth(int width)
        {
            this.width = width;
        }

        public int getLength()
        {
            return this.length;
        }

        public int getWidth()
        {
            return this.width;
        }

        public int getArea() 
        {
            return this.length * this.width;
        }

        public int getPerimeter()
        {
            return (this.length + this.width) * 2;
        }
    }
}
