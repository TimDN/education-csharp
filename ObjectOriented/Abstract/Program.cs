using System;
using System.Data;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal dog = new Animal() syntax error
            Dog dog = new Dog("Brown","Medium");
            SpeakAnimal(dog);
        }

        static void SpeakAnimal(Animal animal)
        {
            animal.Speak();
        }
    }

    abstract class Animal
    {
        public Animal(string color, string size)
        {
            Color = color;
            Size = size;
        }
        public string Color { get; }
        public string Size { get; }

        public abstract void Speak();
    }

    class Dog : Animal
    {
        public Dog(string color, string size) 
            : base (color, size)
        {

        }
        public override void Speak()
        {
            Console.WriteLine("Woof Woof !");
        }
    }
}
