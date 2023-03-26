using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Car
    {
        string make;
        string model;
        int year;

        public Car()
        {

        }

        public void setMake(string make)
        {
            this.make = make;
        }

        public void setModel(string model)
        {
            this.model = model;
        }

        public void setYear(int year)
        {
            this.year = year;
        }

        public int getYear()
        {
            return this.year;
        }

        public string getMake()
        {
            return this.make;
        }

        public string getModel()
        {
            return this.model;
        }

        public void start()
        {
            Console.WriteLine($"{this.make} {this.model} produced in {this.year} has started!");
        }
    }
}
