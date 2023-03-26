using System.Collections;

namespace ArrayListuri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// ArrayList - tablou care poate contine orice tip de date

            // ArrayList arrayList = new ArrayList();
            //var arrayList = new ArrayList();

            //arrayList.Add(10); // {10}
            //arrayList.Add("text"); // {10, "text"}
            //arrayList.Add('*'); // {10, "text", '*'}
            //arrayList.Add(true); // {10, "text", '*', true}
            //arrayList.Add(2.22); // {10, "text", '*', true, 2.22}
            //arrayList.Add(null); // {10, "text", '*', true, 2.22, null}

            //Console.WriteLine(arrayList[0]);
            //Console.WriteLine(arrayList[1]);

            //arrayList[0] = "K";

            //Console.WriteLine("\n-----------------------------------------------");

            //Console.WriteLine("\nDUPA MODIFICAREA VALORII arrayList[0] = \"K\":: \n");

            //Console.WriteLine(arrayList[0]);
            //Console.WriteLine(arrayList[1]);

            //// var arrayList2 = new ArrayList() { 1, 2, 3, "Aa", 'x' };

            //arrayList.AddRange(new int[]{ 0, 1, 2}); // {10, "text", '*', true, 2.22, null, 0, 1, 2}

            //string[] words = { "Cow", "Horse", "Monkey" };
            //arrayList.AddRange(words); // {10, "text", '*', true, 2.22, null, 0, 1, 2, "Cow", "Horse", "Monkey"}

            //arrayList.Insert(3, 9.9); // {10, "text", '*', 9.9, true, 2.22, null, 0, 1, 2, "Cow", "Horse", "Monkey"}

            //Console.WriteLine("\nELEM POS[3]:: " + arrayList[3]);

            //// List<string> list = new List<string>() { "A", "B", "C" };
            //// arrayList.InsertRange(5, list); // putem adauga si o lista de elemente

            //arrayList.InsertRange(5, new string[] {"A", "B", "C"});
            //// { 10, "text", '*', 9.9, true, "A", "B", "C", 2.22, null, 0, 1, 2, "Cow", "Horse", "Monkey"}

            //Console.WriteLine("\n-----------------------------------------------");
            //Console.WriteLine("\nSHOWING ALL ELEMENTS::");

            //// for(int i=0; i < arrayList.Count; i++)
            //// {
            ////     Console.WriteLine(arrayList[i]);
            //// }

            //foreach(var items in arrayList)
            //{
            //    Console.WriteLine(items); // acelasi rezultat ca si codul de mai sus cu for
            //}

            //arrayList[0] = 2;
            //arrayList.Remove(2); // sterge primul element = 2 din ArrayList, daca este intalnit 
            //arrayList.RemoveAt(9); // sterge elementul de pe pozitia 9
            //arrayList.RemoveRange(5, 3); // de la pozitia 5 stergem urmatoarele 3 elemente

            //Console.WriteLine("\n-----------------------------------------------");

            //Console.WriteLine("\nDUPA STERGEREA ELEMENTELOR::");

            //foreach (var items in arrayList)
            //{
            //    Console.WriteLine(items); // acelasi rezultat ca si codul de mai sus cu for
            //}

            //Console.WriteLine("\n-----------------------------------------------\n");

            //Console.WriteLine(arrayList.Contains(10));

            Console.WriteLine("\n*********************TASKS*********************\n");

            /*
              Creati 3 liste (int, double, string) in fiecare lista veti avea cate 10 elemente
              Creati un ArrayList, trimeti in ArrayList, 10 elemente random din cele 3 liste
              P/u ArrayList:
              1. Adaugati inca 3 elmente
              2. Schimbati valoarea primului element si ultimului element
              3. Afisati in consola numarul de elemente
              4. Prin for afisati elementele ArrayList
              5. Adaugati un tablou in ArrayList
              6. Adaugati un element nou la pozitia 3
              7. Adaugati un tablou de caractere la pozitia 5
              8. Stergeti elementul cu valoarea oricarui numar
              9. Stergeti elementul de pe indexul 10
              10. Verificati daca in tablou este litera 'A'
              11. Inverstati tabloul
              12. Afisati tabloul prin foreach
            */

            List<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            List<double> doubleList = new List<double>() { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9, 0.01 };
            List<string> stringList = new List<string>() {"one", "two", "three", "four", "five", "six", "seven",
                                                          "eight", "nine", "ten"};
            ArrayList random = new ArrayList();
            random.AddRange(intList);
            random.AddRange(doubleList);
            random.AddRange(stringList);

            var arrayList = new ArrayList();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                arrayList.Insert(i, random[rnd.Next()%30]);
            }

            Console.WriteLine("------------SHOWING THE ELEMENTS OF THE TABLE------------ \n");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            // task 1
            arrayList.Add("eleven");
            arrayList.Add(12.12);
            arrayList.Add(13);

            // task 2
            arrayList[0] = "first";
            arrayList[arrayList.Count - 1] = "last";

            // task 3
            Console.WriteLine($"\nNumber of elements of arrayList after 2 tasks = {arrayList.Count} \n");

            // task 4
            Console.WriteLine("------------SHOWING THE ELEMENTS OF THE TABLE WITH FOR------------ \n");
            for (int i = 0; i<arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            // task 5
            int[] intArray = { 7, 8, 9};
            arrayList.AddRange(intArray);

            // task 6
            arrayList.Insert(3, "newElementThree");

            // task 7
            char[] charArray = { 'm', 'v', 'c' };
            arrayList.InsertRange(5, charArray);

            // task 8
            arrayList.Remove("eleven");

            // task 9
            arrayList.RemoveAt(10);

            // task 10
            Console.WriteLine("\nLitera 'A' este continuta:: " + arrayList.Contains('A'));

            // task 11
            arrayList.Reverse();

            // task 12
            Console.WriteLine("\n------------SHOWING THE ELEMENTS OF THE TABLE WITH FOREACH (REVERSED)------------ \n");
            foreach (var itm in arrayList)
            {
                Console.WriteLine(itm);
            }
        }
    }
}