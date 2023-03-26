using System.Text.RegularExpressions;

namespace Task_1_Regex
{
    internal class Program
    {
        static void countryMenu()
        {
            Console.WriteLine("*****************Select the country to dial internationally******************\n");
            Console.WriteLine("1 - Italy");
            Console.WriteLine("2 - France");
            Console.WriteLine("3 - Spain");
            Console.WriteLine("4 - Norway");
            Console.WriteLine("5 - Germany");
            Console.Write("\nYour choice:: ");
        }
        static void Main(string[] args)
        {
            // login validation
            Console.Write("Login: ");
            string login = Console.ReadLine();

            Regex loginRegex = new Regex("^[A-Za-z0-9$_.]{3,20}$");
            while (!loginRegex.IsMatch(login))
            {
                Console.WriteLine("\nWrong login pattern! Try inserting another one!");
                Console.Write("Login: ");
                login = Console.ReadLine();
            }

            Console.Write("-------Login validated!-------");

            // email validation
            Console.Write("\n\nEmail: ");
            string email = Console.ReadLine();

            Regex emailRegex = new Regex("^[A-Za-z][A-Za-z0-9_.$]{3,30}@(gmail|mail|yahoo|outlook|domain)" +
                "(.ru|.com|.org|.ro|.net)(.co|.uk|.io.|.de)?$");
            while (!emailRegex.IsMatch(email))
            {
                Console.WriteLine("\nWrong email pattern! Try inserting another one!");
                Console.Write("Email: ");
                email = Console.ReadLine();
            }

            Console.Write("-------Email validated!-------");

            // adress validation
            Console.Write("\n\nAddress: ");
            string address = Console.ReadLine();

            Regex addressRegex = new Regex("^[A-Z][a-z]{3,25}(\\s[a-z]{2,10})?(\\s[A-Z][a-z]{3,20})?(\\s[0-9]{1,4})?$");
            while (!addressRegex.IsMatch(address))
            {
                Console.WriteLine("\nWrong address pattern! Try inserting another one!");
                Console.Write("Address: ");
                address = Console.ReadLine();
            }

            Console.Write("-------Address validated!-------");

            // country validation
            Console.Write("\n\nCountry: ");
            string country = Console.ReadLine();

            Regex countryRegex = new Regex("^[A-Z][a-z]{2,25}(\\s[a-z]{2,10})?(\\s-)?(\\s[A-Z][a-z]{3,25})?$");
            while (!countryRegex.IsMatch(country))
            {
                Console.WriteLine("\nWrong country pattern! Try inserting another one!");
                Console.Write("Country: ");
                country = Console.ReadLine();
            }

            Console.Write("-------Country validated!-------");

            // city validation
            Console.Write("\n\nCity: ");
            string city = Console.ReadLine();

            Regex cityRegex = new Regex("^[A-Z][a-z]{2,25}(\\s[a-z]{2,10})?(\\s-)?(\\s[A-Z][a-z]{3,25})?$");
            while (!cityRegex.IsMatch(city))
            {
                Console.WriteLine("\nWrong city pattern! Try inserting another one!");
                Console.Write("City: ");
                city = Console.ReadLine();

            }
            Console.Write("-------City validated!-------");

            // phone number
            /*          
                Console.Write("\n\nPhone number: ");
                string phoneNumber = Console.ReadLine();

                Regex phoneNumberRegex = new Regex("^\\+[1-9][0-9]{6,12}?$");
                while (!phoneNumberRegex.IsMatch(phoneNumber))
                {
                    Console.WriteLine("\nWrong phone number pattern! Try inserting another one!");
                    Console.Write("Phone number: ");
                    phoneNumber = Console.ReadLine();

                }
                Console.Write("-------Phone number validated!-------");
            */

            Console.WriteLine("\n\n");
            countryMenu();
            int option = Console.ReadKey(true).KeyChar;

            switch (option)
            {
                case '1':
                    {
                        Console.Write("\nEnter an italian phone number: ");
                        string phoneNumber = Console.ReadLine();

                        Regex phoneNumberRegex = new Regex("^\\+39[0-9]{10}$");
                        while (!phoneNumberRegex.IsMatch(phoneNumber))
                        {
                            Console.WriteLine("\nWrong phone number pattern! Try inserting another one!");
                            Console.Write("Phone number: ");
                            phoneNumber = Console.ReadLine();

                        }
                        Console.Write("-------Phone number validated!-------");

                        break;
                    }

                case '2':
                    {
                        Console.Write("\nEnter a french phone number: ");
                        string phoneNumber = Console.ReadLine();

                        Regex phoneNumberRegex = new Regex("^\\+33[0-9]{9}$");
                        while (!phoneNumberRegex.IsMatch(phoneNumber))
                        {
                            Console.WriteLine("\nWrong phone number pattern! Try inserting another one!");
                            Console.Write("Phone number: ");
                            phoneNumber = Console.ReadLine();

                        }
                        Console.Write("-------Phone number validated!-------");

                        break;
                    }

                case '3':
                    {
                        Console.Write("\nEnter a spanish phone number: ");
                        string phoneNumber = Console.ReadLine();

                        Regex phoneNumberRegex = new Regex("^\\+34[0-9]{9}$");
                        while (!phoneNumberRegex.IsMatch(phoneNumber))
                        {
                            Console.WriteLine("\nWrong phone number pattern! Try inserting another one!");
                            Console.Write("Phone number: ");
                            phoneNumber = Console.ReadLine();

                        }
                        Console.Write("-------Phone number validated!-------");

                        break;
                    }

                case '4':
                    {
                        Console.Write("\nEnter a norwegian phone number: ");
                        string phoneNumber = Console.ReadLine();

                        Regex phoneNumberRegex = new Regex("^\\+47[0-9]{8}$");
                        while (!phoneNumberRegex.IsMatch(phoneNumber))
                        {
                            Console.WriteLine("\nWrong phone number pattern! Try inserting another one!");
                            Console.Write("Phone number: ");
                            phoneNumber = Console.ReadLine();

                        }
                        Console.Write("-------Phone number validated!-------");

                        break;
                    }

                case '5':
                    {
                        Console.Write("\nEnter a german phone number: ");
                        string phoneNumber = Console.ReadLine();

                        Regex phoneNumberRegex = new Regex("^\\+49[0-9]{7}$");
                        while (!phoneNumberRegex.IsMatch(phoneNumber))
                        {
                            Console.WriteLine("\nWrong phone number pattern! Try inserting another one!");
                            Console.Write("Phone number: ");
                            phoneNumber = Console.ReadLine();

                        }
                        Console.Write("-------Phone number validated!-------");

                        break;
                    }

                default:
                    Console.WriteLine("Wrong option!");
                    break;
            }
        }
    }
}