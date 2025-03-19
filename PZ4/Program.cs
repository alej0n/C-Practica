using System;

namespace FigureApp
{
    abstract class Figure
    {
        public abstract int GetSquare();
        public abstract int GetPerimetr();
    }

     interface IFigure
    {
        int GetSquare();
        int GetPerimetr();
    }

    class Rectangle : Figure
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public override int GetSquare()
        {
            return width * height;
        }

        public override int GetPerimetr()
        {
            return 2 * (width + height);
        }
    }
    class Circle : IFigure
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public int GetSquare()
        {
            return (int)(Math.PI * radius * radius);
        }

        public int GetPerimetr()
        {
            return (int)(2 * Math.PI * radius);
        }
    }

    class Program
    {
        static void Main()
        {
            Rectangle rect = new Rectangle(5, 10);
            Console.WriteLine($"Rectangle - Area: {rect.GetSquare()}, Perimeter: {rect.GetPerimetr()}");

            Circle circle = new Circle(7);
            Console.WriteLine($"Circle - Area: {circle.GetSquare()}, Perimeter: {circle.GetPerimetr()}");
        }
    }
}