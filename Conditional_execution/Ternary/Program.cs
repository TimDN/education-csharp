using System;

namespace Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            Ternary();
            IfElse();
        }

        private static void IfElse()
        {
            int x = 10, y = 100;

            if (x > y)
                Console.WriteLine("x is greater than y");
            else
                // will be printed
                Console.WriteLine("x is less than y");
        }

        private static void Ternary()
        {
            int x = 10, y = 100;

            var result = x > y ? "x is greater than y" : "x is less than y";

            // x is less than y
            Console.WriteLine(result);
        }
    }
}
