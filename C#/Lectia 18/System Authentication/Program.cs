using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace System_Authentication
{
    internal class Program
    {
        static MySqlConnection connection = new MySqlConnection("server=localhost; port=4000; database=authsys; uid=root; pwd=;");

        public static void login()
        {
            string login, password;

            Console.WriteLine("Login");
            Console.Write("Enter login: ");
            login = Console.ReadLine();
            Console.Write("Enter password: ");
            password = Console.ReadLine();

            string searchUser = "SELECT * FROM users WHERE login = @value1";
            MySqlCommand searchUserCommand = new MySqlCommand(searchUser, connection);
            searchUserCommand.Parameters.AddWithValue("@value1", login);

            try
            {
                MySqlDataReader userData = searchUserCommand.ExecuteReader();
                if (userData.Read())
                {
                    if (password == userData["password"].ToString())
                    {
                        userData.Close();
                        Console.Clear();
                        Console.WriteLine("User menu");
                        Console.WriteLine("1. My Account\n2. Other Accounts\n3. Change email\n4. Logout");
                        int userOption;
                        Console.Write("Enter your option: ");
                        userOption = Convert.ToInt32(Console.ReadLine());
                        while (true)
                        {
                            Console.Clear();

                            switch (userOption)
                            {
                                case 1:
                                    myAccount(login);
                                    break;
                                case 2:
                                    otherAccounts(login);
                                    break;
                                case 3:
                                    update(login);
                                    break;
                                case 4:
                                    return;
                                default:
                                    Console.WriteLine("Option does not exist");
                                    break;
                            }

                            Console.Clear();
                            Console.WriteLine("User menu");
                            Console.WriteLine("1. My Account\n2. Other Accounts\n3. Change email\n4. Logout");
                            Console.Write("Enter your option: ");
                            userOption = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    else
                    {
                        Console.WriteLine("Unfortunately we coudn't log you in!");
                    }
                }
                else
                {
                    Console.WriteLine("Something went wrong");
                }

                userData.Close();
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Wrong credentials!");
            }
        }

        public static void myAccount(string login)
        {
            string accountSelect = "SELECT * FROM users WHERE login = @value1";
            MySqlCommand accountSelectCommand = new MySqlCommand(accountSelect, connection);
            accountSelectCommand.Parameters.AddWithValue("@value1", login);
            MySqlDataReader accountReader = accountSelectCommand.ExecuteReader();

            while (accountReader.Read())
            {
                Console.WriteLine("Account:");
                Console.WriteLine($"Login: {accountReader["login"].ToString()}");
                Console.WriteLine($"Email: {accountReader["email"].ToString()}");
                Console.WriteLine();
            }

            accountReader.Close();

            try
            {
                Console.Write("Enter any character to exit: ");
                char x = Console.ReadLine()[0];
            }
            catch(Exception ex) 
            { 
                Console.WriteLine("Something went wrong! Insert a valid character!"); 
            }
        }

        public static void otherAccounts(string login)
        {
            string accountSelect = "SELECT * FROM users WHERE login != @value1";
            MySqlCommand accountSelectCommand = new MySqlCommand(accountSelect, connection);
            accountSelectCommand.Parameters.AddWithValue("@value1", login);
            MySqlDataReader accountReader = accountSelectCommand.ExecuteReader();

            Console.WriteLine("Other accounts:");
            while (accountReader.Read())
            {
                Console.WriteLine($"Login: {accountReader["login"].ToString()}");
                Console.WriteLine($"Email: {accountReader["email"].ToString()}");
                Console.WriteLine();
            }

            accountReader.Close();

            try
            {
                Console.Write("Enter any character to exit: ");
                char x = Console.ReadLine()[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong! Insert a valid character!");
            }
        }

        public static void update(string login)
        {
            Console.Write("Enter email: ");
            string newEmail = Console.ReadLine();
            while (!Regex.IsMatch(newEmail, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                Console.WriteLine("Email does not correspond to the rules!");
                Console.Write("Enter new email: ");
                newEmail = Console.ReadLine();
            }

            string updateEmail = "UPDATE users SET email = @value1 where login = @value2";
            MySqlCommand updateEmailCommand = new MySqlCommand(updateEmail, connection);
            updateEmailCommand.Parameters.AddWithValue("@value1", newEmail);
            updateEmailCommand.Parameters.AddWithValue("@value2", login);

            int rowsAffected = updateEmailCommand.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Console.WriteLine("Email updated successfully!");
            }
            else
            {
                Console.WriteLine("We couldn't update your email!");
            }
        }

        public static void register()
        {
            string login, password, email;
            Console.WriteLine("Register");
            // login
            Console.Write("Enter login: ");
            login = Console.ReadLine();
            while(!Regex.IsMatch(login, @"^[a-z0-9_]{5,50}$"))
            {
                Console.WriteLine("Login does not correspond to the rules!");
                Console.Write("Enter new login: ");
                login = Console.ReadLine();
            }
            // password
            Console.Write("Enter password: ");
            password = Console.ReadLine();
            while(!Regex.IsMatch(password, @"^[A-Za-z0-9!#$.]{8,200}$"))
            {
                Console.WriteLine("Password does not correspond to the rules!");
                Console.Write("Enter new password: ");
                password = Console.ReadLine();
            }

            // email
            Console.Write("Enter email: ");
            email = Console.ReadLine();
            while (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                Console.WriteLine("Email does not correspond to the rules!");
                Console.Write("Enter new email: ");
                email = Console.ReadLine();
            }

            string createUser = "INSERT INTO users(login, password, email) VALUES (@value1, @value2, @value3)";
            MySqlCommand createUserCommand = new MySqlCommand(createUser, connection);
            createUserCommand.Parameters.AddWithValue("@value1", login);
            createUserCommand.Parameters.AddWithValue("@value2", password);
            createUserCommand.Parameters.AddWithValue("@value3", email);

            int rowsAffected = createUserCommand.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Console.WriteLine("User successfully created!");
            }
            else
            {
                Console.WriteLine("Something went wrong");  
            }
        }

        static void Main(string[] args)
        {
            connection.Open();

            int optionMain;

            Console.WriteLine("Welcome to Social Club");
            Console.WriteLine("1. Login\n2. Register\n3. Exit App\n");
            Console.Write("Enter your choice: ");
            optionMain = Convert.ToInt32(Console.ReadLine());

            while (true) 
            {
                Console.Clear();

                switch(optionMain) {
                    case 1:
                        login();
                        break;
                    case 2:
                        register();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;  
                    default:
                        Console.WriteLine("Option does not exist!");
                        break;
                }

                Console.WriteLine("1. Login\n2. Register\n3. Exit App\n");
                Console.Write("Enter your choice: ");
                optionMain = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}