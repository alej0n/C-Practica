using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoStation
{
    class Program
    {
        static void Main(string[] args)
        {
            // collection
            var cars = new List<Car>
            {
                new Car { Brand = "Toyota", Model = "Camry", Year = 2020, Color = "White" },
                new Car { Brand = "Honda", Model = "Civic", Year = 2021, Color = "Black" },
                new Car { Brand = "Ford", Model = "Focus", Year = 2019, Color = "Blue" }
            };

            // Buyers collection (anonymous types)
            var buyers = new[]
            {
                new { Model = "Camry", Name = "Ivan Petrov", Phone = "123-456" },
                new { Model = "Focus", Name = "Anna Smirnova", Phone = "789-101" }
            };

            // LINQ query to join data
            var query = from car in cars
                        join buyer in buyers on car.Model equals buyer.Model
                        select new
                        {
                            buyer.Name,
                            buyer.Phone,
                            car.Brand,
                            car.Model,
                            car.Year,
                            car.Color
                        };

            foreach (var item in query)
            {
                Console.WriteLine($"Buyer: {item.Name}, Phone: {item.Phone}");
                Console.WriteLine($"Car: {item.Brand} {item.Model}, {item.Year} year, Color: {item.Color}");
                Console.WriteLine(new string('-', 40));
            }

            // Using dynamic type
            dynamic dynamicCar = new { Brand = "Mazda", Model = "CX-5", Year = 2022 };
            Console.WriteLine($"Dynamic example: {dynamicCar.Brand} {dynamicCar.Model}, {dynamicCar.Year} year");
        }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
}
