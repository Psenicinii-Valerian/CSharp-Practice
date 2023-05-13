using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace Delegates
{
    // SingleCast Delegate - references 1 method
    delegate int SumDelegate(int a, int b);
    delegate bool CheckLetterDelegate(string s);

    // MultiCast Delegate - references 1+ (1 or more) methods
    delegate void CalculatorDelegate(int a, int b, int c);

    // Generic Delegate - can return and get(as parameters) any data type
    delegate TResult ToStringDelegate<TSource, TResult>(TSource source);

    // Anonymous Delegate - has no name, no signature

    internal class Program
    {
        public static int sumFunction(int x, int y) { return x + y; }

        static void Main(string[] args)
        {
            /*
              SumDelegate sum1 = (x, y) => x + y;
              // Console.WriteLine(sum1(5, 10));

              SumDelegate sum2 = sumFunction;
              // Console.WriteLine(sum2(10, 100));

              CheckLetterDelegate checkLetter0 = (s) => Char.ToUpper(s[0]) == s[0];
              // Console.WriteLine(checkLetter0("world"));

              CheckLetterDelegate checkLastLetter = (s) => Char.ToLower(s[s.Length - 1]) == s[s.Length - 1];
              // Console.WriteLine(checkLastLetter("world"));
            */

            /*
              CalculatorDelegate calc = (x, y, z) => Console.WriteLine(x * y * z);
              calc += (x, y, z) => Console.WriteLine(x - y - z);
              calc += (x, y, z) => Console.WriteLine(x + y + z);

              calc(10, -5, 20);
            */
            /*
              ToStringDelegate<int, string> transform = number => number.ToString();
              // Console.WriteLine(transform(10).GetType());

              ToStringDelegate<double, string> transform2 = number => number.ToString();
              // Console.WriteLine(transform2(10.10).GetType());

              ToStringDelegate<double, double> transform3 = number => number * number;
              // Console.WriteLine(Math.Round(transform3(10.10), 2));
            */

            Func<int, int, int, int> sum = delegate (int a, int b, int c)
            {
                return a + b + c;
            };

            Console.WriteLine(sum(1, 2, 3));

            Func<string, int, string> createPerson = delegate (string name, int age)
            {
                return name + " " + age + " years old";
            };

            Console.WriteLine(createPerson("Ana", 30));
        }

        // Final Exam::
        // Management System
        // 5 Clase, 20 obiecte, 5 liste, 10 functii, getteri si setteri, constructori si fisiere.

        // RentACar - 10 car, 2 company office (filialele companiei), 1-2 client, 2 worker,
        // 1 service that work with company, events history(accident), 1 class company for credits for car,
        // benzinarii, auto wash, car dealers, blocked clients

        // functions: CRUD:: create car, read data car, actualise a car info (total kms), delete a car  
        // List<Cient> cars = { 1 element, 2 element, 3 element .. n element }
    }
}