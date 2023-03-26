using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Classwork_cu_fisiere
{
    internal class Program
    {
        // Function for calculating median
        public static double findMedian(int[] a, int n)
        {
            // First we sort the array
            Array.Sort(a);

            // check for even case
            if (n % 2 != 0)
                return (double)a[n / 2];

            
            return (double)(a[(n - 1) / 2] + a[n / 2]) / 2.0;
        }
        
        static void Main(string[] args)
        {
            // 1) Create a new text file, write some text to it, and then close the file.
            Console.WriteLine("\n********************************* EXERCISE 1 *********************************\n");
            StreamWriter output_ex1 = new StreamWriter("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Classwork cu fisiere\\Classwork cu fisiere\\output_ex1.txt");
            string[] randomText_ex1 = { "random", "helloWorld", "Skopje" };

            for (int i = 0; i < randomText_ex1.Length; i++)
            {
                output_ex1.WriteLine(randomText_ex1[i]);
            }
            output_ex1.Close();

            // 2) Open an existing text file, read the contents, and then display them on the console.
            Console.WriteLine("\n********************************* EXERCISE 2 *********************************\n");
            StreamReader input_ex2 = new StreamReader("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Classwork cu fisiere\\Classwork cu fisiere\\input_ex2.txt");
            string readText_ex2 = input_ex2.ReadToEnd();
            Console.WriteLine(readText_ex2);

            input_ex2.Close();

            // 3) Open an existing text file, read the contents, and then count the number of lines.
            Console.WriteLine("\n********************************* EXERCISE 3 *********************************\n");
            StreamReader input_ex3 = new StreamReader("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Classwork cu fisiere\\Classwork cu fisiere\\input_ex3.txt");
            string readText_ex3 = input_ex3.ReadLine();
            int lineNumber_ex3 = 0;

            while (readText_ex3 != null)
            {
                lineNumber_ex3++;
                Console.WriteLine(readText_ex3);
                readText_ex3 = input_ex3.ReadLine();
            }

            Console.WriteLine($"Number of read lines: {lineNumber_ex3}");

            input_ex3.Close();

            // 4) Open an existing text file, read the contents, and then count the number of words.
            Console.WriteLine("\n********************************* EXERCISE 4 *********************************\n");
            StreamReader input_ex4 = new StreamReader("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Classwork cu fisiere\\Classwork cu fisiere\\input_ex4.txt");
            string readText_ex4 = input_ex4.ReadLine();
            int wordNumber_ex4 = 0;

            while (readText_ex4 != null)
            {
                string[] resultArr_ex4 = readText_ex4.Split(' ');
                wordNumber_ex4 += resultArr_ex4.Length;
                Console.WriteLine(readText_ex4);
                readText_ex4 = input_ex4.ReadLine();

            }


            Console.WriteLine($"Total word count: {wordNumber_ex4}");
            input_ex4.Close();

            // 5) Open an existing text file, read the contents, and then count the number of characters.
            Console.WriteLine("\n********************************* EXERCISE 5 *********************************\n");
            StreamReader input_ex5 = new StreamReader("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Classwork cu fisiere\\Classwork cu fisiere\\input_ex5.txt");
            string characters = input_ex5.ReadToEnd();
            string readText_ex5 = input_ex5.ReadLine();

            while (readText_ex5 != null)
            {
                Console.WriteLine(readText_ex5);
                readText_ex5 = input_ex5.ReadLine();
            }

            Console.WriteLine($"Total characters count: {characters.Length}");
            input_ex5.Close();

            // 6) Open an existing text file, read the contents, and then search for a specific word or phrase.
            Console.WriteLine("\n********************************* EXERCISE 6 *********************************\n");
            StreamReader input_ex6 = new StreamReader("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Classwork cu fisiere\\Classwork cu fisiere\\input_ex6.txt");
            string readPhrase_ex6 = input_ex6.ReadLine();

            Console.WriteLine("What word or phrase do you want to search in the file?");
            string search = Console.ReadLine();
            Console.WriteLine();

            int match = 0;

            while (readPhrase_ex6 != null)
            {
                Console.WriteLine(readPhrase_ex6);

                string[] resultArr_ex6 = readPhrase_ex6.Split(' ');
                for (int i = 0; i < resultArr_ex6.Length; i++)
                {
                    if (search == resultArr_ex6[i])
                    {
                        match++;
                        Console.WriteLine($"\nMatch! {search} = {resultArr_ex6[i]}\n");
                    }
                }

                if (search == readPhrase_ex6)
                {
                    match++;
                    Console.WriteLine($"\n Match! {search} = {readPhrase_ex6}\n");
                }


                readPhrase_ex6 = input_ex6.ReadLine();
            }

            Console.WriteLine($"Total matches: {match}");
            input_ex6.Close();

            // 7) Write a program that reads a list of integers from a file, stores them in an array,
            // and then calculates and displays the average of the numbers.
            Console.WriteLine("\n********************************* EXERCISE 7 *********************************\n");
            StreamReader input_ex7 = new StreamReader("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Classwork cu fisiere\\Classwork cu fisiere\\input_ex7.txt");
            string readNumbers_ex7 = input_ex7.ReadLine();
            int[] numbers_ex7 = new int[50];
            int numLength = 0;

            while (readNumbers_ex7 != null)
            { 

                string[] arrayNumbers_ex7 = readNumbers_ex7.Split(' ');

                for (int i = numLength; i < (numLength + arrayNumbers_ex7.Length); i++)
                {
                    numbers_ex7[i] = Convert.ToInt32(arrayNumbers_ex7[i-numLength]);
                    Console.Write($"{numbers_ex7[i]} ");
                }

                numLength += arrayNumbers_ex7.Length;
                Console.WriteLine($"num length = {numLength}");

                readNumbers_ex7 = input_ex7.ReadLine();
            }

            Console.WriteLine($"Average number from these numbers: {(double)numbers_ex7.Sum()/numLength}");
            input_ex7.Close();

            // 8) Write a program that reads a list of strings from a file, stores them in an array,
            // and then sorts the array in alphabetical order.
            Console.WriteLine("\n********************************* EXERCISE 8 *********************************\n");
            StreamReader input_ex8 = new StreamReader("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Classwork cu fisiere\\Classwork cu fisiere\\input_ex8.txt");
            string readText_ex8 = input_ex8.ReadLine();
            string[] text_ex8 = new string[50];
            int totalStrings_ex8 = 0;

            while(readText_ex8 != null)
            {
                string[] stringText_ex8 = readText_ex8.Split(' ');

                for (int i = totalStrings_ex8; i < (totalStrings_ex8 + stringText_ex8.Length); i++)
                {
                    text_ex8[i] = stringText_ex8[i - totalStrings_ex8];
                    Console.WriteLine($"text: {text_ex8[i]}");
                }

                totalStrings_ex8 += stringText_ex8.Length;
                readText_ex8 = input_ex8.ReadLine();
            }

            input_ex8.Close();

            Array.Sort(text_ex8);

            Console.WriteLine("\nAFTER SORTING THE TEXT:: \n");
            
            for (int i = 50-totalStrings_ex8; i < 50; i++)
            {
                Console.WriteLine(text_ex8[i]);
            }

            // 9) Write a program that reads a list of integers from a file, stores them in an array,
            // and then displays the largest number in the array.
            Console.WriteLine("\n********************************* EXERCISE 9 *********************************\n");
            StreamReader input_ex9 = new StreamReader("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Classwork cu fisiere\\Classwork cu fisiere\\input_ex9.txt");
            string readNumbers_ex9 = input_ex9.ReadLine();
            int[] numbers_ex9 = new int[50];
            int totalNumbers_ex9 = 0;

            while (readNumbers_ex9 != null)
            {
                string[] lineNumbers_ex9 = readNumbers_ex9.Split(' ');

                for (int i = totalNumbers_ex9; i < (totalNumbers_ex9 + lineNumbers_ex9.Length); i++)
                {
                    numbers_ex9[i] = Convert.ToInt32(lineNumbers_ex9[i - totalNumbers_ex9]);
                    Console.WriteLine($"numbers: {numbers_ex9[i]}");
                }

                totalNumbers_ex9 += lineNumbers_ex9.Length;
                readNumbers_ex9 = input_ex9.ReadLine();
            }

            Console.WriteLine($"\nThe largest number from the array:: {numbers_ex9.Max()}");

            input_ex9.Close();

            // 10) Write a program that reads a list of integers from a file, stores them in an array,
            // and then displays the smallest number in the array.
            Console.WriteLine("\n********************************* EXERCISE 10 *********************************\n");
            StreamReader input_ex10 = new StreamReader("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Classwork cu fisiere\\Classwork cu fisiere\\input_ex10.txt");
            string readNumbers_ex10 = input_ex10.ReadLine();
            int[] numbers_ex10 = new int[50];
            int totalNumbers_ex10 = 0;

            while (readNumbers_ex10 != null)
            {
                string[] lineNumbers_ex10 = readNumbers_ex10.Split(' ');

                for (int i = totalNumbers_ex10; i < (totalNumbers_ex10 + lineNumbers_ex10.Length); i++)
                {
                    numbers_ex10[i] = Convert.ToInt32(lineNumbers_ex10[i - totalNumbers_ex10]);
                    Console.WriteLine($"numbers: {numbers_ex10[i]}");
                }

                totalNumbers_ex10 += lineNumbers_ex10.Length;
                readNumbers_ex10 = input_ex10.ReadLine();
            }

            Console.WriteLine($"\nThe smallest number from the array:: {numbers_ex10.Min()}");

            input_ex10.Close();

            // 11) Write a program that reads a list of integers from a file, stores them in an array,
            // and then displays the sum of the numbers.
            Console.WriteLine("\n********************************* EXERCISE 11 *********************************\n");
            StreamReader input_ex11 = new StreamReader("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Classwork cu fisiere\\Classwork cu fisiere\\input_ex11.txt");
            string readNumbers_ex11 = input_ex11.ReadLine();
            int[] numbers_ex11 = new int[50];
            int totalNumbers_ex11 = 0;

            while (readNumbers_ex11 != null)
            {
                string[] lineNumbers_ex11 = readNumbers_ex11.Split(' ');

                for (int i = totalNumbers_ex11; i < (totalNumbers_ex11 + lineNumbers_ex11.Length); i++)
                {
                    numbers_ex11[i] = Convert.ToInt32(lineNumbers_ex11[i - totalNumbers_ex11]);
                    Console.WriteLine($"numbers: {numbers_ex11[i]}");
                }

                totalNumbers_ex11 += lineNumbers_ex11.Length;
                readNumbers_ex11 = input_ex11.ReadLine();
            }

            Console.WriteLine($"\nThe sum of given numbers:: {numbers_ex11.Sum()}");

            input_ex11.Close();

            // 12) Write a program that reads a list of integers from a file, stores them in an array,
            // and then displays the median of the numbers.
            Console.WriteLine("\n********************************* EXERCISE 12 *********************************\n");
            StreamReader input_ex12 = new StreamReader("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Classwork cu fisiere\\Classwork cu fisiere\\input_ex12.txt");
            string readNumbers_ex12 = input_ex12.ReadLine();
            int[] numbers_ex12 = new int[50];
            int totalNumbers_ex12 = 0;

            while (readNumbers_ex12 != null)
            {
                string[] lineNumbers_ex12 = readNumbers_ex12.Split(' ');

                for (int i = totalNumbers_ex12; i < (totalNumbers_ex12 + lineNumbers_ex12.Length); i++)
                {
                    numbers_ex12[i] = Convert.ToInt32(lineNumbers_ex12[i - totalNumbers_ex12]);
                    Console.WriteLine($"numbers: {numbers_ex12[i]}");
                }

                totalNumbers_ex12 += lineNumbers_ex12.Length;
                readNumbers_ex12 = input_ex12.ReadLine();
            }

            int[] medianArray_ex12 = new int[totalNumbers_ex12];

            for (int i=0; i<totalNumbers_ex12; i++)
            {
                medianArray_ex12[i] = numbers_ex12[i];
            }

            double median_ex12 = findMedian(medianArray_ex12, medianArray_ex12.Length);
            
            Console.WriteLine($"\nThe median of the numbers from the array:: {median_ex12}");

            input_ex12.Close();

            // 13) Write a program that reads a list of integers from a file, stores them in an array,
            // and then displays the even and odd mode of the numbers.
            Console.WriteLine("\n********************************* EXERCISE 13 *********************************\n");
            StreamReader input_ex13 = new StreamReader("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Classwork cu fisiere\\Classwork cu fisiere\\input_ex13.txt");
            string readNumbers_ex13 = input_ex13.ReadLine();
            int[] numbers_ex13 = new int[50];
            int totalNumbers_ex13 = 0;

            while (readNumbers_ex13 != null)
            {
                string[] lineNumbers_ex13 = readNumbers_ex13.Split(' ');

                for (int i = totalNumbers_ex13; i < (totalNumbers_ex13 + lineNumbers_ex13.Length); i++)
                {
                    numbers_ex13[i] = Convert.ToInt32(lineNumbers_ex13[i - totalNumbers_ex13]);
                    Console.WriteLine($"numbers: {numbers_ex13[i]}");
                }

                totalNumbers_ex13 += lineNumbers_ex13.Length;
                readNumbers_ex13 = input_ex13.ReadLine();
            }

            int odd_number_count_ex13 = 0, even_number_count_ex13 = 0;

            for (int i = 0; i < totalNumbers_ex13; i++)
            {
                if (numbers_ex13[i]%2 == 0)
                {                  
                    even_number_count_ex13++;
                } else
                {              
                    odd_number_count_ex13++;
                }              
            }

            int[] modeArray_even_ex13 = new int[even_number_count_ex13]; // par
            int[] modeArray_odd_ex13 = new int[odd_number_count_ex13];   // impar

            int counter_even_ex13 = 0, counter_odd_ex13 = 0;

            for (int i = 0; i < totalNumbers_ex13; i++)
            {
                if (numbers_ex13[i] % 2 == 0)
                {
                    modeArray_even_ex13[counter_even_ex13] = numbers_ex13[i];
                    counter_even_ex13++;
                }
                else
                {
                    modeArray_odd_ex13[counter_odd_ex13] = numbers_ex13[i];
                    counter_odd_ex13++;
                }
            }

            int mode_even_ex13 = modeArray_even_ex13.GroupBy(i => i).OrderByDescending(g => g.Count())
                                 .Select(g => g.Key).FirstOrDefault();

            //Grouping same items - //now getting frequency of a value 
            //selecting key of the group - //Finally, taking the most frequent value

            int mode_odd_ex13 = modeArray_odd_ex13.GroupBy(i => i).OrderByDescending(g => g.Count())
                     .Select(g => g.Key).FirstOrDefault();

            //Grouping same items - //now getting frequency of a value 
            //selecting key of the group - //Finally, taking the most frequent value

            Console.WriteLine($"\nThe even mode of the numbers from the array:: {mode_even_ex13}");
            Console.WriteLine($"\nThe odd mode of the numbers from the array:: {mode_odd_ex13}");
            input_ex13.Close();

            // 14) Write a program that reads a list of integers from a file, stores them in an array,
            // and then displays the range of the numbers.
            Console.WriteLine("\n********************************* EXERCISE 14 *********************************\n");
            StreamReader input_ex14 = new StreamReader("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Classwork cu fisiere\\Classwork cu fisiere\\input_ex14.txt");
            string readNumbers_ex14 = input_ex14.ReadLine();
            int[] numbers_ex14 = new int[50];
            int totalNumbers_ex14 = 0;

            while (readNumbers_ex14 != null)
            {
                string[] lineNumbers_ex14 = readNumbers_ex14.Split(' ');

                for (int i = totalNumbers_ex14; i < (totalNumbers_ex14 + lineNumbers_ex14.Length); i++)
                {
                    numbers_ex14[i] = Convert.ToInt32(lineNumbers_ex14[i - totalNumbers_ex14]);
                    Console.WriteLine($"numbers: {numbers_ex14[i]}");
                }

                totalNumbers_ex14 += lineNumbers_ex14.Length;
                readNumbers_ex14 = input_ex14.ReadLine();
            }

            int min_ex14 = numbers_ex14.Min();
            int max_ex14 = numbers_ex14.Max();

            Console.WriteLine($"\nThe range of the numbers from the array:: {min_ex14} - {max_ex14}");

            input_ex14.Close();

            // 15) Write a program that reads a list of strings from a file, stores them in an array,
            // and then displays the length of the longest string in the array.
            Console.WriteLine("\n********************************* EXERCISE 15 *********************************\n");
            StreamReader input_ex15 = new StreamReader("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Classwork cu fisiere\\Classwork cu fisiere\\input_ex15.txt");
            string readText_ex15 = input_ex15.ReadLine();
            string[] text_ex15 = new string[50];
            string searchedString_ex15 = null;
            int totalStrings_ex15 = 0, maxLength_ex15 = 0;
            

            while (readText_ex15 != null)
            {
                string[] stringText_ex15 = readText_ex15.Split(' ');

                for (int i = totalStrings_ex15; i < (totalStrings_ex15 + stringText_ex15.Length); i++)
                {
                    text_ex15[i] = stringText_ex15[i - totalStrings_ex15];
                    Console.WriteLine($"text: {text_ex15[i]}");
                }

                totalStrings_ex15 += stringText_ex15.Length;
                readText_ex15 = input_ex15.ReadLine();
            }

            input_ex15.Close();
         
            for (int i = 0; i < totalStrings_ex15; i++)
            {
                if (text_ex15[i].Length > maxLength_ex15)
                {
                    maxLength_ex15 = text_ex15[i].Length;
                    searchedString_ex15 = text_ex15[i];
                }
            }

            Console.WriteLine($"The longest string in the array is:: {searchedString_ex15} " +
                              $"and its length = {searchedString_ex15.Length} ");


            // 16) Write a program that reads a list of integers from a file, stores them in an array,
            // and then displays the second largest number in the array.
            Console.WriteLine("\n********************************* EXERCISE 16 *********************************\n");
            StreamReader input_ex16 = new StreamReader("C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 8\\Classwork cu fisiere\\Classwork cu fisiere\\input_ex16.txt");
            string readNumbers_ex16 = input_ex16.ReadLine();
            int[] numbers_ex16 = new int[50];
            int totalNumbers_ex16 = 0;

            while (readNumbers_ex16 != null)
            {
                string[] lineNumbers_ex16 = readNumbers_ex16.Split(' ');

                for (int i = totalNumbers_ex16; i < (totalNumbers_ex16 + lineNumbers_ex16.Length); i++)
                {
                    numbers_ex16[i] = Convert.ToInt32(lineNumbers_ex16[i - totalNumbers_ex16]);
                    Console.WriteLine($"numbers: {numbers_ex16[i]}");
                }

                totalNumbers_ex16 += lineNumbers_ex16.Length;
                readNumbers_ex16 = input_ex16.ReadLine();
            }

            int max_ex16 = numbers_ex16.Max();
            int second_max_ex16 = numbers_ex16[0];

            for (int i = 0; i < totalNumbers_ex16; i++)
            {
                if (second_max_ex16 < numbers_ex16[i] && numbers_ex16[i] != max_ex16)
                {
                    second_max_ex16 = numbers_ex16[i];
                }
            }

            Console.WriteLine($"\nThe second max of the numbers from the array:: {second_max_ex16}");

            input_ex16.Close();
        }
    }
}