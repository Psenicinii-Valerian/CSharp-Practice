using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supraincarcarea_functiilor
{

    internal class App
    {
        static void Main(string[] args)
        {
            /*            
               1) Create a class called "Calculator" that has three methods called "add". 
                  The first "add" method should take two integers and return their sum.
                  The second "add" method should take two doubles and return their sum. 
                  The third "add" method should take three integers and return their sum. 
                  This exercise demonstrates method overloading with different parameter types.

               2) Create a class called "BankAccount" that has two methods called "deposit". 
                  The first "deposit" method should take an integer representing the amount of money to deposit.
                  The second "deposit" method should take a double representing the amount of money to deposit, 
                  and a boolean indicating whether or not the deposit is a foreign currency.
                  If it is, a conversion rate will be applied. 
                  This exercise demonstrates method overloading with different parameter types and numbers.

               3) Create a class called "Rectangle" that has two methods called "calculateArea". 
                  The first "calculateArea" method should take two integers representing the length and width 
                  of the rectangle, and return their product. The second "calculateArea" method should take 
                  a double representing the length of the rectangle's diagonal, and return the area of the 
                  rectangle based on the diagonal length. This exercise demonstrates method overloading with 
                  different parameter types and meanings.
            */

            // task 1
            Console.WriteLine("\n*****************************TASK 1*****************************\n");
            Calculator calc = new Calculator();    
            Console.WriteLine($"After first method from calculator result = {calc.add(1, 2)}");
            Console.WriteLine($"After second method from calculator result = {calc.add(1.1, 2.2)}");
            Console.WriteLine($"After third method from calculator result = {calc.add(3, 5, 7)}");

            // task 2
            Console.WriteLine("\n*****************************TASK 2*****************************\n");
            BankAccount bank = new BankAccount();
            bank.deposit(200);
            bank.deposit(335.7, true);

            // task 3
            Console.WriteLine("\n*****************************TASK 3*****************************\n");
            Rectangle rectangle = new Rectangle();
            Console.WriteLine($"Knowing the length and the width of the rectangle its area " +
                             $"= {rectangle.calculateArea(5,6)}");
            Console.WriteLine($"Knowing the diagonal and the length of the rectangle its area " +
                  $"= {rectangle.calculateArea(7.7, 4)}");
        }
        
    }
}
