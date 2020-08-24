using System;

namespace Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Student foo = new Student("Foo", "Nya Staden", "G");
            Teacher bar = new Teacher("Bar", "Gamla Staden", 100);
            if (foo is Person)
            {
                //prints Name Foo, Address Nya Staden, Email , Avg.Grade G
                foo.PrintInfo(); 
            }
            if (bar is Person)
            {
                //calls base class version of PrintInfo
                //prints Name Bar, Address Gamla Staden, Email
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

        public virtual void PrintInfo()
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

        public override void PrintInfo()
        {
            Console.WriteLine($"Name {Name}, Adress {Adress}, Email {Email}," +
                $" Avg.Grade {AverageGrade}");
        }
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
