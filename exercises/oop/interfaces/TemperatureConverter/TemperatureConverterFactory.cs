using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureConverter
{
    static class TemperatureConverterFactory
    {
        public static ITemperatureConverter GetTemperatureConverter(TemperatureUnit temperatureUnit)
        {
            switch (temperatureUnit)
            {
                case TemperatureUnit.Celsius:
                    return new CelsiusConverter();
                case TemperatureUnit.Kelvin:
                    return new KelvinConverter();
                default:
                    throw new NotSupportedException($"The temperature unit {temperatureUnit}");
            }
        }
    }
}
