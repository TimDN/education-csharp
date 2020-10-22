using System;

namespace Smallest
{
    class Program
    {
        static int GetSmallest(int firstNumber, int secondNumber)
        {
            if(firstNumber < secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 4, 5, 6 , 3 , 7 };

            var smallest = int.MaxValue;

            foreach(var number in numbers)
            {
                if(number < smallest)
                {
                    smallest = number;
                }
            }
            Console.WriteLine(smallest);
        }
    }
}
