using System;
using System.Collections.Generic;

namespace input_validation_demo
{
    class Program
    {
        static void ValidateString()
        {
            List<string> validInput =
                new List<string> { "Q", "T" };
            bool inputIsValid = false;
            do
            {
                var input = Console.ReadLine();
                if (validInput.Contains(input))
                {
                    inputIsValid = true;
                }
            } while (!inputIsValid);
        }

        static void Main(string[] args)
        {
            ValidateString();
        }
    }
}
