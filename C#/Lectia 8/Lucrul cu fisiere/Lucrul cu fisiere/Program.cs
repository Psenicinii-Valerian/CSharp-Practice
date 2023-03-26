using System;
using System.IO;


namespace Lucrul_cu_fisiere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ********************************* exercise 1 *********************************
            /*
                string[] words = { "A", "B", "C" };

                string path = "C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Lucrul cu fisiere\\Lucrul cu fisiere\\output.txt";
                StreamWriter output = new StreamWriter(path);

                output.WriteLine("Salut");
                output.WriteLine(" Salut");

                for (int i = 0; i<words.Length; i++)
                {
                    output.Write(words[i]);
                }

                output.Close();
            */

            // ********************************* exercise 2 *********************************
            /*           
                string name, lastname;
                int age;

                name = Console.ReadLine();
                lastname = Console.ReadLine();
                age = Convert.ToInt32(Console.ReadLine());

                string path = "C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Lucrul cu fisiere\\Lucrul cu fisiere\\output.txt";
                StreamWriter output = new StreamWriter(path);

                output.WriteLine($"Name: {name}");
                output.WriteLine($"Lastname: {lastname}");
                output.WriteLine($"Age: {age} y.o.");

                output.Close();
            */

            // ********************************* exercise 3 *********************************
            /*
                StreamReader input = new StreamReader("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Lucrul cu fisiere\\Lucrul cu fisiere\\output.txt");
                string line = input.ReadLine();

                while(line != null)
                {
                    Console.WriteLine(line);
                    line = input.ReadLine();
                }
            */

            // ********************************* exercise 4 *********************************
            /*            
                StreamReader input = new StreamReader("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Lucrul cu fisiere\\Lucrul cu fisiere\\input.txt");
                StreamWriter output = new StreamWriter("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Lucrul cu fisiere\\Lucrul cu fisiere\\output.txt");
                string line = input.ReadLine();
                string[] lines = new string[10];
                int i = 0;
                while (line != null)
                {
                    lines[i] = line;
                    i += 1;
                    line = input.ReadLine();
                }

                for (i=0; i<lines.Length; i++)
                {
                    if (lines[i] != null)
                    {
                        output.WriteLine(lines[i]);
                    }             
                }

                input.Close();
                output.Close();
            */

            // ********************************* exercise 4 *********************************
            /*            
                StreamReader input = new StreamReader("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Lucrul cu fisiere\\Lucrul cu fisiere\\input.txt");
                StreamWriter output = new StreamWriter("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Lucrul cu fisiere\\Lucrul cu fisiere\\output.txt");

                string inputContent = input.ReadToEnd();
                Console.WriteLine(inputContent);
                output.WriteLine(inputContent);

                input.Close();
                output.Close();
            */

            // ********************************* exercise 5 *********************************
            /*
                StreamReader input = new StreamReader("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Lucrul cu fisiere\\Lucrul cu fisiere\\input.txt");
                StreamWriter output = new StreamWriter("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Lucrul cu fisiere\\Lucrul cu fisiere\\output.txt");

                int[] numbers = new int[10];
                string n = input.ReadLine();
                int i = 0;
                while (n != null)
                {
                    numbers[i] = Convert.ToInt32(n);
                    i += 1;
                    n = input.ReadLine();
                }

                output.WriteLine(numbers.Sum());

                input.Close();
                output.Close();
            */

            // ********************************* exercise 6 *********************************
            StreamReader input = new StreamReader("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Lucrul cu fisiere\\Lucrul cu fisiere\\input.txt");
            StreamWriter output = new StreamWriter("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Lucrul cu fisiere\\Lucrul cu fisiere\\output.txt");

            string result = input.ReadToEnd(); // 1 2 3 4 5 6 7
            string[] resultArr = result.Split(' '); // 1, 2, 3, 4, 5, 6, 7
            int[] numbers = new int[resultArr.Length];

            for (int i = 0; i < resultArr.Length; i++)
            {
                numbers[i] = Convert.ToInt32(resultArr[i]);
            }

            output.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Sum());

            input.Close();
            output.Close();
        }
    }
}