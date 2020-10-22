using System;

namespace TimeCreated
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = new LogFile();
            // 22/10/2020 16:36:49 +02:00
            Console.WriteLine(log.CreationDate);
        }
    }
}
