using System;
using System.Globalization;

namespace Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CultureInfo.CurrentCulture);
            // Current culture is en-GB
            var descDate = "February 26, 2009";
            var seDate = "2000-02-02";
            // 02/02/2000 00:00:00
            var d1 = DateTime.Parse(seDate);
            // 26/02/2009 00:00:00
            var d2 = DateTime.Parse(descDate);
            // 02/02/2000 00:00:00
            var d3 = DateTime.ParseExact(seDate, "yyyy-MM-dd",
                CultureInfo.CreateSpecificCulture("sv-SE"));


            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
        }
    }
}
