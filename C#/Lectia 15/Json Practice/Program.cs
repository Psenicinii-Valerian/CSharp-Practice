using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Json_Practice
{
    class Data
    {
        public List<Car> Cars;
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Owner Owner { get; set; }
    }
    class Owner
    {
        public string Name { get; set; }
        public string Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\Valerian\\OneDrive\\Desktop\\STEP IT\\C#\\Lectia 15\\Json Practice\\Data.json";
            string content = File.ReadAllText(filePath);
            var data = JsonConvert.DeserializeObject<Data>(content);

            foreach (var car in data.Cars)
            {
                Console.WriteLine($"Brand: {car.Brand}\nModel: {car.Model}\nYear: {car.Year}\nColor: {car.Color}");
                Console.WriteLine($"Car owner name: {car.Owner.Name}\nCar owner age: {car.Owner.Age}\n");
            }
        }
    }
}