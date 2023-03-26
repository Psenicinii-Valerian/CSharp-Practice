namespace Sarcina_2
{
    internal class Program
    {

        static double moneyConverter(double sum, string sumCurrency, string currencyToConvert)
        {
            switch(sumCurrency, currencyToConvert)
            {
                case ("lei", "euro"): return sum * 0.049;
                case ("euro", "lei"): return sum * 20.61;
                default:return 0;
            }      
        }
        static int Main(string[] args)
        {
            // Creati o functie de tip Converter.
            // (Scrie o suma in lei primiti in Euro/ Scrieti o suma in Euro primiti in lei)

            // -> (suma, valutaSumei, valutaDeConvertire).

            double lei;
            double euro;

            string option;
            Console.Write(" Do you want to convert lei-euro or euro-lei:: ");
            option = Console.ReadLine();

            switch(option)
            {
                case "lei-euro": Console.Write(" Introuduceti suma (in lei):: ");
                    lei = Convert.ToDouble(Console.ReadLine());
                    euro = moneyConverter(lei, "lei", "euro");
                    Console.WriteLine(" " + lei + " lei = " + euro + " euro");
                    break;

                case "euro-lei":
                    Console.Write(" Introuduceti suma (in euro):: ");
                    euro = Convert.ToDouble(Console.ReadLine());
                    lei = moneyConverter(euro, "euro", "lei");
                    Console.WriteLine(" " + euro + " lei = " + lei + " euro");
                    break;
                    
                default: Console.WriteLine(" Din pacate ati introdus o optiune inexistenta!");
                    break;
                    
            }

            return 0;
        }
    }
}