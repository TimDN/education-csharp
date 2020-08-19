using System;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);
            //Will print 0 to 9
        }
    }
}
