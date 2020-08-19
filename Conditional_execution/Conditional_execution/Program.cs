using System;

namespace Conditional_execution
{
    class Program
    {
        static void Main(string[] args)
        {
#pragma warning disable CS0162 // Unreachable code detected
#pragma warning disable IDE0035 // Unreachable code detected

            if (1 != 2)
                Console.WriteLine("Not equal");
            //Will be printed

            if (1 < 2)
                Console.WriteLine("Less than");
            //Will be printed

            if (1 <= 1)
                Console.WriteLine("Less than or equal");
            //Will be printed

            if (2 > 1)
                Console.WriteLine("More than");
            //Will be printed

            if (2 >= 2)
                Console.WriteLine("More than or equal");
            //Will be printed

            if (!false)
                Console.WriteLine("Not false");
            //Will be printed

            if (true && true)
                Console.WriteLine("True AND True == True");
            //Will be printed

            if (true || false)
                Console.WriteLine("True OR False == True");
            //Will be printed

            if (false || true)
                Console.WriteLine("False OR True == True");
            //Will be printed

            if (false)
                Console.WriteLine("If statement");
            else if (false)
                Console.WriteLine("First Else if statement");
            else if (true)
                Console.WriteLine("Second Else if statement");
                //Will be printed
            else
                Console.WriteLine("Else statements");

            if (true)
            {
                Console.WriteLine("Condition is true");
                //Will be printed as the condition is true
            }
            else
            {
                Console.WriteLine("Condition is false");
                //Will not be printed
            }
        }
    }
}
