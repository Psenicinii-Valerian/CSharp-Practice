using System.Collections.Generic;
using System.Xml.Linq;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// IDictionary<string, string> theWorld = new Dictionary<string, string>();
            //var theWorld = new Dictionary<string, string>() {
            //    {"USA", "United States of America" }
            //};

            //// INDEX: MD      | UA      | RO
            //// VALUE: Moldova | Ukraine | Romania

            //theWorld.Add("MD", "Moldova");
            //theWorld.Add("UA", "Ukraine");
            //theWorld.Add("RO", "Romania");

            //Console.WriteLine(theWorld["MD"]);
            //Console.WriteLine(theWorld["UA"]);
            //Console.WriteLine(theWorld["RO"]);

            //theWorld["MD"] = "Republic of Moldova";

            //theWorld.Remove("MD");

            //Console.WriteLine("theWorld.ContainsKey(\"RO\") " + theWorld.ContainsKey("RO"));

            //Console.WriteLine("\n-----SHOWING ALL THE DICTIONARY WITH KeyValuePair-----\n");

            ////foreach(KeyValuePair<string, string> country in theWorld)
            //foreach (var country in theWorld)
            //{
            //    Console.WriteLine(country.Key + " " + country.Value);
            //}

            //Console.WriteLine("\n-----SHOWING ALL THE DICTIONARY WITH FOR and ElementAt(i)-----\n");

            //for (int i=0; i<theWorld.Count; i++)
            //{
            //    Console.WriteLine(theWorld.ElementAt(i));
            //}


            Console.WriteLine("\n*************TASK*************\n");

            // Creati 3x dictionare
            //  Dictionar 1 < double, int>:
            // 1.Aflati suma pentru indexuri
            // 2.Aflati suma a indexurilor + valorilor
            // 3.Aflati media aritmetica a tuturor
            //  Dictionar 2 < char, string>:
            // 1.Adaugati 10 elemente prin add
            // 2.Stergeti 3 elemente conform indexului
            // 3.Afisati elementul pe pozitia 5
            //  Dictionar 3 < string, string>:
            // 1.Afisati dictionarul prin foreach
            // 2.Afisati dictionarul prin for
            // 3.Modificati valoarea pentru ultimele 3 elemente

            // task 1
            Console.WriteLine("---------------TASK 1---------------\n");

            Dictionary<double, int> dictionaryDoubleInt = new Dictionary<double, int>();

            dictionaryDoubleInt.Add(1.1, 1);
            dictionaryDoubleInt.Add(2.2, 2);
            dictionaryDoubleInt.Add(3.3, 3);
            dictionaryDoubleInt.Add(4.4, 4);
            dictionaryDoubleInt.Add(5.5, 5);

            double indexSum = 0, indexValueSum = 0;
            for (int i=0; i<dictionaryDoubleInt.Count; i++)
            {
                // task 1.1
                indexSum += dictionaryDoubleInt.ElementAt(i).Key;
                // task 1.2
                indexValueSum += (dictionaryDoubleInt.ElementAt(i).Key + dictionaryDoubleInt.ElementAt(i).Value);
            }

            // task 1.3
            double mediaAritmetica = indexValueSum / dictionaryDoubleInt.Count;

            Console.WriteLine("Suma indexurilor dictionarului dictionaryDoubleInt = " + indexSum);
            Console.WriteLine("Suma indexurilor si valorilor dictionarului dictionaryDoubleInt = " + indexValueSum);
            Console.WriteLine("Media aritmetica a indexurilor si valorilor dictionarului dictionaryDoubleInt = "
                                                                                                 + mediaAritmetica);
            
            // task 2
            Console.WriteLine("\n---------------TASK 2---------------\n");

            var dictionaryCharString = new Dictionary<char, string>();

            // task 2.1
            dictionaryCharString.Add('a', "Aa");
            dictionaryCharString.Add('b', "Bb");
            dictionaryCharString.Add('c', "Cc");
            dictionaryCharString.Add('d', "Dd");
            dictionaryCharString.Add('e', "Ee");
            dictionaryCharString.Add('f', "Ff");
            dictionaryCharString.Add('g', "Gg");
            dictionaryCharString.Add('h', "Hh");
            dictionaryCharString.Add('i', "Ii");
            dictionaryCharString.Add('j', "Jj");

            // task 2.2
            dictionaryCharString.Remove('i');
            dictionaryCharString.Remove('i');
            dictionaryCharString.Remove('i');

            foreach (var dictionary in dictionaryCharString)
            {
                Console.WriteLine(dictionary.Key + " | " + dictionary.Value);
            }

            // task 2.3
            Console.WriteLine("\nElementul de pe pozitia 5:: " + dictionaryCharString.ElementAt(5));

            // task 3
            Console.WriteLine("\n---------------TASK 3---------------\n");
            var dictionaryStringString = new Dictionary<string, string>();

            dictionaryStringString.Add("Viorel", "0744100017");
            dictionaryStringString.Add("Marcel", "0742054582");
            dictionaryStringString.Add("Andreea", "0740663777");
            dictionaryStringString.Add("Dan", "0722423083");
            dictionaryStringString.Add("Jorel", "0726350772");
            dictionaryStringString.Add("Mihaela", "0728290925");
            dictionaryStringString.Add("Nicu", "0731040882");

            // task 3.1
            Console.WriteLine("-----SHOWING ALL THE DICTIONARY WITH FOREACH-----\n");

            foreach (var dictionary in dictionaryStringString)
            {
                Console.WriteLine(dictionary.Key + " - " + dictionary.Value);
            }

            // task 3.2
            Console.WriteLine("\n-----SHOWING ALL THE DICTIONARY WITH FOR-----\n");
            for (int i=0; i<dictionaryStringString.Count; i++)
            {
                Console.WriteLine(dictionaryStringString.ElementAt(i));
            }

            // task 3.3
            for (int i=dictionaryStringString.Count-1; i >= dictionaryStringString.Count - 3; i--) {
                dictionaryStringString[dictionaryStringString.ElementAt(i).Key] = "modified " + (dictionaryStringString.Count - i);
            }

            Console.WriteLine("\n-----SHOWING ALL THE DICTIONARY WITH FOR AFTER MODIFYING LAST 3 ELEMENTS-----\n");
            for (int i = 0; i < dictionaryStringString.Count; i++)
            {
                Console.WriteLine(dictionaryStringString.ElementAt(i).Key + " - " + dictionaryStringString.ElementAt(i).Value);
            }



        }
    }
}