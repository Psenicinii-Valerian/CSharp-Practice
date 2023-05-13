using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Weather_API_Application
{
    public class Data
    {
        public WeatherValue[] Weather { get; set; } 
        public MainValue Main { get; set; }
        public WindValue Wind { get; set; }
        public SysValue Sys { get; set; }
        public string Name { get; set; }
    }

    public class WeatherValue
    {
        public string Main { get; set; }
    }

    public class MainValue
    {
        public double Temp { get; set; }
        public double Pressure { get; set; }
        public double Humidity { get; set; }
    }

    public class WindValue
    {
        public double Speed { get; set; }   
    }

    public class SysValue
    {
        public string Country { get; set; }
    }

    internal class Program
    {
        private static string apiKey = "&appid=fa9004bb33573ddc82e6f9908c28a1f8";
        public static Data data = new Data();

        public static async Task getAPI(string city)
        {
            while (true)
            {
                try
                {
                    HttpClient client = new HttpClient();
                    var url = "https://api.openweathermap.org/data/2.5/weather?q=" + city + "&appid" + apiKey;
                    var httpResponse = await client.GetAsync(url);
                    httpResponse.EnsureSuccessStatusCode();
                    var responseContent = await httpResponse.Content.ReadAsStringAsync();
                    // Console.WriteLine(responseContent);
                    data = JsonConvert.DeserializeObject<Data>(responseContent);
                    Console.WriteLine("---------------------------Weather---------------------------");
                    Console.WriteLine(data.Name + ", " + data.Sys.Country);
                    Console.Write(Math.Round(data.Main.Temp - 273.15) + "°C/");
                    Console.Write(Math.Round((data.Main.Temp - 273.15) * 9 / 5 + 32) + "°F - ");
                    Console.WriteLine(data.Weather[0].Main);
                    Console.WriteLine("Wind: " + data.Wind.Speed + "m/s");
                    Console.WriteLine("Pressure: " + data.Main.Pressure + "hPa");
                    Console.WriteLine("Humidity: " + data.Main.Humidity + "%");
                    break;
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine("\nCity not found or API server is down!");
                    Console.Write("Enter another city: ");
                    city = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong, try again!");
                }
            }
        }

        static async Task Main(string[] args)
        {
            char continueKey;
            Console.WriteLine("Welcome to C# Weather App!");

            do
            {
                Console.Write("Enter the desired city to see its temperature: ");
                string city = Console.ReadLine();
                await getAPI(city);
                while (true) { 
                    try
                    {
                        Console.Write("\nEnter any key to continue (or X to leave): ");
                        continueKey = Console.ReadLine()[0];
                        Console.Clear();
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Something went wrong, try again!");
                    }
                }
            } while (continueKey != 'X' && continueKey != 'x');
        }
    }
}