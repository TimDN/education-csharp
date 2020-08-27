using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            switch (i)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Two or Three");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
        }
    }
}
