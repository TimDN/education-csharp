using System;

namespace array_demo
{
#pragma warning disable IDE0059 // Unnecessary assignment of a value
    class Program
    {
        static void LoopExample()
        {
            int[] intArray = { 1, 2, 3 };
            for(int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
            //Prints
            // 1
            // 2
            // 3

            Console.WriteLine(string.Join(", ", intArray));
            //Prints 1, 2, 3
        }
        static void Main(string[] args)
        {

            int[] initIntArray = new int[3];//Initialize an array of length 3

            initIntArray[0] = 1; //Set index 0 to 1
            initIntArray[1] = 2; //Set index 1 to 2
            initIntArray[2] = 3; //Set index 2 to 3

            Console.WriteLine(initIntArray[0]); //Prints value of index 0 i.e 1


            int[] initIntArrayValues = new int[] { 1, 2, 3 };
            int[] initIntArrayValuesShort = { 1, 2, 3 };

            LoopExample();
        }
    }
}
#pragma warning restore IDE0059 // Unnecessary assignment of a value
