using System.Collections.Generic;

namespace OOP_Car_class
{
    class Car
    {
        public string name;
        public string color;
        public int hp;
        public int engineVolume;
        public double price;

        public Car (string name, string color, int hp, int engineVolume, double price)
        {
            this.name = name;
            this.color = color;
            this.hp = hp;
            this.engineVolume = engineVolume;
            this.price = price;
        }

        public void showCar()
        {
            Console.WriteLine($"{this.name}, {this.color}, {this.hp}HP, {this.engineVolume}cm3, {this.price}$$");
        }
    }


    class Countries
    {
        string name;
        long GDP;
        int population;

        public Countries (string name, long GDP, int population)
        {
            this.name = name;
            this.GDP = GDP;
            this.population = population;
        }

        public string getName()
        {
            return this.name;
        }

        public long getGDP()
        {
            return this.GDP;
        }

        public int getPopulation()
        {
            return this.population;
        }

        public void showCountries()
        {
            Console.WriteLine($"Country name:: {this.name}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car ("Subaru", "Blue", 380, 2000, 1339.50),
                new Car ("Toyota", "Red", 180, 2500, 23500),
                new Car ("Porsche 911", "White", 780, 3000, 180000)
            };

            foreach(var car in cars)
            {
                car.showCar();
            }

            // Afisarea celei mai rapide masini din cele 3 generate
            Console.WriteLine("\n******************FASTEST CAR*****************\n");
            int fastestCarIdx = 0;
            int fastestCarHP = cars[0].hp;

            for (int i=1; i<cars.Count; i++)
            {
                if (cars[i].hp > fastestCarHP)
                {
                    fastestCarHP = cars[i].hp;
                    fastestCarIdx = i;
                }
            }

            cars[fastestCarIdx].showCar();

            double sum = 0;
            foreach(var car in cars)
            {
                sum += car.price;
            }

            Console.WriteLine("\n**************MEDIUM CARS' PRICE**************\n");
            Console.WriteLine($"Medium price of the specified cars: {Math.Round(sum / cars.Count, 2)}$$");

            // TASK
            /*
                Class Countries(name, gdp, population) x5 countries
                1) Afisati toate tarile;
                2) Aflati tara cu cel mai mare GDP;
                3) Aflati tara cu cel mai mic GDP;
                4) Aflati media GDP;
                5) Aflati tara cu cea mai mare populatie;              
                6) Aflati tara cu cea mai mica populatie;
                7) Aflati media populatiei;
            */

            Console.WriteLine("\n*********************TASK*********************\n");

            List<Countries> countries = new List<Countries>()
            {
                new Countries("India",  3469000000000,  1375586000),
                new Countries("China",  17730000000000, 1412000000),
                new Countries("Canada", 2200000000000,  38250000),
                new Countries("Norway", 504000000000,   5425270),
                new Countries("France", 2936000000000,  68042591)
            };

            // GDP 
            long minGDP = countries[0].getGDP();
            int minGDPIdx = 0;
            long maxGDP = countries[0].getGDP();
            int maxGDPIdx = 0;
            long mediumGDP = 0;

            // Population
            int minPopulation = countries[0].getPopulation();
            int minPopulationIdx = 0;
            int maxPopulation = countries[0].getPopulation();
            int maxPopulationIdx = 0;
            double mediumPopulation = 0;

            foreach (var country in countries)
            {
                // Show all countries
                country.showCountries();

                // Calculate total GDP 
                mediumGDP += country.getGDP();

                // Calculate total Population
                mediumPopulation += country.getPopulation();
            }

            for (int i=1; i < countries.Count; i++)
            {
                // get the index of country with max GDP
                if (countries[i].getGDP() > maxGDP)
                {
                    maxGDP = countries[i].getGDP();
                    maxGDPIdx = i;
                }

                // get the index of country with min GDP
                if (countries[i].getGDP() < minGDP)
                {
                    minGDP = countries[i].getGDP();
                    minGDPIdx = i;
                }

                // get the index of country with max Population
                if (countries[i].getPopulation() > maxPopulation)
                {
                    maxPopulation = countries[i].getPopulation();
                    maxPopulationIdx = i;
                }

                // get the index of country with min Population
                if (countries[i].getPopulation() < minPopulation)
                {
                    minPopulation = countries[i].getPopulation();
                    minPopulationIdx = i;
                }
            }

            Console.WriteLine();

            Console.WriteLine($"Country with the highest GDP - Name: {countries[maxGDPIdx].getName()}, " +
                              $"GDP: {countries[maxGDPIdx].getGDP()}$$");

            Console.WriteLine($"Country with the lowest GDP - Name: {countries[minGDPIdx].getName()}, " +
                              $"GDP: {countries[minGDPIdx].getGDP()}$$");

            Console.WriteLine($"Average GDP of the specified countries: {Math.Round(mediumGDP / (decimal)countries.Count, 2)}$$");

            Console.WriteLine();

            Console.WriteLine($"Country with the highest population count - Name: {countries[maxPopulationIdx].getName()}, " +
                              $"Population count: {countries[maxPopulationIdx].getPopulation()} people");

            Console.WriteLine($"Country with the lowest population count - Name: {countries[minPopulationIdx].getName()}, " +
                     $"Population count: {countries[minPopulationIdx].getPopulation()} people");

            Console.WriteLine($"Average population count of the specified countries: " +
                              $"{Math.Round(mediumPopulation / countries.Count, 2)} people");
        }

    }
}