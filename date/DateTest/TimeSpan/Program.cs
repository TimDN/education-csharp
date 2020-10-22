using System;

namespace TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            var endOfCourse = new DateTime(2020, 10, 30);
            var now = DateTime.Now;
            var timeRemainig = endOfCourse - now;
            // 07 08:07:57
            Console.WriteLine(string.Format(
                $"{timeRemainig:dd\\ hh\\:mm\\:ss}"));
        }
    }
}
