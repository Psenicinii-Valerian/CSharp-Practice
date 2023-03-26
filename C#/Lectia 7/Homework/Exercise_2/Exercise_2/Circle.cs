using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercise_2
{
    internal class Circle
    {
        double radius;
        public Circle()
        {
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return this.radius;
        }

        public double getArea(double radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }

        public double getCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }
}
