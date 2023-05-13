using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace RickNMorty_API
{
    class API
    {
        public List<Character> Results { get; set; }
    }

    class Character
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Status { get; set; }
        public Origin Origin { get; set; }
        public Location Location { get; set; }
    }
    class Origin
    {
        public string Name { get; set; }
    }
    class Location
    {
        public string Name { get; set; }
    }

    internal class Program
    {
        static async Task GetAPI()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage res = await client.GetAsync("https://rickandmortyapi.com/api/character");
                    if (res.IsSuccessStatusCode) 
                    { 
                        string content = await res.Content.ReadAsStringAsync();

                        var data = JsonConvert.DeserializeObject<API>(content);
                        
                        foreach(var ch in data.Results)
                        {
                            Console.WriteLine($"Name: {ch.Name}");
                            Console.WriteLine($"Species: {ch.Species}");
                            if (ch.Status != "unknown")
                                Console.WriteLine($"Status: {ch.Status}");
                            if (ch.Origin.Name != "unknown")
                                Console.WriteLine(ch.Origin.Name);
                            if (ch.Origin.Name != "unknown")
                                Console.WriteLine($"Origin: {ch.Origin.Name}");
                            if (ch.Location.Name != "unknown")
                                Console.WriteLine($"Location: {ch.Location.Name}");
                            Console.WriteLine();
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Something went wrong");
                }
            }
        }

        static async Task Main(string[] args)
        {
            await GetAPI();
        }
    }
}