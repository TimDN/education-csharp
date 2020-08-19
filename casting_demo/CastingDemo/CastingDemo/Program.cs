using System;
using System.Globalization;

#pragma warning disable CS0162 // Unreachable code detected
#pragma warning disable IDE0035 // Unreachable code detected
#pragma warning disable IDE0059 // Unreachable code detected

namespace CastingDemo
{
    class Program
    {
        static void ImplicitCast()
        {
            //Implicit cast
            byte original = 10;
            int castedTo = original;
            Console.WriteLine(castedTo);
            //Will print 10
        }

        static void ExplicitCast()
        {
            //Explicit cast
            int original = 256;
            byte castedTo = (byte)original;
            Console.WriteLine(castedTo);
            //Will print 0, overflows
        }

        static void ExplicitCastWithConverter()
        {
            //Convert explicit cast
            int original = 256;
            byte castedTo = Convert.ToByte(original);
            //Will throw an error
        }

        static void Main(string[] args)
        {
            ImplicitCast();
            ExplicitCast();
            ExplicitCastWithConverter();
        }
    }
}

#pragma warning restore CS0162 // Unreachable code detected
#pragma warning restore IDE0035 // Unreachable code detected
