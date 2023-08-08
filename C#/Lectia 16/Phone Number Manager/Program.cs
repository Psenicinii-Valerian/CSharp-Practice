using MySql.Data.MySqlClient;

namespace Phone_Number_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome to Phone Number Manager!");

            string ConnectionString = "server=localhost; port=4000; user=root; database=phonem; password=";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();

            while (true)
            {
                Console.WriteLine("***************Add a new phone number***************");
                Console.Write("Number: ");
                string number = Console.ReadLine();
                Console.Write("Country: ");
                string country = Console.ReadLine();
                Console.Write("Provider: ");
                string provider = Console.ReadLine();
                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                string sqlAdd = "INSERT INTO phone_numbers(number, country, provider, price) VALUES (@V1, @V2, @V3, @V4)";
                using (MySqlCommand add = new MySqlCommand(sqlAdd, connection))
                {
                    add.Parameters.AddWithValue("@V1", number);
                    add.Parameters.AddWithValue("@V2", country);
                    add.Parameters.AddWithValue("@V3", provider);
                    add.Parameters.AddWithValue("@V4", price);

                    add.ExecuteNonQuery();
                }

                char option;

                try
                {
                    Console.Write("Press any key to continue (X to exit): ");
                    option = Console.ReadLine()[0];
                    if (option == 88 || option == 120) break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong!");
                }
            }

            Console.WriteLine("----------------Showing phone numbers----------------");
            ShowData("SELECT * FROM phone_numbers", connection);
        }

        public static void ShowData(string sql, MySqlConnection connection)
        {
            MySqlCommand result = new MySqlCommand(sql, connection);

            using (MySqlDataReader reader = result.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"{reader.GetString("number")} {reader.GetString("country")} " +
                                     $"{reader.GetString("provider")} {reader.GetDouble("price").ToString("F2")}$$");
                }
            }
        }
    }
}