using System.Text.RegularExpressions;

namespace Regex_in_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            
                // comanda de regex
                string pattern = @"[A-Z]{3,}";

                // crearea obiectului de regex
                Regex rg = new Regex(pattern);

                // cream obiectul p/u verificarea daca un text corespunde regexului
                // MatchCollection - cauta toate cazurile de egalitate (valide) intr-un
                MatchCollection match = rg.Matches("ABECEDAR A123 AAAAA");

                Console.WriteLine(match.Count);

                foreach (var m in match)
                {
                    Console.WriteLine(m);
                }

                for (int i = 0; i<match.Count; i++)
                {
                    Console.WriteLine(match[i]);
                }
            */


            // crearea unui obiect regex(pattern, flag1 | flag2 | flag3)
            Regex rg = new Regex("^[A-Z0-9]+$", RegexOptions.IgnoreCase | // + similar cu {1,}
                RegexOptions.IgnorePatternWhitespace | RegexOptions.Singleline);

            // pentru a verifica un singur element/cuvant ne este suficienta si metoda rg.IsMatch("cuvant de verificat")
            if (rg.IsMatch("SALut123"))
            {
                Console.WriteLine("+");
            }

            Console.WriteLine("\nRegister your new account");

            Console.Write("Login: ");
            string login = Console.ReadLine();

            Regex loginRegex = new Regex("^[a-z0-9_$]{3,30}$");

            while (!loginRegex.IsMatch(login))
            {
                Console.WriteLine("\nLogin written incorrectly. Write it again");
                Console.Write("Try again, write login: ");
                login = Console.ReadLine();
            }

            Console.Write("\nPassword: ");
            string password = Console.ReadLine();

            Regex passwordRegex = new Regex("^[A-Za-z0-9!@#$_]{8,30}$");

            while (!passwordRegex.IsMatch(password))
            {
                Console.WriteLine("\nPassword written incorrectly. Write it again");
                Console.Write("Try again, write password: ");
                password = Console.ReadLine();
            }

            Console.WriteLine("------------------Account registered!------------------");
        }
    }
}