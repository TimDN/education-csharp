using System;
using System.Globalization;

namespace Time
{
    class Program
    {

        static string Format(DateTime dateTime, CultureInfo culture)
        {
            return $"{dateTime.ToString(culture)} {culture}";
        }

        static void Main(string[] args)
        {
            var date = DateTime.Now;
            Console.WriteLine(Format(date, CultureInfo.InvariantCulture));
            Console.WriteLine(Format(date, CultureInfo.CreateSpecificCulture("sv-SE")));
            Console.WriteLine(Format(date, CultureInfo.CreateSpecificCulture("en-gb")));
            Console.WriteLine(Format(date, CultureInfo.CreateSpecificCulture("en-us")));
        }
    }
}
