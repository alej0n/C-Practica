using System;

namespace RectangleApp
{
    class Rectangle
    {
        private double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            return side1 * side2;
        }

        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }

        public double Area
        {
            get { return AreaCalculator(); }
        }

        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }

    }

    class Program
    {
        static void Main()
        {
            Console.Write("Write 1st slide: ");
            double slide1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write 2nd slide: ");
            double slide2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(slide1, slide2);

            Console.WriteLine($"Area = {rectangle.Area}");
            Console.WriteLine($"Perimeter = {rectangle.Perimeter}");

            Console.ReadKey();
        }
    }
}