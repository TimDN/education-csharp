using System;
using System.Collections.Generic;

namespace List_demo
{
    class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0028:Simplify collection initialization", Justification = "<Pending>")]
        
        static void MoreList()
        {
            List<int> firstList = new List<int>() { 0, 1};
            List<int> secondList = new List<int>() { 2, 3 };
            firstList.AddRange(secondList);
            Console.WriteLine(firstList.Count); // prints 4
            firstList.Remove(0);
            Console.WriteLine(string.Join(", ", firstList)); // prints 1, 2 ,3
        }
        
        static void Main(string[] args)
        {
            List<int> initList = new List<int>();
            initList.Add(10);
            initList.Add(20);
            Console.WriteLine(string.Join(", ", initList)); // prints 10, 20

            List<int> preInit = new List<int> { 0, 1 };

            MoreList();
        }
    }
}
