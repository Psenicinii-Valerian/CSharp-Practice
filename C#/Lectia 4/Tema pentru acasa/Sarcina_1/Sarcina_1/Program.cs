namespace Sarcina_1
{
    internal class Program
    {
        static double kmToMile(int km)
        {
            return km * 1.609344;     
        }


        static int Main(string[] args)
        {
            // 1. Creati o functie care transforma KM in mile

            int km;
            Console.Write(" Dati numarul de km ce doriti sa il convertiti in mile:: ");
            km = Convert.ToInt32(Console.ReadLine());

            double miles;
            miles = kmToMile(km);

            Console.WriteLine(" " + km + " km = " + miles + " mile");

            return 0;
        }
    }
}