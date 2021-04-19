using System;

namespace Shapes {
    class Program {
        static void Main(string[] args) {
            string format = "{0:0.##}";

            Square square = new(10);
            Console.WriteLine($"Total area of Square ({String.Format(format, square.Length)}²) is {String.Format(format, square.TotalArea())}");
            Rectangle rectangle = new(10, 5);
            Console.WriteLine($"Total area of Rectangle ({String.Format(format, rectangle.Height)} * {String.Format(format, rectangle.Width)}) is {String.Format(format, rectangle.TotalArea())}");
            Circle circle = new(10);
            Console.WriteLine($"Total area of Circle (π{String.Format(format, circle.Radius)}²) is {String.Format(format, circle.TotalArea())}");

            Console.WriteLine("Press <ENTER> to exit...");
            Console.ReadLine();
        }
    }

    class Location {
        public Location(int x, int y) {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }

    abstract class Shape {
        public Location Location { get; set; }

        public Shape() {
            Location = new(0, 0);
        }

        public abstract double TotalArea();
    }

    class Square : Shape {
        public double Length { get; set; }
        public Square(int length) : base() {
            Length = length;
        }

        public override double TotalArea() {
            return Math.Pow(Length, 2); 
        }
    }

    class Rectangle : Shape {
        public int Height { get; set; }
        public int Width { get; set; }

        public Rectangle(int height, int width) : base() {
            Height = height;
            Width = width;
        }

        public override double TotalArea() {
            return Height * Width;
        }
    }

    class Circle : Shape {
        public double Radius { get; set; }
        public Circle(int radius) : base() {
            Radius = radius;
        }

        public override double TotalArea() {
            
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
