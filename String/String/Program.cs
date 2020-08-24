using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilderExample();
            StringBuilderEditExample();
            UpperLowerCase();
            FixSentence();
            ExtraExample();
            EmptyString();
            SplitExample();
            PrintExample();
        }

        static void PrintExample()
        {
            string hello = "Hello";
            string name = Console.ReadLine();
            int number = Console.Read();
            // $ activates string interpolation 
            Console.WriteLine($"{hello} to you {name} num {number}");
        }

        static void StringBuilderExample()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                sb.Append(i);
            }
            //Creates a string from the StringBuilder
            string result = sb.ToString();
            //prints 0123456789
            Console.WriteLine(result);
        }

        static void StringBuilderEditExample()
        {
            StringBuilder sb = new StringBuilder("Log: the ideal pet");
            //Only works with StringBuilder
            sb[0] = 'D';
            //prints Dog: the ideal pet
            Console.WriteLine(sb);
        }

        static void SplitExample()
        {
            string errorMessage = "Prefix: Message";
            string message = errorMessage.Substring(8);
            Console.WriteLine(message); //prints Message
            string selectedFruits = "Apple Orange Grapefruit";
            string[] fruits = selectedFruits.Split(" ");
            //prints Apple, Orange, Grapefruit
            Console.WriteLine(string.Join(", ", fruits));
        }

        static void UpperLowerCase()
        {
            string helloWorld = "HeLLo wOrld";
            string upper = helloWorld.ToUpper();
            //prints HELLO WORLD
            Console.WriteLine(upper);
            string lower = helloWorld.ToLower();
            //prints hello world
            Console.WriteLine(lower);
        }

        static string FixWordCasing(string word)
        {
            string lower = word.ToLower();
            if (lower.Length == 1)
                return char.ToUpper(lower[0]).ToString();
            else
                return char.ToUpper(lower[0]) + lower.Substring(1);
        }

        static void FixSentence()
        {
            string helloWorld = "hElLo wOrld";
            string[] words = helloWorld.Split(" ");
            List<string> fixedSentence = new List<string>();
            foreach (string word in words)
            {
                fixedSentence.Add(FixWordCasing(word));
            }
            //Prints Hello World
            Console.WriteLine(string.Join(" ",fixedSentence));
        }

        static void ExtraExample()
        {
            string helloWorld = "Howdy";
            helloWorld = helloWorld.Insert(5, " World");
            Console.WriteLine(helloWorld);//prints Howdy World
            helloWorld = helloWorld.Replace("Howdy", "Hello");
            Console.WriteLine(helloWorld);//prints Hello World
            helloWorld = helloWorld.Remove(5, 1);
            Console.WriteLine(helloWorld);//prints HelloWorld
        }

        static void EmptyString()
        {
            string input = string.Empty;
            if (string.IsNullOrWhiteSpace(input))
            {
                //Will be printed
                Console.WriteLine("Is empty");
            }
        }
    }
}
