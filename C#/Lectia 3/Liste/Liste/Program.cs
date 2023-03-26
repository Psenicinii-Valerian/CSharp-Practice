
//string[] words = { "Bee", "Cat", "House", "Joker" };

//for(int i = 0; i < words.Length; i++) { 
//    Console.WriteLine(words[i].Length); 
//}

//Console.WriteLine();

//foreach (string word in words) { 
//    Console.WriteLine(word); 
//}

//List<int> myList = new List<int>();

//// Add - adaugarea unui element in tablou
//myList.Add(5);
//myList.Add(6);
//myList.Add(7);
//myList.Add(8);
//myList.Add(9);

//// Count - numarul de elemente
//Console.WriteLine(myList.Count);

//foreach(int number in myList)
//{
//    Console.WriteLine(number);

//}

//List<string> words = new List<string>(3) { "Bee", "House", "Car" };

////foreach (string word in words)
////{
////    Console.WriteLine(word);
////}

//string[] x = { "Laptop", "IT", "Job" };
//words.AddRange(x);

//foreach(string word in words)
//{
//    Console.WriteLine(word);
//}

//// stergem toate elementele unui tablou
//words.Clear();

//foreach (string word in words)
//{
//    Console.WriteLine(word);
//}

//if(words.Count > 0)
//{
//    Console.WriteLine("Lista are elemente");
//} else
//{
//    Console.WriteLine("Lista nu are elemente");
//}

//List<string> cities = new List<string>() { "Paris", "Rome", "Bucharest" };
//cities.Insert(1, "Berlin"); // Paris Berlin Rome Bucharest
//cities.Insert(1, "London"); // Paris London Berlin Rome Bucharest
//cities.Insert(2, "Tokyo");  // Paris Tokyo London Berlin Rome Bucharest

//cities.RemoveAt(3); // Paris Tokyo London Rome Bucharest
//cities.RemoveAt(3); // Paris Tokyo London Bucharest
//cities.RemoveAt(cities.Count - 1); // Paris Tokyo London

//cities.Sort(); // London Paris Tokyo

//foreach (string city in cities)
//{
//    Console.WriteLine(city);
//}

//List <int> numbers = new List<int>(10) { 5, 6, 61, 64, -1, 84, 1293, 419, -2, 34 };   
//numbers.Sort();
//numbers.Reverse();

//foreach (int number in numbers)
//{
//    Console.WriteLine(number);  
//}


// SARCINA :: 
// 1.Creati lista de tip int.
// 1.1. Adaugati 10 elemente in diferite
// 1.2. Sortati lista crescator, si descrator
// 1.3. Afisati prin for si prin foreach
// 1.4. Stergeti ultimele 3 elemente


//using System.Runtime.CompilerServices;

//List <int> numbers = new List<int>() { -2, 4, 3, 92, 34, 56, 91, 33, 42, 13 };

//// sortam crescator
//numbers.Sort();


//// afisam sortarea crescatoare cu for
//Console.WriteLine(" Afisam sortarea crescatoare cu for:: \n");

//for (int i=0; i<numbers.Count; i++)
//{
//    Console.WriteLine(" " + numbers[i]);
//}


//// afisam sortarea crescatoare cu foreach
//Console.WriteLine("\n Afisam sortarea crescatoare cu foreach:: \n");

//foreach ( int num in numbers)
//{
//    Console.WriteLine(" " + num); 
//}


//// sortam descrescator
//numbers.Reverse();

//// afisam sortarea descrescatoare cu for
//Console.WriteLine("\n Afisam sortarea descrescatoare cu for:: \n");

//for (int i = 0; i < numbers.Count; i++)
//{
//    Console.WriteLine(" " + numbers[i]);
//}


//// afisam sortarea descrescatoare cu foreach
//Console.WriteLine("\n Afisam sortarea descrescatoare cu foreach:: \n");

//foreach (int num in numbers)
//{
//    Console.WriteLine(" " + num);
//}

//numbers.RemoveAt(numbers.Count - 1);
//numbers.RemoveAt(numbers.Count - 1);
//numbers.RemoveAt(numbers.Count - 1);


//// afisam lista dupa stergerea a ultimilor 3 elemente
//Console.WriteLine("\n Afisam lista de tip int dupa stergerea a ultimilor 3 elemente:: \n");
//foreach (int num in numbers)
//{
//    Console.WriteLine(" " + num);
//}


//// 2.Creati o lista de tip string
//// 2.1 Adaugati un tablou de stringuri ca valoarea (10)
//// 2.3 Pe pozitia 3 schimbati valoarea
//// 2.4. Pe pozitia adaugati o valoarea noua
//// 2.5. Primul element il stergeti
//// 2.6 Elementul de la mijloc il stergeti
//// 2.7 Afisati lista prin foreach

//Console.WriteLine("\n String List:: \n");

