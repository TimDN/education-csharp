using System;
using System.Drawing;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelTExample();
            TemperatureExample();
        }

        static void ModelTExample()
        {
            ModelTFord FooFord = new ModelTFord();
            //Call static variable using class
            Console.WriteLine(ModelTFord.color); // prints Black
            Console.WriteLine(FooFord.Color); // prints Black

            ModelTFord.ChangeColor("Red"); //Call static method using class
            Console.WriteLine(ModelTFord.color); // prints Red
            Console.WriteLine(FooFord.Color); // prints Red

            ModelTFord BarFord = new ModelTFord();
            Console.WriteLine(BarFord.Color); // prints Red

            BarFord.ChangeFromInstance("White");
            Console.WriteLine(ModelTFord.color); // prints White
            Console.WriteLine(FooFord.Color); // prints White
            Console.WriteLine(BarFord.Color); // prints White
        }

        static void TemperatureExample()
        {
            double startCelsius = 20;
            double fahrenheit = TemperatureConverter.CelsiusToFahrenheit(startCelsius);
            double celsius = TemperatureConverter.FahrenheitToCelsius(fahrenheit);
            Console.WriteLine(startCelsius == celsius); // prints True
        }
    }

    class ModelTFord
    {
        //Shared for all instances of a Model T Ford
        public static string color = "Black";

        // Can be modified from an instance
        public void ChangeFromInstance(string newColor)
        {
            // Don't tell Henry
            color = newColor;
        }

        public string Color { get { return color; } }

        // Can be modifed from a static method
        public static void ChangeColor(string newColor)
        {
            // Don't tell Henry
            color = newColor;
        }
    }

    class ModelT
    {
        public const string color = "Black";
        private readonly string _instanceColor;

        public ModelT(string instanceColor)
        {
            _instanceColor = instanceColor;
            PropColor = instanceColor;
        }
       
        public string PropColor { get; }

        public void ChangeFromInstance(string newColor)
        {
            //color = newColor; gives error
            //_instanceColor = newColor; gives error
            //PropColor = newColor; gives error
        }
    }

    static class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}
