using System;

namespace out_of_range_demo
{
    class Program
    {
        static void ThrowsExample()
        {
            int[] addValues = { 1, 2, 3 };
            for (int i = 0; i < addValues.Length; i++)
            {
                addValues[i] = addValues[i] + addValues[i + 1];
            }
            //throws IndexOutOfRangeException
        }

        static void ThrowsFixed()
        {
            int[] addValues = { 1, 2, 3 };
            for (int i = 0; i < addValues.Length; i++)
            {
                if(i + 1 < addValues.Length)
                {
                    addValues[i] = addValues[i] + addValues[i + 1];
                }
                else
                {
                    // Adding first index to last index
                    addValues[i] = addValues[i] + addValues[0];
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                ThrowsExample();
            }
            catch (Exception)
            {
            }
            ThrowsFixed();
        }
    }
}