//List<string> names = new List<string>();
//string[] names2 = new string[] { "John", "Mikael", "Roman", "Boris", "Anton", "Daniel", "George",
//                                 "Levi", "Mike", "Leo" };

//names.AddRange(names2);

//names[3] = "Andrew";

//names.Insert(4, "Robert");
//names.RemoveAt(0);
//names.RemoveAt(names.Count/2);

//foreach(string name in names)
//{
//    Console.WriteLine(" " + name);  
//}

//List<string> myList = new List<string>();   
//string value = Console.ReadLine();
//while(value != "0")
//{
//    myList.Add(value);
//    value = Console.ReadLine(); 
//}

//Console.WriteLine();

//foreach(string word in myList)
//{
//    Console.WriteLine(word);    
//} 


//List <double> numbers = new List<double>();

//Random rnd = new Random();

//for (int i = 0; i<10; i++)
//{
//    numbers.Add(rnd.NextDouble() * 100);    
//}

//foreach(double number in numbers)
//{
//    Console.WriteLine(number);  
//}

//string[] words = { "Aberdeen", "Abilene", "Akron", "Albany", "Albuquerque", "Alexandria", "Allentown", "Amarillo", "Anaheim", "Anchorage", "Ann Arbor", "Antioch", "Apple Valley", "Appleton", "Arlington", "Arvada", "Asheville", "Athens", "Atlanta", "Atlantic City", "Augusta", "Aurora", "Austin", "Bakersfield", "Baltimore", "Barnstable", "Baton Rouge", "Beaumont", "Bel Air", "Bellevue", "Berkeley", "Bethlehem", "Billings", "Birmingham", "Bloomington", "Boise", "Boise City", "Bonita Springs", "Boston", "Boulder", "Bradenton", "Bremerton", "Bridgeport", "Brighton", "Brownsville", "Bryan", "Buffalo", "Burbank", "Burlington", "Cambridge", "Canton", "Cape Coral", "Carrollton", "Cary", "Cathedral City", "Cedar Rapids", "Champaign", "Chandler", "Charleston", "Charlotte", "Chattanooga", "Chesapeake", "Chicago", "Chula Vista", "Cincinnati", "Clarke County", "Clarksville", "Clearwater", "Cleveland", "College Station", "Colorado Springs", "Columbia", "Columbus", "Concord", "Coral Springs", "Corona", "Corpus Christi", "Costa Mesa", "Dallas", "Daly City", "Danbury", "Davenport", "Davidson County", "Dayton", "Daytona Beach", "Deltona", "Denton", "Denver", "Des Moines", "Detroit", "Downey", "Duluth", "Durham", "El Monte", "El Paso", "Elizabeth", "Elk Grove", "Elkhart", "Erie", "Escondido", "Eugene", "Evansville", "Fairfield", "Fargo", "Fayetteville", "Fitchburg", "Flint", "Fontana", "Fort Collins", "Fort Lauderdale", "Fort Smith", "Fort Walton Beach", "Fort Wayne", "Fort Worth", "Frederick", "Fremont", "Fresno", "Fullerton", "Gainesville", "Garden Grove", "Garland", "Gastonia", "Gilbert", "Glendale", "Grand Prairie", "Grand Rapids", "Grayslake", "Green Bay", "GreenBay", "Greensboro", "Greenville", "Gulfport-Biloxi", "Hagerstown", "Hampton", "Harlingen", "Harrisburg", "Hartford", "Havre de Grace", "Hayward", "Hemet", "Henderson", "Hesperia", "Hialeah", "Hickory", "High Point", "Hollywood", "Honolulu", "Houma", "Houston", "Howell", "Huntington", "Huntington Beach", "Huntsville", "Independence", "Indianapolis", "Inglewood", "Irvine", "Irving", "Jackson", "Jacksonville", "Jefferson", "Jersey City", "Johnson City", "Joliet", "Kailua", "Kalamazoo", "Kaneohe", "Kansas City", "Kennewick", "Kenosha", "Killeen", "Kissimmee", "Knoxville", "Lacey", "Lafayette", "Lake Charles", "Lakeland", "Lakewood", "Lancaster", "Lansing", "Laredo", "Las Cruces", "Las Vegas", "Layton", "Leominster", "Lewisville", "Lexington", "Lincoln", "Little Rock", "Long Beach", "Lorain", "Los Angeles", "Louisville", "Lowell", "Lubbock", "Macon", "Madison", "Manchester", "Marina", "Marysville", "McAllen", "McHenry", "Medford", "Melbourne", "Memphis", "Merced", "Mesa", "Mesquite", "Miami", "Milwaukee", "Minneapolis", "Miramar", "Mission Viejo", "Mobile", "Modesto", "Monroe", "Monterey", "Montgomery", "Moreno Valley", "Murfreesboro", "Murrieta", "Muskegon", "Myrtle Beach", "Naperville", "Naples", "Nashua", "Nashville", "New Bedford", "New Haven", "New London", "New Orleans", "New York", "New York City", "Newark", "Newburgh", "Newport News", "Norfolk", "Normal", "Norman", "North Charleston", "North Las Vegas", "North Port", "Norwalk", "Norwich", "Oakland", "Ocala", "Oceanside", "Odessa", "Ogden", "Oklahoma City", "Olathe", "Olympia", "Omaha", "Ontario", "Orange", "Orem", "Orlando", "Overland Park", "Oxnard", "Palm Bay", "Palm Springs", "Palmdale", "Panama City", "Pasadena", "Paterson", "Pembroke Pines", "Pensacola", "Peoria", "Philadelphia", "Phoenix", "Pittsburgh", "Plano", "Pomona", "Pompano Beach", "Port Arthur", "Port Orange", "Port Saint Lucie", "Port St. Lucie", "Portland", "Portsmouth", "Poughkeepsie", "Providence", "Provo", "Pueblo", "Punta Gorda", "Racine", "Raleigh", "Rancho Cucamonga", "Reading", "Redding", "Reno", "Richland", "Richmond", "Richmond County", "Riverside", "Roanoke", "Rochester", "Rockford", "Roseville", "Round Lake Beach", "Sacramento", "Saginaw", "Saint Louis", "Saint Paul", "Saint Petersburg", "Salem", "Salinas", "Salt Lake City", "San Antonio", "San Bernardino", "San Buenaventura", "San Diego", "San Francisco", "San Jose", "Santa Ana", "Santa Barbara", "Santa Clara", "Santa Clarita", "Santa Cruz", "Santa Maria", "Santa Rosa", "Sarasota", "Savannah", "Scottsdale", "Scranton", "Seaside", "Seattle", "Sebastian", "Shreveport", "Simi Valley", "Sioux City", "Sioux Falls", "South Bend", "South Lyon", "Spartanburg", "Spokane", "Springdale", "Springfield", "St. Louis", "St. Paul", "St. Petersburg", "Stamford", "Sterling Heights", "Stockton", "Sunnyvale", "Syracuse", "Tacoma", "Tallahassee", "Tampa", "Temecula", "Tempe", "Thornton", "Thousand Oaks", "Toledo", "Topeka", "Torrance", "Trenton", "Tucson", "Tulsa", "Tuscaloosa", "Tyler", "Utica", "Vallejo", "Vancouver", "Vero Beach", "Victorville", "Virginia Beach", "Visalia", "Waco", "Warren", "Washington", "Waterbury", "Waterloo", "West Covina", "West Valley City", "Westminster", "Wichita", "Wilmington", "Winston", "Winter Haven", "Worcester", "Yakima", "Yonkers", "York", "Youngstown" };

