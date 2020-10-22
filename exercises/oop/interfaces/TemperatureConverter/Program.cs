using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var temperatureConverter = GetTemperatureConverter();
            DoConversion(temperatureConverter);
        }

        static void DoConversion(ITemperatureConverter temperatureConverter)
        {
            Console.WriteLine($"Converting to {temperatureConverter.TargetUnit}");
            while (true)
            {
                var givenUnit = GetTemperatureUnit("What do you want to convert from: ");
                Console.WriteLine("Give degree number: ");
                var degree = double.Parse(Console.ReadLine());
                var result = temperatureConverter.ConvertTo(degree, givenUnit);
                Console.WriteLine($"{degree} {givenUnit} is {result} {temperatureConverter.TargetUnit}");
            }
        }

        static TemperatureUnit GetTemperatureUnit(string message)
        {
            TemperatureUnit temperatureUnit;
            string unit;
            do
            {
                Console.WriteLine(message);
                unit = Console.ReadLine();
            } while (!Enum.TryParse(unit, true, out temperatureUnit));
            return temperatureUnit;
        }

        static ITemperatureConverter GetTemperatureConverter()
        {
            var temperatureUnit = GetTemperatureUnit("What do you want to convert to: ");
            return TemperatureConverterFactory.GetTemperatureConverter(temperatureUnit);
        }
    }
}
