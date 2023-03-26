using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    internal class Computer
    {
        string brand;
        string model;
        double price;

        public Computer()
        {

        }

        public void setBrand(string brand)
        {
            this.brand = brand;
        } 

        public void setModel(string model)
        {
            this.model = model;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public string getBrand()
        {
            return this.brand;
        }

        public string getModel()
        {
            return this.model;
        }

        public double getPrice()
        {
            return this.price;
        }

        public void turnOn()
        {
            Console.WriteLine($"{this.brand} {this.model} that costs {this.price}$ has been turned on!");
        }

        public static void comparePrices(Computer comp1, Computer comp2)
        {
            if (comp1.price > comp2.price)
            {
                Console.WriteLine("First computer is more expansive!");
            } else
            {
                Console.WriteLine("The second computer is more expansive!");
            }
        }
    }
}
