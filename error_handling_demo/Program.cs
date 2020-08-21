using System;

namespace error_handling_demo
{
    class Program
    {
        static void DivideByZero()
        {
            int zero = 0;
            int error = 1 / zero;
        }

        static void HandleError()
        {
            try
            {
                DivideByZero();
            }
            catch (DivideByZeroException e)
            {
                //Handle error by printing human readable error
                Console.WriteLine("Can not divide by zero");
                Console.WriteLine(e); // print error message with stack log
            }
        }

        static void FinallyExample()
        {
            try
            {
                DivideByZero();
            }
            catch (Exception)
            {
                Console.WriteLine("Caught exception");
                // rethrowing exception so that it can be handled elsewhere
            }
            finally
            {
                Console.WriteLine("In finally");
            }
        }

        static int ReadNumber()
        {
            int number = 0;
            bool validNumber = false;
            do
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    validNumber = true;
                }
                catch (FormatException) // thrown by Convert.ToInt32()
                {
                    // We know how to handle this error
                    Console.WriteLine("Non valid number. Try again");
                }
            } while (!validNumber);
            return number;
        }

        static void Main(string[] args)
        {
            //HandleError();
            FinallyExample();
        }
    }
}
