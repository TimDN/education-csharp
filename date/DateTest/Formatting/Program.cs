using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            var dt = DateTime.Now;
            // 10/22/2020
            Console.WriteLine(dt.ToString("MM/dd/yyyy"));
            // 10/22/2020 3:08 PM
            Console.WriteLine(dt.ToString("MM/dd/yyyy h:mm tt"));
            // 22/10/2020
            Console.WriteLine(dt.ToShortDateString());
            // 22 October 2020
            Console.WriteLine(dt.ToLongDateString());
            // 15:08
            Console.WriteLine(dt.ToShortTimeString());
            // 15:08:36
            Console.WriteLine(dt.ToLongTimeString());
        }
    }
}
