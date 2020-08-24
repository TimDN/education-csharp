using System;
using System.Linq;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDemo();
        }

        static void StudentDemo()
        {
            Student foo = new Student();
            Student bar = new Student();
            Console.WriteLine(foo.Name); //prints Foo
            Console.WriteLine(bar.Name); //prints Foo
            // change name of bar instance
            bar.Name = "Bar";
            Console.WriteLine(foo.Name); //prints Foo
            Console.WriteLine(bar.Name); //prints Bar
        }
    }
    // creates a new class called Student
    class Student
    {
        public string Name = "Foo";
    }
}


