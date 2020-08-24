using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Notice that tri is declared as type IShape
            IShape tri = new Triangle(3, 4, "Red");
            //tri.UniqueTri not accessible since tri is of type IShape
            Triangle nextTri = new Triangle(4, 5, "Green");
            Rectangle rect = new Rectangle(3, 2, "Blue");

            ShowArea(tri);
            ShowArea(nextTri); //works because Triangle implement IShape
            ShowArea(rect); //works because Rectangle implement IShape
        }

        static void ShowArea(IShape shape)
        {
            Console.WriteLine(shape.GetArea());
        }
    }

    interface IShape
    {
        //Color prop must have a public get
        string Color { get;}
        //Method GetArea that returns a double
        double GetArea();
    }

    class Triangle : IShape
    {
        private double _baseLength;
        private double _height;

        public Triangle(double baseLength, double height, string color)
        {
            _baseLength = baseLength;
            _height = height;
            Color = color;
        }
        public string Color { get; }

        public string UniqueTri { get; set; }

        public double GetArea()
        {
            return (_baseLength / 2) * _height;
        }
    }

    class Rectangle : IShape
    {
        private double _length;
        private double _width;

        public Rectangle(double length, double width, string color)
        {
            _length = length;
            _width = width;
            Color = color;
        }
        public string Color { get; }

        public double GetArea()
        {
            return _length * _width;
        }
    }
}
