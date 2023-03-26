using System.Collections;
using System.Collections.Generic;

namespace Sarcina_3
{
    internal class Program
    {
        static void menu()
        {
            Console.WriteLine(" +. addition");
            Console.WriteLine(" -. substraction");
            Console.WriteLine(" *. multiplication");
            Console.WriteLine(" /. division");
            Console.WriteLine(" c. clear all");
            Console.WriteLine(" x. leave app \n");
        }

        static void firstOperation()
        {
            char op;
            double first;
            double value;
            double result = 0;

            Console.Write(" Enter the first value:: ");
            first = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Enter the operation you want to perform:: ");
            op = (Console.ReadLine())[0];
            if (op == 'c')
            {
                System.Console.Clear();
                result = 0;
                menu();
                firstOperation();

            }
            else if (op == 'x')
            {
                System.Environment.Exit(0);
            }

            Console.Write(" Enter the second value:: ");
            value = Convert.ToDouble(Console.ReadLine());   

            switch (op)
            {
                case '+':
                    result = first + value;                
                    break;

                case '-':
                    result = first - value;
                    break;

                case '*':
                    result = first * value;
                    break;

                case '/':
                    if (first == 0 && value == 0)
                    {
                        Console.WriteLine(" 0/0 isn't possible (INDETERMINATE)");
                    }
                    else if (value == 0)
                    {
                        Console.WriteLine(" Division by 0 isn't possible (UNDEFINED)");
                    }
                    else
                    {
                        result = first / value;
                    }
                    break;

                default:
                    Console.WriteLine(" You have entered a correct operation to do!!!");
                    break;
            }

            calculator(result);
        }
        static void calculator(double result)
        {
            char op; // operation
            double value;
            double first;
            bool start = true;

            do
            {
                result = Math.Round(result, 2);
                Console.WriteLine("\n Result:: " + result);

                Console.Write(" Enter the operation you want to perform:: ");
                op = Console.ReadLine()[0];

                if (op == 'c')
                {
                    System.Console.Clear();
                    result = 0;
                    menu();
                    firstOperation();

                } else if (op == 'x')
                {
                    System.Environment.Exit(0);
                }

                Console.Write(" Enter the second value:: ");
                value = Convert.ToDouble(Console.ReadLine());

                switch (op)
                {
                    case '+': result += value;
                        break;

                    case '-': result -= value;  
                        break;

                    case '*': result *= value;      
                        break;

                    case '/': 
                        if (result == 0 && value == 0)
                        {
                            Console.WriteLine(" 0/0 isn't possible (INDETERMINATE)");                     
                        } else if (value == 0)
                        {
                            Console.WriteLine(" Division by 0 isn't possible (UNDEFINED)");
                        } else
                        {
                            result /= value;
                        }
                        break;

                    default: Console.WriteLine(" You have entered a correct operation to do!!!");
                        break;
                }

            } while (true);
        }
        static void Main(string[] args)
        {
            // calculator
            menu();
            firstOperation();
        }
    }
}