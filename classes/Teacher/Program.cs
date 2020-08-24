using System;

namespace Teacher
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher bar = new Teacher();
            // bar.printName() Not accessible since its private
            bar.GreetTeacher(); //Accessible since its public
        }

    }
    class Teacher
    {
        // private field prefixed with underscore
        string _name = "Foo";

        //private method using camelCase
        void printName()
        {
            Console.WriteLine($"Name is {_name}");
        }

        //public method using PascalCase
        public void GreetTeacher()
        {
            Console.WriteLine($"Hello {_name}");
        }
    }
}
