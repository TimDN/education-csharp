using System;
using System.Collections.Generic;

namespace methods_demo
{
    class Program
    {
        // outparameter is of type string takes no imparameter
        static string GetHelloWorld()
        {
            // returns the string "Hello World"
            return "Hello World";
        }

        static void InitDemo()
        {
            //calls the method GetHelloWorld()
            string greeting = GetHelloWorld(); // we must capture the return value
            Console.WriteLine(greeting); //prints Hello World
        }

        // outparameter is of type int, inparams is firstNumber, secondNumber
        static int CalculateSum(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber); //prints 1
            Console.WriteLine(secondNumber); //prints 2
            //returns the sum of first and second number
            return firstNumber + secondNumber;
        }

        static void SumDemo()
        {
            int result = CalculateSum(1, 2); //assign return value to result
            Console.WriteLine(result); //prints 2
        }

        static int[] ReadNumbers()
        {
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            return numbers;
        }

        static int CalculateSum(int[] numbers)
        {
            int numbersSum = 0;
            foreach (int number in numbers)
            {
                numbersSum += number;
            }
            return numbersSum;
        }

        static void MethodDemo()
        {
            int[] numbers = ReadNumbers();
            int result = CalculateSum(numbers);
            Console.WriteLine(result);
        }

        static void NoMethodDemo()
        {
            int[] numbers = new int[5];
            for(int i = 0; i < 5; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int numbersSum = 0;
            foreach(int number in numbers)
            {
                numbersSum += number;
            }
            Console.WriteLine(numbersSum);
        }

        static void Main(string[] args)
        {
            InitDemo();
            SumDemo();
            NoMethodDemo();
            MethodDemo();
        }
    }
}
