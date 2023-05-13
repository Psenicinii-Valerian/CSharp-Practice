using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

namespace Homework
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public string Password = "123";
        public Company Company { get; set; }

        public void ShowUser()
        {
            Console.WriteLine($"Name: {Name}\nUsername: {Username}\nEmail: {Email}\nPassword: {Password}\nCompany: ");
            Company.ShowCompany();
            Console.WriteLine();
        }
    }

    public class Company
    {
        public string Name { get; set; }
        public string CatchPhrase { get; set; }
        public string Bs { get; set; }

        public void ShowCompany()
        {
            Console.WriteLine($"Name: {Name}\nCatch Phrase: {CatchPhrase}\nBs: {Bs}");
        }
    }

    public class Todo
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
    }

    internal class Program
    {
        public static List<User> users = new List<User>();
        public static List<Todo> todos = new List<Todo>();
        // Task - tip de date utilizat pentru functiile care reprezinta o operatie asincrona
        public static async Task GetResult()
        {
            // Metoda prin care putem trimite sau primi date prin HTTP
            HttpClient client = new HttpClient();
            // url - link spre API
            var url = "https://jsonplaceholder.typicode.com/users";
            // Trimitem cerere de primire a informatiei spre link (Asincron) 
            // Await - Asteapta pana cand nu primim raspunsul
            var httpResponse = await client.GetAsync(url);
            // Verificarea raspunsului (daca cererea a luat loc cu succes)
            httpResponse.EnsureSuccessStatusCode();
            // Primirea valorilor sub forma de string
            var responseContent = await httpResponse.Content.ReadAsStringAsync();
            // Console.WriteLine(responseContent);

            // Transformarea string-ului intr-un tablou de obiecte
            users = JsonConvert.DeserializeObject<List<User>>(responseContent);
        }

        public static async Task GetTodos()
        {
            HttpClient client = new HttpClient();
            var url = "https://jsonplaceholder.typicode.com/todos";
            var httpResponse = await client.GetAsync(url);
            httpResponse.EnsureSuccessStatusCode();
            var responseContent = await httpResponse.Content.ReadAsStringAsync();
            todos = JsonConvert.DeserializeObject<List<Todo>>(responseContent);
        }

        // adugam async Task si la Main()
        static async Task Main(string[] args)
        {
            await GetResult();
            await GetTodos();

            foreach (var todo in todos)
            {
                foreach (var user in users)
                {
                    if (todo.UserId == user.Id)
                    {
                        Console.WriteLine($"Username: {user.Username}\nTodo Title: {todo.Title}\nCompleted status: {todo.Completed}\n\n");
                    }
                }
            }
        }
    }
}