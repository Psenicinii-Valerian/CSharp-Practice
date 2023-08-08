using MySql.Data.MySqlClient;

namespace Car_Market
{
    internal class Program
    {
        public static string connection = "server=localhost; port=4000; database=car_market; user=root; password=";
        public static MySqlConnection myConnection = new MySqlConnection(connection);

        public static void Read(string sql)
        {
            MySqlCommand c1 = new MySqlCommand(sql, myConnection);

            using (MySqlDataReader reader = c1.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"{reader.GetString(0)} {reader.GetString(1)} {reader.GetString(2)} {reader.GetString(3)}$");
                    if (reader.GetBoolean(4))
                    {
                        Console.WriteLine("The car is available for sale!");
                    }
                    else
                    {
                        Console.WriteLine("The car has been sold.");
                    }
                }
            }
        }

        public static void Create()
        {
            Console.WriteLine("Insert values for your car:");

            Console.Write("Brand: ");
            string brand = Console.ReadLine();

            Console.Write("Model: ");
            string model = Console.ReadLine();

            Console.Write("Price($): ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Status(True - for sale/False - sold out): ");
            bool status = Boolean.Parse(Console.ReadLine());

            string sql = "INSERT INTO cars (brand, model, price, status) VALUES (@value1, @value2, @value3, @value4)";
            MySqlCommand insert = new MySqlCommand(sql, myConnection);

            insert.Parameters.AddWithValue("@value1", brand);
            insert.Parameters.AddWithValue("@value2", model);
            insert.Parameters.AddWithValue("@value3", price);
            insert.Parameters.AddWithValue("@value4", status);

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

        public static void Update(int id)
        {
            Console.WriteLine("Is the car for sale? (y/n)");
            char answer = Console.ReadLine()[0];

            string sql = $"UPDATE cars SET status = @value WHERE id = {id}";
            bool response = answer == 'y' ? true : false;

            MySqlCommand update = new MySqlCommand(sql, myConnection);
            update.Parameters.AddWithValue("@value", response);

            int rowsAffected = update.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Something went wrong!");
            }
        }

        public static void Delete(int id)
        {
            string sql = $"DELETE FROM cars WHERE id = {id}";

            MySqlCommand delete = new MySqlCommand(sql, myConnection);

            delete.ExecuteNonQuery();
        }

        public static void Main(string[] args)
        {
            myConnection.Open();
            int id;
            char option;

            Console.WriteLine("Select one of the following options: \n1. Create\n2. Update\n3. Read\n4. Delete");
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
                        // Update
                        Console.WriteLine();
                        Console.Write("Enter the id of the car you want to modify: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Update(id);
                        break;
                    case '3':
                        // Read
                        Read("SELECT * FROM cars");
                        break;
                    case '4':
                        // Delete
                        Console.WriteLine();
                        Console.Write("Enter the id of the car you want to delete: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Delete(id);
                        break;
                    case 'x':
                    case 'X':
                        Environment.Exit(0);
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Select one of the following options: \n1. Create\n2. Update\n3. Read\n4. Delete\nX. Exit");
                Console.Write("Enter your choice: ");
                option = Console.ReadLine()[0];
                Console.WriteLine();
                Console.Clear();
            }
        }

    }
}