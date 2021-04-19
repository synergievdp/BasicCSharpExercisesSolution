using System;

namespace Shapes {
    class Program {
        static void Main(string[] args) {
            Coord X = new(0, 0);
            Coord Y = new(5, 10);

            string format = "{0:0.##}";

            Square square = new(X, Y);
            Console.WriteLine($"Total area of Square ({String.Format(format, square.Length)}²) is {String.Format(format, square.TotalArea())}");
            Rectangle rectangle = new(X, Y);
            Console.WriteLine($"Total area of Rectangle ({String.Format(format, rectangle.Height)} * {String.Format(format, rectangle.Width)}) is {String.Format(format, rectangle.TotalArea())}");
            Circle circle = new(X, Y);
            Console.WriteLine($"Total area of Circle (π{String.Format(format, circle.Radius)}²) is {String.Format(format, circle.TotalArea())}");
            

            Console.WriteLine("Press <ENTER> to exit...");
            Console.ReadLine();
        }
    }

    class Coord {
        public Coord(int x, int y) {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }

    abstract class Shape {
        public Coord X { get; set; }
        public Coord Y { get; set; }

        public Shape(Coord x, Coord y) {
            X = x;
            Y = y;
        }

        public abstract double TotalArea();
    }

    class Square : Shape {
        public double Length { get; set; }
        public Square(Coord x, Coord y) : base(x, y) {
            Length = Math.Min(Math.Abs(X.X - (X.X - Y.X)), Math.Abs(X.Y - (X.Y - Y.Y)));
        }

        public override double TotalArea() {
            return Math.Pow(Length, 2); 
        }
    }

    class Rectangle : Shape {
        public int Height { get; set; }
        public int Width { get; set; }

        public Rectangle(Coord x, Coord y) : base(x, y) {
            Height = Math.Abs(X.Y - (X.Y - Y.Y));
            Width = Math.Abs(X.X - (X.X - Y.X));
        }

        public override double TotalArea() {
            return Height * Width;
        }
    }

    class Circle : Shape {
        public double Radius { get; set; }
        public Circle(Coord x, Coord y) : base(x, y) {
            double diameter = Math.Min(Math.Abs(X.X - (X.X - Y.X)), Math.Abs(X.Y - (X.Y - Y.Y)));
            Radius = diameter/2;
        }

        public override double TotalArea() {
            
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
