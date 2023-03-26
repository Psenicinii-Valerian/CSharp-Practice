using System.Net.Http.Headers;

// int[] arr = {1, 2, 3, 4, 5};
// string[] arr2 = { "A", "B", "C" };
// char[] arr3 = { 'a', 'b', 'c' };

// string[] drinks= {"Red Bull", "Cola", "OM"};
// Console.WriteLine(drinks[0] + ' ' + drinks[1] + ' ' + drinks[2]);

// Console.WriteLine($"{drinks[0]} {drinks[1]} {drinks[2]}");
// drinks[0] = "Naturalis";


/*for (int i=0; i<drinks.Length; i++)
{
    Console.WriteLine($"{i+1} {drinks[i]}");   
}
*/

// int i = 0;

/*foreach (string drink in drinks)
{
    Console.WriteLine(i + " " + drink);
    i += 1;
}   
*/

//string[] bandits = { "Elon Merishor", "Igor Andreevich", "VVP", "Ionel", "Ana Maria", "Andrei" };
//string userBandit = Console.ReadLine();

//foreach (string bandit in bandits)
//{
//    if (bandit == userBandit)
//    {
//        Console.WriteLine("Banditu' found");
//        break;
//    }
//}

//string[] myCars = { "Mercedes", "Honda", "BMW", "Dacia", "Toyota Supra" };

//foreach (string car in myCars)
//{
//    if (car == "Dacia") continue;
//    Console.WriteLine(car);
//}

/*string[] cities = new string[5];

for (int i = 0; i < cities.Length; i++)
{
    cities[i] = Console.ReadLine(); 
}

foreach (string city in cities) Console.WriteLine($"{city}");
*/

/*
    1. Creati un tablou de tip string[10] cu culori. Cititi culorile de la tastatura,
afisa toate culorile inafara de rosu, galben sau albastru.
    2. Creati un tablou cu tari, string[10]. Tarile le cititi de la tastatura,
afisati toate tarile inafara de China, SUA, Rusia.
    3. Creati un tablou cu celebritati, string[10]. Cititi de le tastatura.
Creati o alta variabile, p/u numele unei celebritati, afisati daca celebritatea scrisa
este in tablou
*/

/*   
    // ex 1
    Console.WriteLine(" Ex 1::"); 
    string[] colors = new string[5];
    for (int i = 0; i < colors.Length; i++)
    {
        Console.Write(" ");
        colors[i] = Console.ReadLine();
    }

    foreach (string color in colors)
    {
        if (color == "rosu" || color == "galben" || color == "albastru") continue;
        else Console.WriteLine(" " + color);
    }


    // ex 2
    Console.WriteLine("\n Ex 2::");    
    string[] countries = new string[10];
        for (int i = 0; i < countries.Length; i++)
        {
            Console.Write(" ");
            countries[i] = Console.ReadLine();
        }

        foreach (string country in countries)
        {
            if (country == "China" || country == "SUA" || country == "Rusia") continue;
            else Console.Write(" " + country);
        }

    // ex 3 
    Console.WriteLine("\n Ex 3::");
    
    string[] celebrities = new string[10];
    for (int i = 0; i < countries.Length; i++)
    {
        Console.Write(" ");
        celebrities[i] = Console.ReadLine();
    }

    Console.WriteLine(" Enter the celebrity you are searching for in your program: ");
    string celeb = Console.ReadLine();

    foreach (string celebrity in celebrities)
    {
        if (celeb == celebrity)
        {
            Console.WriteLine(" Celebritatea scrisa este in tablou");
            break;
        }
    }
*/

//int[] numbers = new int[10];
//Random rnd = new Random();

// Console.WriteLine(rnd.Next() % 10 * -1); 

//Console.Write(" Before:: ");
//foreach(int number in numbers)
//{
//    Console.Write(" " + number);
//}

// %3 == 0 -> *5
// %5 == 0 -> *100
// %100 == 0 -> *1000000

//for (int i = 0; i< numbers.Length; i++)
//{
//    if (numbers[i] % 3 == 0)
//    {
//        numbers[i] *= 5; // numbers[i] = numbers[i] * 5;
//    } else if (numbers[i] % 5 == 0) {
//        numbers[i] *= 100; 
//    } else if (numbers[i] % 100 == 0) {
//        numbers[i] *= 1000000;
//    }
//}

//Console.Write("\n After:: ");
//foreach (int number in numbers)
//{
//    Console.Write(" " + number);
//}

//int[,]x = { { 1, 2, 3 }, { 3, 4, 5 } };
//int sum = 0;

//for (int i=0; i<x.GetLength(0); i++)
//{
//    for (int j = 0; j<x.GetLength(1); j++)
//    {
//        // Console.Write(x[i,j] + " ");
//        sum += x[i, j];
//    }

//    Console.WriteLine();
//}

//Console.WriteLine(" Sum " + sum);


/*
    1. Generati un tablou random de 50 elemente. Aflati suma el. pare si suma el. impare
    2. Scrie de la tastatura un tablou de 10 elemente.
       Inmultiti fiecare al doilea element cu 4.
       Inmultiti primul cu 10 si ultimul cu 20
    3. Generati un tablou random de 15 elemente. Generati media aritmetica.
*/

    //// ex1
    //Console.WriteLine(" ex1:: ");
    //Random rnd = new Random();
    //int[] v = new int[50];
    //int sp=0, si=0;


    //foreach (int i in v)
    //{
    //    v[i] = rnd.Next() % 30;
   
    //    Console.WriteLine(" " + v[i]);
    //    if (v[i] % 2 == 0)
    //    {
    //        sp += v[i] ;
    //    } else {
    //        si += v[i];
    //    }

    //}

    //Console.WriteLine(" Suma elementelor pare = " + sp);
    //Console.WriteLine(" Suma elementelor impare = " + si);

    //// ex2
    //Console.WriteLine("\n ex2:: ");
    //int[] v2 = new int[10];

    //Console.WriteLine(" Dati elementele tabloului v2::");
    //int num = 0;
    //foreach (int i in v2)
    //{
    //    Console.Write(" ");
    //    v2[num] = Convert.ToInt32(Console.ReadLine());
    //    num++;
    //}

    //Console.WriteLine("\n\n Dupa modificari:: ");

    //for (int i = 1; i < v2.Length-1; i+=2) {
    //    v2[i] *= 4;
    //}

    //v2[0] *= 10;
    //v2[v2.Length-1] *= 20;

    //foreach (int i in v2)
    //{
    //    Console.WriteLine(" " + i);
    //}

    //// ex 3
    //Console.WriteLine("\n ex3:: ");
    //int[] v3 = new int[15];
    //int sum=0;

    //foreach (int i in v3) {

    //    v3[num] = rnd.Next()%30;
    //    Console.WriteLine(v3[num]);
    //    sum+= v3[i];
    //}

    //Console.WriteLine(" Media aritmetica = " + (double)sum/v3.Length);
 
    int sum = 0;
    Console.Write(" Enter a = ");
    int a = Convert.ToInt32(Console.ReadLine());
    int c=0;

    //while(a!=0) {

    //    sum += a;
    //    Console.Write(" Enter a = ");
    //    a = Convert.ToInt32(Console.ReadLine());
    //    c++;
    //}

    //Console.WriteLine($" Sum: {sum} ");

    do
    {
        sum += a;
        Console.Write(" Enter a = ");
        a = Convert.ToInt32(Console.ReadLine());
        c++;

    } while (a != 0);

    Console.WriteLine($" Sum: {sum} ");
    Console.WriteLine($" Media aritmetica: {sum/c}");

