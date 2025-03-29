using System;
interface IProduct
{
    void Display();
}

// Структура реализует интерфейс IProduct
struct Product : IProduct
{
    public string Name;
    public string Country;
    public int Id;
    public decimal Price;

    // Конструктор с параметрами
    public Product(string name, string country, int id, decimal price)
    {
        Name = name;
        Country = country;
        Id = id;
        Price = price;
    }

    public void Display()
    {
        Console.WriteLine($"Product: {Name}, Country: {Country}, Id: {Id}, Price: {Price} ");
    }
}

class Program
{
    static void Main()
    {
        // Создание структуры без оператора new
        Product product1;
        product1.Name = "Notebook";
        product1.Country = "USA";
        product1.Id = 101;
        product1.Price = 1500.99m;

        Product product2 = new Product("Smartphone", "China", 202, 999.49m);
        Product product3 = new Product("TV", "Germany", 303, 1200.75m);
        Product product4 = new Product("Tablet", "Korea", 404, 799.99m);

        Product[] products = { product1, product2, product3, product4 };

        // Сортировка по убыванию цены
        var sortedProducts = products.OrderByDescending(p => p.Price);

        Console.WriteLine("List products ordered by descending:");
        foreach (var product in sortedProducts)
        {
            product.Display();
        }
    }
}
