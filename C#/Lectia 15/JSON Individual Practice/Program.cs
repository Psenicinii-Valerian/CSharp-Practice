using System;
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JSON_Individual_Practice
{
    class Data
    {
        public List<Car> Cars;
    }

    class Car
    {
        public string Make { get; set; }    
        public string Model { get; set; }
        public int Year { get; set; }   
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
        public List<string> Features { get; set; }
        public Engine Engine { get; set; }
        public Countries Countries;
        public Rating Rating { get; set; }
        public List<string> Colors { get; set; }
    }

    //class Feature
    //{
    //    public string Name { get; set; }
    //}

    class Engine
    {
        public string Type { get; set; }
        public double Displacement { get; set; }
        public int Horsepower { get; set; }
    }

    class Countries
    {
        public List<Available> Available { get; set; }
    }

    class Available
    {
        public string Name { get; set; }
        public string President { get; set; }
        public string Capital { get; set; }
        public string Continent { get; set; }
    }

    class Rating
    {
        public double Overall { get; set; }
        public double Comfort { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 15\\JSON Individual Practice\\Data.json";
            var content = File.ReadAllText(path);
            var data = JsonConvert.DeserializeObject<Data>(content);
            int carNumber = 1;
            foreach (var car in data.Cars)
            {
                Console.WriteLine($"-----------------Presenting car number: {carNumber}-----------------");
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"Price: {car.Price}");
                Console.WriteLine($"Is available status: {(car.IsAvailable ? "yes" : "no")}");

                foreach (var feature in car.Features)
                {
                    Console.WriteLine($"Features: {feature}");
                }
                Console.WriteLine($"Engine type: {car.Engine.Type}");
                Console.WriteLine($"Engine displacement: {car.Engine.Displacement}");
                Console.WriteLine($"Engine horsepower amount: {car.Engine.Horsepower}");

                foreach (var availableCountry in car.Countries.Available)
                {
                    Console.WriteLine($"Country name: {availableCountry.Name}");
                    Console.WriteLine($"President: {availableCountry.President}");
                    Console.WriteLine($"Capital: {availableCountry.Capital}");
                    Console.WriteLine($"Continent: {availableCountry.Continent}");
                }

                Console.WriteLine($"Rating overall: {car.Rating.Overall}");
                Console.WriteLine($"Rating comfort: {car.Rating.Comfort}");

                Console.WriteLine("Available colors:");
                int i = 1;
                foreach (var color in car.Colors)
                {
                    Console.WriteLine($"{i}) {color}");
                    i++;
                }
                carNumber++;
                Console.WriteLine();
            }
        }
    }
}