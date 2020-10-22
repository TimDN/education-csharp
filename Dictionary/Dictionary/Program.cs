using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // using System.Collections.Generic

            //Setting start values 
            var dict = new Dictionary<string, string>()
            {
                { "key1","value1" },
                { "key2", "value2" }
            };
            dict.Add("key3", "value3");
            Console.WriteLine(dict["key1"]); //prints value1
            //dict["key4"] runtime error
            if (dict.ContainsKey("key2"))
                Console.WriteLine(dict["key1"]); //prints value2
            Console.WriteLine(dict.Count);//prints 3
            dict.Remove("key1");
            Console.WriteLine(dict.Count);//prints 2
        }
    }
}
