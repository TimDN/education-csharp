using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student foo = new Student("Foo", "Gamla Staden", "G");
            Teacher bar = new Teacher("Bar", "Gamla Staden", 100);
            if(foo is Person)
            {
                //Will be printed
                foo.PrintInfo();
            }
            if(bar is Person)
            {
                //Will be printed
                bar.PrintInfo();
            }
        }
    }

    class Person
    {
        public Person(string name, string adress, string email = "")
        {
            Name = name;
            Adress = adress;
            Email = email;
        }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Name {Name}, Adress {Adress}, Email {Email}");
        }
    }

    class Student : Person
    {
        public Student(string name, string adress, string averageGrade = "IG") 
            : base(name, adress)
        {
            AverageGrade = averageGrade;
        }

        public string AverageGrade { get; private set; }
    }

    class Teacher : Person
    {
        public Teacher(string name, string adress, int salary = 0) 
            : base(name, adress)
        {
            Salary = salary;
        }

        public int Salary { get; private set; }
    }
}
