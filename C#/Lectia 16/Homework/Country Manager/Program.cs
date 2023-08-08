using MySql.Data.MySqlClient;

namespace Country_Manager
{
    internal class Program
    {
        public static string connection = "server=localhost; port=4000; database=country_manager; user=root; password=";
        public static MySqlConnection myConnection = new MySqlConnection(connection);

        public static void Read(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, myConnection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"Name: {reader.GetString(1)}");
                    Console.WriteLine($"Capital: {reader.GetString(2)}");
                    Console.WriteLine($"Continent: {reader.GetString(3)}");
                    Console.WriteLine($"President: {reader.GetString(4)}");
                    Console.WriteLine($"Population: {reader.GetString(5)}mln.");
                    Console.WriteLine($"Surface: {reader.GetString(6)}square km");
                    Console.WriteLine();
                }
            }
        }

        public static void Create()
        {
            Console.WriteLine("Insert values for your country:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Capital: ");
            string capital = Console.ReadLine();

            Console.Write("Continent: ");
            string continent = Console.ReadLine();

            Console.Write("President: ");
            string president = Console.ReadLine();

            Console.Write("Population(mln.): ");
            double population = Convert.ToDouble(Console.ReadLine());

            Console.Write("Surface (square km): ");
            double surface = Convert.ToDouble(Console.ReadLine());

            string sql = "INSERT INTO countries (name, capital, continent, president, population, surface) VALUES " +
                                                "(@value1, @value2, @value3, @value4, @value5, @value6)";

            MySqlCommand insert = new MySqlCommand(sql, myConnection);

            insert.Parameters.AddWithValue("@value1", name);
            insert.Parameters.AddWithValue("@value2", capital);
            insert.Parameters.AddWithValue("@value3", continent);
            insert.Parameters.AddWithValue("@value4", president);
            insert.Parameters.AddWithValue("@value5", population);
            insert.Parameters.AddWithValue("@value6", surface);

            int rowsAffected = insert.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Something went wrong!");
            }
        }

        public static void Main(string[] args)
        {
            myConnection.Open();
            char option;

            Console.WriteLine("Select one of the following options: \n1. Create\n2. Read\nX. Exit");
            Console.Write("Enter your choice: ");
            option = Console.ReadLine()[0];
            Console.WriteLine();

            while (true)
            {
                switch (option)
                {
                    case '1':
                        // Create
                        Create();
                        break;
                    case '2':
                        // Read
                        Read("SELECT * FROM countries");
                        break;
                    case 'x':
                    case 'X':
                        Environment.Exit(0);
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Select one of the following options: \n1. Create\n2. Read\nX. Exit");
                Console.Write("Enter your choice: ");
                option = Console.ReadLine()[0];
                Console.WriteLine();
                Console.Clear();
            }
        }
    }
}