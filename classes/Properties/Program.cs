using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Student foo = new Student("1");
            foo.Name = "Foo";
            Console.WriteLine($"{foo.Id}  {foo.Name}  {foo.UserId}"); //prints 1 Foo Foo
        }
    }

    class Student
    {
        private string _name;

        public Student(string id, string name = "")
        {
            Id = id;
            _name = name;
            UserId = name;
        }

        // Readonly property that can only be set in ctor
        public string Id { get; }

        // Property that can be modified in the class
        public string UserId { get; private set; }

        // Public property that can be changed from outside the class
        public string Name { 
            get { return _name; }
            set 
            {
                Console.WriteLine($"Changing name to {_name}");
                // value is a special variable containing the set parameter
                _name = value;
                UserId = value;
            }
        }
    }
}
