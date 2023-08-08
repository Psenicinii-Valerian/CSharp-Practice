using MySql.Data.MySqlClient;

namespace AutoC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome to AutoC");

            // Scriem datele necesare pentru conexiunea cu baza de date 
            string ConnectionString = "server=localhost; port=4000; user=root; database=autoc; password="; 

            // Stabilim conexiunea cu baza de date
            MySqlConnection connection = new MySqlConnection(ConnectionString);

            // Deschiderea conexiunii
            connection.Open();

            // Definim comanda de SQL
            string sql = "Select * FROM cars";

            // Crearea unei variabile pentru citirea datelor din DB 
            MySqlCommand cars = new MySqlCommand(sql, connection);

            // Verificare daca este posibil de citit datele si primirea acestor in variabila reader 
            using (MySqlDataReader reader = cars.ExecuteReader())
            {
                Console.WriteLine("--------------Showing cars--------------");

                // Citim toate randurile din SQL pana nu se termina
                while (reader.Read())
                {
                    Console.WriteLine($"{reader.GetString("brand")} {reader.GetString("model")} " +
                                      $"{reader.GetDouble("price").ToString("F2")}$$ {reader.GetString("category")}");
                }
                // reader.GetDouble("price").ToString("F2") 
                // Ne permite sa formatam un double ca acesta mereu sa aiba 2 cifre dupa virgula (chiar daca este .00)
            }

            Console.WriteLine("***************************************");

            Console.WriteLine("Sport cars: ");
            ShowData("SELECT * FROM cars WHERE category = 'Sport car'", connection);

            Console.WriteLine("\nSedan: ");
            ShowData("SELECT * FROM cars WHERE category = 'Sedan'", connection);

            Console.WriteLine("\nStreet cars: ");
            ShowData("SELECT * FROM cars WHERE category = 'Street car'", connection);

            Console.WriteLine("***************************************");
            Console.WriteLine("Add your car:");
            Console.Write("Brand: ");
            string brand = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Category: ");
            string category = Console.ReadLine();

            string addSql = "INSERT INTO cars(brand, model, price, category) VALUES (@V1, @V2, @V3, @V4)";
            using (MySqlCommand add = new MySqlCommand(addSql, connection))
            {
                add.Parameters.AddWithValue("@V1", brand);
                add.Parameters.AddWithValue("@V2", model);
                add.Parameters.AddWithValue("@V3", price);
                add.Parameters.AddWithValue("@V4", category);
                
                add.ExecuteNonQuery();
            }

            Console.WriteLine("--------------Showing cars--------------");

            ShowData("SELECT * FROM cars", connection);
        }

        public static void ShowData(string sql, MySqlConnection connection)
        {
            MySqlCommand result = new MySqlCommand(sql, connection);

            using (MySqlDataReader reader = result.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"{reader.GetString("brand")} {reader.GetString("model")} " +
                                      $"{reader.GetDouble("price").ToString("F2")}$$ {reader.GetString("category")}");
                }
            }
        }
    }
}