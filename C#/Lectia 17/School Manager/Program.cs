using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace School_Manager
{
    internal class Program
    {
        public static string connection = "server=localhost; port=4000; database=school_manager; user=root; password=";
        public static MySqlConnection myConnection = new MySqlConnection(connection);

        public static void Read(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, myConnection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader.GetInt32(0)}");
                    Console.WriteLine($"Name: {reader.GetString(1)}");
                    Console.WriteLine($"Lastname: {reader.GetString(2)}");
                    Console.WriteLine($"Email: {reader.GetString(3)}");
                    Console.WriteLine($"Age: {reader.GetInt32(4)}");
                    Console.WriteLine($"City: {reader.GetString(5)}");
                    Console.WriteLine($"Class: {reader.GetString(6)}");
                    Console.WriteLine();
                }
            }
        }

        public static void Create() 
        {
            Console.WriteLine("Enter values for your student:");

            Console.Write("Enter student's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter student's lastname: ");
            string lastname = Console.ReadLine();

            Console.Write("Enter student's email: ");
            string email = Console.ReadLine();

            Console.Write("Enter student's age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the city where student currently lives: ");
            string city = Console.ReadLine();

            Console.Write("Enter student's class: ");
            string classs = Console.ReadLine();

            string create = "INSERT INTO students(name, lastname, email, age, city, class) VALUES " +
                            "(@value1, @value2, @value3, @value4, @value5, @value6)";

            MySqlCommand insert = new MySqlCommand(create, myConnection);
            insert.Parameters.AddWithValue("@value1", name);
            insert.Parameters.AddWithValue("@value2", lastname);
            insert.Parameters.AddWithValue("@value3", email);
            insert.Parameters.AddWithValue("@value4", age);
            insert.Parameters.AddWithValue("@value5", city);
            insert.Parameters.AddWithValue("@value6", classs);

            insert.ExecuteNonQuery();
        }

        public static void Update(int id)
        {
            bool run = true;
            string response = "";
            string wait = "";
            int ageResponse = 0;
            string sql = "";
            char option;

            List<string> valuesAvailable = new List<string>() {
                "name",
                "lastname",
                "email",
                "age",
                "city",
                "class"
            };

            while (run)
            {
                Console.WriteLine("Enter what column(value) you want to modify: ");
                int i = 1;
                foreach(var value in valuesAvailable) 
                {
                    Console.WriteLine($"{i++}. {value}");
                }
                Console.WriteLine("X. Stop modifying");
                option = Console.ReadLine()[0];

                switch(option)
                {
                    case '1':
                        Console.Write("Enter new student's name: ");
                        response = Console.ReadLine();
                        sql = $"UPDATE students SET name = @value WHERE id = {id}";
                        break;
                    case '2':
                        Console.Write("Enter new student's lastname: ");
                        response = Console.ReadLine();
                        sql = $"UPDATE students SET lastname = @value WHERE id = {id}";
                        break;
                    case '3':
                        Console.Write("Enter new student's email: ");
                        response = Console.ReadLine();
                        sql = $"UPDATE students SET email = @value WHERE id = {id}";
                        break;
                    case '4':
                        Console.Write("Enter new student's age: ");
                        ageResponse = Convert.ToInt32(Console.ReadLine());
                        sql = $"UPDATE students SET age = @value WHERE id = {id}";
                        break;
                    case '5':
                        Console.Write("Enter new student's city: ");
                        response = Console.ReadLine();
                        sql = $"UPDATE students SET city = @value WHERE id = {id}";
                        break;
                    case '6':
                        Console.Write("Enter new student's class: ");
                        response = Console.ReadLine();
                        sql = $"UPDATE students SET class = @value WHERE id = {id}";
                        break;
                    case 'x':
                    case 'X':
                        run = false;
                        break;
                }

                MySqlCommand update = new MySqlCommand(sql, myConnection);

                if (ageResponse != 0)
                {
                    update.Parameters.AddWithValue("@value", ageResponse);
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
            string sql = $"DELETE FROM students WHERE id = {id}";

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
                        Console.Write("Enter the id of the student you want to modify: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Update(id);
                        break;
                    case '3':
                        // Read
                        Read("SELECT * FROM students");
                        break;
                    case '4':
                        // Delete
                        Console.WriteLine();
                        Console.Write("Enter the id of the student you want to delete: ");
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