using System;

namespace TemperatureConverter
{
    class KelvinConverter : ITemperatureConverter
    {
        public TemperatureUnit TargetUnit => TemperatureUnit.Kelvin;

        public double ConvertTo(double degree, TemperatureUnit givenUnit)
        {
            if(givenUnit == TemperatureUnit.Celsius)
            {
                return degree + 273.15;
            }
            else if(givenUnit == TemperatureUnit.Fahrenheit)
            {
                return (degree + 459.67) * 5 / 9;
            }
            else
            {
                throw new NotSupportedException($"The temperature unit {givenUnit}");
            }
        }
    }
}
