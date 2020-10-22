using System;
using System.Collections.Generic;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
            //Prints 0 to 9

            var list = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (var item in list)
            {
                //item += 1; can't modify items in foreach
                //list.Add(10); results in Collection was modified error
                //list.Remove(0); results in Collection was modified error
            }

            var dict = new Dictionary<string, string>()
            {
                { "foo", "bar" },
                { "test", "foo" }
            };
            foreach(var pair in dict)
            {
                Console.WriteLine($"key {pair.Key} value {pair.Value}");
            }
            //prints key foo value bar
            //       key test value foo
        }
    }
}
