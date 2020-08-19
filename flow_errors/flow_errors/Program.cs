using System;

namespace flow_errors
{
    class Program
    {
        static void Main(string[] args)
        {
#pragma warning disable CS0162 // Unreachable code detected
#pragma warning disable IDE0035 // Unreachable code detected
#pragma warning disable IDE0059 // Unreachable code detectedS


            byte overflow = 255; //Max value of byte is 255
            overflow++;
            Console.WriteLine(overflow); //Prints 0

            byte underFlow = 0; //Min value of byte is 0
            underFlow--;
            Console.WriteLine(underFlow); //Prints 255

            byte checkedValue = 255;
            if (checkedValue != byte.MaxValue)
                checkedValue++;
            else
                Console.WriteLine("Checked value is at max value");
                //Will be printed
        }
    }
}
