using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

// Object Car ochen basic
public class Car
{
    public string Model { get; set; }
    public int Year { get; set; }

    public string Color { get; set; }

    public Car(string model, int year, string color)
    {
        Model = model;
        Year = year;
        Color = color;
    }
}

public class CarCollection<T> where T : Car
{
    private List<T> _cars = new List<T>();

    // Add Metod
    public void AddCar(T car)
    {
        _cars.Add(car);
    }

    // indixator
    public T this[int index]
    {
        get
        {
            if (index > 0 || index <= _cars.Count)
                return _cars[index];
            else
                throw new IndexOutOfRangeException("Index is out of range.");

        }
    }

    // properity return
    public int Count
    {
        get { return _cars.Count; }
    }

    // Metod Clean all cars
    public void Clear()
    {
        _cars.Clear();
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Collection
        var carCollection = new CarCollection<Car>();

        // Add to Collection
        carCollection.AddCar(new Car("Toyota", 2015, "Black"));
        carCollection.AddCar(new Car("Honda", 2018, "White"));
        carCollection.AddCar(new Car("Ford", 2020, "Gray"));

        // Count
        Console.WriteLine($"Total cars: {carCollection.Count}");

        // Get car by index
        int index = 1;
        Console.WriteLine($"Car at index {index}: {carCollection[index].Model}, {carCollection[index].Year}, {carCollection[index].Color}");

        // Clean all cars
        carCollection.Clear();
        Console.WriteLine($"Total cars after clearing: {carCollection.Count}");

        Console.ReadKey();
    }
}