//List<string> cities = new List<string>();

//Random rand = new Random();

//for(int i=0; i<5; i++)
//{
//    cities.Add(words[rand.Next(words.Length)]);
//}

//foreach (string city in cities)
//{
//    Console.WriteLine(city);
//}

//string symbols = "1234567890!@#$%^&*()ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

//Console.Write(" Inserati nr. de caractere ce doriti ca parola dvs. sa contina:: ");

//int nrOfCharacters = Convert.ToInt32(Console.ReadLine());

//Random rnd = new Random();

//string password = "";

//Console.Write("\n Random generated password:: ");

//for (int i = 0; i < nrOfCharacters; i++)
//{
//    password += symbols[rnd.Next(0, symbols.Length)];
//}

//Console.WriteLine(password);

// Generarea automata a numelui unei persoane. (Prenume si Nume)
// Sa adaugati in lista numele generate automat (aleatoriu)
// Afisati lista

string[] nume = new string[] { "Rusu", "Mihaiuc", "Cipariu", "Andronachi", "Vasilachi", "Balaban", "Aron",
                              "Eminescu", "Stance", "Cipleu", "Carp", "Gutu", "Gorbatiuc" };
string[] prenume = new string[] {"Andrei", "Dan", "Ilie", "Mihai", "Ion", "Vasile", "Razvan", "Geroge",
                                 "Ana", "Maria", "Dana", "Victoria", "Andreea", "Alexandra"};

Console.Write(" Inserati nr. de nume ce doriti sa generati:: ");

Random rand = new Random();

int nrOfNames= Convert.ToInt32(Console.ReadLine());

List<string> namesGenerator = new List<string>();

Console.WriteLine();

while(namesGenerator.Count < nrOfNames)
{
    string newName = nume[rand.Next(0, nume.Length)] + ' ' + prenume[rand.Next(0, prenume.Length)];

    bool found = false;

    foreach (string name in namesGenerator)
    {
        if (name == newName)
        {
            found = true;
            Console.WriteLine(" Atentie " + name + " este deja in lista!");
            break;
        }
    }

    if (!found) namesGenerator.Add(newName);

}

Console.WriteLine();

foreach(string name in namesGenerator)
{
    Console.WriteLine(' ' + name);
}