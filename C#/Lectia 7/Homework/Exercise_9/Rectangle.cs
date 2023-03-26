using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
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

        public virtual int getArea()
        {
            return this.length * this.width;
        }

        public virtual int getPerimeter()
        {
            return (this.length + this.width) * 2;
        }
    }
}
