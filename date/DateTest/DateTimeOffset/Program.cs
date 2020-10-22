using Microsoft.VisualBasic.CompilerServices;
using System;

namespace DateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // 22/10/2020 16:17:58
            var dt = DateTime.Now;
            // 22/10/2020 14:17:58
            var dtu = DateTime.UtcNow;
            // 22/10/2020 16:17:58 +02:00
            var dto = DateTimeOffset.Now;
            // 22/10/2020 14:17:58 +00:00
            var dtou = DateTimeOffset.UtcNow;


            Console.WriteLine(dt);
            Console.WriteLine(dtu);
            Console.WriteLine(dto);
            Console.WriteLine(dtou);
        }
    }
}
