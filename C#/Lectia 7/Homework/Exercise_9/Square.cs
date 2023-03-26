    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    internal class Square: Rectangle
    {
        int sideLength;

        public Square()
        {   

        }

        public void setSideLength(int sideLength)
        {
            this.sideLength = sideLength;
        }

        public int getSideLength()
        {
            return sideLength;
        }

        public override int getArea()
        {
            return this.sideLength * this.sideLength;
        }

        public override int getPerimeter()
        {
            return 4 * this.sideLength;
        }
    }
}
