using System;

namespace Properties
{
    class Program
    {
        static void NowProperties()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(DateTime.Today);
        }

        static void Properties()
        {
            var now = DateTime.Now;
            Console.WriteLine(now.Year); // 2020  
            Console.WriteLine(now.Month); //10  
            Console.WriteLine(now.Day); // 22  
            Console.WriteLine(now.Hour); // 16  
            Console.WriteLine(now.Minute); // 02
            Console.WriteLine(now.Second); // 45  
            Console.WriteLine(now.DayOfWeek); // Thursday  
        }

        static void Main(string[] args)
        {
            NowProperties();
            Properties();
        }
    }
}
