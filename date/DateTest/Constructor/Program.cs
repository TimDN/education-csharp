using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //01/01/0001 00:00:00
            DateTime dt1 = new DateTime();

            //year, month, day
            DateTime dt2 = new DateTime(2015, 12, 31);

            //year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);

            //year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20,
                DateTimeKind.Utc);
        }
    }
}
