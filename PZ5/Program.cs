using System;

namespace articleApp
{
    class Article
    {
        private string productName;
        private string storeName;
        private double price;

        public Article(string productName, string storeName, double price)
        {
            this.productName = productName;
            this.storeName = storeName;
            this.price = price;
        }

        public string ProductName => productName;

        public void DisplayInfo()
        {
            Console.WriteLine($"Product: {productName}, Store: {storeName}, Price: {price} UAH");
        }
    }

    class Store
    {
        private Article[] articles;

        public Store(Article[] articles)
        {
            this.articles = articles;
        }

        /*public void DisplayArticle(int index)
        //{
        //    if (index >= 0 && index < articles.Length)
        //    {
        //        articles[index].DisplayInfo();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid article index.");
        //    }
        //}

        //public void DisplayArticle(string productName)
        //{
        //    foreach (var article in articles)
        //    {
        //        if (article.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase))
        //        {
        //            article.DisplayInfo();
        //            return;
        //        }
        //    }
        //    Console.WriteLine("Product not found.");
        }*/

        // Indexator productName
        public Article this[int index]
        {
            get {return articles[index];}
        }

        // Indexador productName
        public Article this[string productName]
        {
            get
            {
                foreach (var article in articles)
                {
                    if (article.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase))
                    {
                        return article;
                    }
                }
                throw new ArgumentException("Product not found.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Article[] articles =
            {
            new Article("Laptop", "TechStore", 25000),
            new Article("Smartphone", "MobileShop", 15000),
            new Article("Headphones", "AudioWorld", 3000)
        };

            Store store = new Store(articles);

            Console.Write("Enter product index: ");
            int index = int.Parse(Console.ReadLine());
            store[index -1].DisplayInfo();


            Console.Write("Enter product name: ");
            string productName = Console.ReadLine();
            store[productName].DisplayInfo();
        }
    }
}
