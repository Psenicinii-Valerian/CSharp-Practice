using MySql.Data.MySqlClient;

namespace School_Courses_Manager
{
    internal class Program
    {
        public static string connection = "server=localhost; port=4000; database=school; uid=root; pwd=";
        public static MySqlConnection myConnection = new MySqlConnection(connection);

        public static void Read(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, myConnection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["id"].ToString()}");
                    Console.WriteLine($"Course name: {reader["name"].ToString()}");
                    Console.WriteLine($"Description: {reader["description"].ToString()}");
                    Console.WriteLine($"Price: {reader["price"].ToString()}");
                    Console.WriteLine($"Teacher: {reader["teacher"].ToString()}");
                    Console.WriteLine($"Duration: {reader["duration"].ToString()}");
                    Console.WriteLine();
                }
            }
        }

        public static void Create()
        {
            Console.WriteLine("Enter values for your course:");

            Console.Write("Enter course's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter courses's description: ");
            string description = Console.ReadLine();

            Console.Write("Enter courses's price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter courses's teacher: ");
            string teacher = Console.ReadLine();

            Console.Write("Enter course's duration(in years): ");
            double duration = Convert.ToDouble(Console.ReadLine());

            string create = "INSERT INTO courses(name, description, price, teacher, duration) VALUES " +
                            "(@value1, @value2, @value3, @value4, @value5)";

            MySqlCommand insert = new MySqlCommand(create, myConnection);
            insert.Parameters.AddWithValue("@value1", name);
            insert.Parameters.AddWithValue("@value2", description);
            insert.Parameters.AddWithValue("@value3", price);
            insert.Parameters.AddWithValue("@value4", teacher);
            insert.Parameters.AddWithValue("@value5", duration);

            int rowsAffected = insert.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Console.WriteLine("Course info created successfully!");
            }
            else
            {
                Console.WriteLine("Something went wrong during inserting course information.");
            }
        }

        public static void Update(int id)
        {
            bool run = true;
            string response = "";
            string wait = "";
            double dblResponse = 0;
            string sql = "";
            char option;

            List<string> valuesAvailable = new List<string>() {
                "name",
                "description",  
                "price",
                "teacher",
                "duration",
            };

            while (run)
            {
                Console.WriteLine("Enter what column(value) you want to modify: ");
                int i = 1;
                foreach (var value in valuesAvailable)
                {
                    Console.WriteLine($"{i++}. {value}");
                }
                Console.WriteLine("X. Stop modifying");
                option = Console.ReadLine()[0];

                switch (option)
                {
                    case '1':
                        Console.Write("Enter new course's name: ");
                        response = Console.ReadLine();
                        sql = $"UPDATE courses SET name = @value WHERE id = {id}";
                        break;
                    case '2':
                        Console.Write("Enter new course's description: ");
                        response = Console.ReadLine();
                        sql = $"UPDATE courses SET description = @value WHERE id = {id}";
                        break;
                    case '3':
                        Console.Write("Enter new course's price: ");
                        dblResponse = Convert.ToDouble(Console.ReadLine());
                        sql = $"UPDATE courses SET price = @value WHERE id = {id}";
                        break;
                    case '4':
                        Console.Write("Enter new course's teacher: ");
                        response = Console.ReadLine();
                        sql = $"UPDATE courses SET teacher = @value WHERE id = {id}";
                        break;
                    case '5':
                        Console.Write("Enter new course's duration(in years): ");
                        dblResponse = Convert.ToDouble(Console.ReadLine());
                        sql = $"UPDATE courses SET duration = @value WHERE id = {id}";
                        break;
                    case 'x':
                    case 'X':
                        run = false;
                        break;
                }

                MySqlCommand update = new MySqlCommand(sql, myConnection);

                if (dblResponse != 0)
                {
                    update.Parameters.AddWithValue("@value", dblResponse);
                }
                else
                {
                    update.Parameters.AddWithValue("@value", response);
                }

                int rowsAffected = update.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Success");
                }
                else
                {
                    Console.WriteLine("Something went wrong!");
                }

                Console.WriteLine("Press any key to continue: ");
                wait = Console.ReadLine();
                Console.Clear();
            }
        }
        public static void Delete(int id)
        {
            string sql = $"DELETE FROM courses WHERE id = {id}";

            MySqlCommand delete = new MySqlCommand(sql, myConnection);

            delete.ExecuteNonQuery();
        }

        static void Main(string[] args)
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
                        Console.Write("Enter the id of the course you want to modify: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Update(id);
                        break;
                    case '3':
                        // Read
                        Read("SELECT * FROM courses");
                        break;
                    case '4':
                        // Delete
                        Console.WriteLine();
                        Console.Write("Enter the id of the course you want to delete: ");
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