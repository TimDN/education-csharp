using System;

namespace TemperatureConverter
{
    class CelsiusConverter : ITemperatureConverter
    {
        public TemperatureUnit TargetUnit => TemperatureUnit.Celsius;

        public double ConvertTo(double degree, TemperatureUnit givenUnit)
        {
            if(givenUnit == TemperatureUnit.Fahrenheit)
            {
                return (degree - 32) / 1.8;
            }
            else if(givenUnit == TemperatureUnit.Kelvin)
            {
                return degree - 273.15;
            }
            else
            {
                throw new NotSupportedException($"The temperature unit {givenUnit}");
            }
        }
    }
}
