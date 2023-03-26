using System.Xml.Linq;

static void Greeting()
{
    Console.WriteLine("Hello");
}

static int getNumber()
{
    return 5;
}

static int calculate(int a = 1, int b = 5)
{
    return a * b;
}

static string reverseWord(string word)
{
    // ABC => 'C' 'B' 'A' => CBA
    //char[] wordArray = word.ToCharArray();
    //Array.Reverse(wordArray); // primesc tablou

    //return new string(wordArray);

    string result = "";
    for (int i = word.Length-1; i >= 0; i--)
    {
        result += word[i];
    }

    return result;
}   

static int[] getArray()
{
    int[] array = {1, 2, 3, 4, 5};
    return array;
}

static List<int> createArray(int nrOfElements)
{
    Random rnd = new Random();

    List<int> temp = new List<int>();

    for (int i = 0; i < nrOfElements; i++)
    {
        temp.Add(rnd.Next()%1000);
    }

    return temp;
}


// main() here

/*
Greeting();
Console.WriteLine(getNumber());
//Console.WriteLine(calculate(2, 10));
Console.WriteLine(calculate());
Console.WriteLine(reverseWord("ABC"));

Console.WriteLine();

int[] a = getArray();
foreach(int item in a)
{
    Console.Write(item);
}

Console.WriteLine();
Console.WriteLine();

List<int> x = new List<int>(createArray(10));
foreach(int item in x)
{
    Console.WriteLine(item);
}

Random rnd = new Random();
Console.WriteLine(Math.Round(rnd.NextDouble()%5 + 10, 2));
*/

// sarcini de lucru
/*
 * Creati o metoda care va afișa valoarea unui parametru în consola
 * Creati o metoda care va returna un număr random de la 0 pana la 1000
 * Creati o metoda care va returna o lista de numere zecimale random cu 3 cifre după punct. Parametri(nrDeElemente, elMinim, elMaxim)
 * Creati o metoda care va returna o lista de char random
 * Creati o metoda care va avisa suma a 5 numere
 */

/*
// ex 1
static void getString(string word)
{
    Console.WriteLine(" Parametrul trimis este:: " + word);
}

// ex 2
static int getRandom()
{
    Random rnd = new Random();
    return rnd.Next() % 1000;
}

// ex 3
static List<double> getDoubleRandom(int nrOfElements, int minElement, int maxElement)
{
    Random rnd = new Random();
    List<double> temp = new List<double>();

    for (int i = 0; i < nrOfElements; i++)
    {
        temp.Add(Math.Round(rnd.NextDouble() * (maxElement - minElement) + minElement, 3));
    }

    return temp;
}

// ex 4
static List<char> getCharRandom(int nrOfElements)
{
    Random rnd = new Random();
    List<char> temp = new List<char>();

    for (int i = 0; i < nrOfElements; i++)
    {
        temp.Add((char)('a' + (rnd.Next()%26)));
    }

    return temp;

}

// ex 5
static int sum(int a = 1, int b = 2, int c = 3, int d = 4, int e = 5)
{
    return a + b + c + d + e;
}

// *** main() here 2 ***

// ex 1 
getString("Hello World!");
Console.WriteLine();

// ex 2
Console.WriteLine(" " + getRandom());
Console.WriteLine();

// ex 3
List<double> randomDouble = new List<double>(getDoubleRandom(10, 5, 145));
int i = 1;
foreach (double item in randomDouble)
{
    Console.WriteLine(" Random double element [" + i + "] = " + item);
    i++;
}
Console.WriteLine();

// ex 4
List<char> randomChar = new List<char>(getCharRandom(7));
i = 1;
foreach (char item in randomChar)
{
    Console.WriteLine(" Random char element [" + i + "] = " + item);
    i++;
}
Console.WriteLine();

// ex 5
Console.WriteLine(" " + sum());
Console.WriteLine();
*/

static double[] changeArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 100)
        {
            array[i] = Math.Pow(array[i], 2);

        } else {
            array[i] = Math.Sqrt(array[i]);
        }
    }

    return array;
}


// *** main() is here ***
/*
double[] x = { 10, 500, 64, 36, 144};
x = changeArray(x);

foreach(double item in x)
{
    Console.WriteLine(item);
}

Console.WriteLine();
Console.WriteLine(Math.Max(10, 2));
Console.WriteLine(Math.Min(9.24, 2.33));
Console.WriteLine(Math.Abs(-5.2));
Console.WriteLine(Math.Round(5.53919321, 3));
*/

/*
 * int a = 10;
Console.WriteLine(a.GetType());

double b = 11.3;
Console.WriteLine(b.GetType());

double x = 10.10;
int z = (int)x;
Console.WriteLine(z.GetType());

// (int) :: DOUBLE -> INT si INVERS

string n = "700";
int m = int.Parse(n);
Console.WriteLine(m + " " + m.GetType());

// PARSE :: STRING -> INT

*/

/*
 * int a = 38;
bool b = Convert.ToBoolean(a); // true
Console.WriteLine(b + " " + b.GetType());

char c = Convert.ToChar(a); // ASCII
Console.WriteLine(c + " " + c.GetType());

string d = "m";
char e = Convert.ToChar(d);
Console.WriteLine(e + " " + e.GetType());
*/

/*
 * string a1 = "123";
int a2 = Convert.ToInt32(a1);
Console.WriteLine(a2 + " " + a2.GetType());

string a3 = Convert.ToString(a2);
Console.WriteLine(a3 + " " + a3.GetType());
*/

static double calculator(double a, double b, char op)
{
    switch(op) {
        case '+': return a + b;
        case '-': return a - b;
        case '*': return a * b;
        case '/': 
            if (b == 0) 
            { 
                return a / 1;  
            } else {
                return a / b;
            }
        default: return 0;
    }
}

static void start()
{
    Console.WriteLine("Insert value1, value2 and the operation to do with them::");
    double sum = Convert.ToDouble(Console.ReadLine());
    double b = Convert.ToDouble(Console.ReadLine());
    char op = Console.ReadLine()[0];

    while (op != 'x')
    {
        sum = calculator(sum, b, op);
        Console.WriteLine("Total:: " + sum);

        b = Convert.ToDouble(Console.ReadLine());
        op = Console.ReadLine()[0];

        if (op == 'r')
        {
            sum = Convert.ToDouble(Console.ReadLine());
            op = Console.ReadLine()[0];
        }
    }
}

// *** main() here 4 ***
start();