using System;
using System.Globalization;

namespace UtcStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is stored in UTC+0
            var storedLocal = "22/10/2020 14:42:54";
            //Convert to DateTimeOffset assuming that its Utc
            var dt = DateTimeOffset.Parse(storedLocal,
                null, DateTimeStyles.AssumeUniversal);
            //Convert to local time
            var localDt = dt.ToLocalTime();
            // 22/10/2020 16:42:54 +02:00
            Console.WriteLine(localDt);
        }
    }
}
