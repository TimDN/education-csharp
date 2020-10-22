using System;

namespace Manipulating
{
    class Program
    {
        static void Main(string[] args)
        {
            // 22/10/2020 15:30:03
            var dt = DateTime.Now;
            // 27/10/2020 15:30:03
            var dt1 = dt.AddDays(5);
            // 17/10/2020 15:30:03
            var dt2 = dt.AddDays(-5);
            // 24/10/2020 17:30:03
            var dt3 = dt.AddHours(50);
            // 20/10/2020 13:30:03
            var dt4 = dt.AddHours(-50);


            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            Console.WriteLine(dt4);
        }
    }
}
