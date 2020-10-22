using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureConverter
{
    interface ITemperatureConverter
    {
        public TemperatureUnit TargetUnit { get; }
        double ConvertTo(double degree, TemperatureUnit givenUnit);
    }
}
