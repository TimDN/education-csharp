using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Threading.Channels;

namespace reference_type_demo
{
    class Program
    {
        static void ReferenceCopy()
        {
            int[] original = { 0, 1 };
            int[] copy = original;
            copy[0] = 2;
            Console.WriteLine(string.Join(", ", original));
            Console.WriteLine(string.Join(", ", copy));
            // both prints 2, 1
            Console.WriteLine(original == copy);
            // prints True
        }

        static void CopyArray()
        {
            int[] original = { 0, 1 };
            int[] copy = new int[original.Length];
            Array.Copy(original, copy, original.Length);
            copy[0] = 2;
            Console.WriteLine(string.Join(", ", original));
            //prints 0, 1
            Console.WriteLine(string.Join(", ", copy));
            //prints 2, 1
            Console.WriteLine(original == copy);
            // prints False
        }

        static void CopyList()
        {
            List<int> original = new List<int> { 0, 1 };
            List<int> copy = new List<int>();
            foreach(int orignalItem in original)
            {
                copy.Add(orignalItem);
            }
            copy.Add(2);
            Console.WriteLine(string.Join(", ", original));
            //prints 0, 1
            Console.WriteLine(string.Join(", ", copy));
            //prints 0, 1, 2
            Console.WriteLine(original == copy);
            // prints False
        }

        static void Main(string[] args)
        {
            ReferenceCopy();
            CopyArray();
            CopyList();
        }
    }
}
