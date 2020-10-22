using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "Hello World Foo Bar";
            input = RemoveSpaces(input);

            StringBuilderExample();
            StringBuilderEditExample();
            UpperLowerCase();
            FixSentence();
            ExtraExample();
            EmptyString();
            SplitExample();
            PrintExample();
            EqualsCase();
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
            {
                var upperCharacter = char.ToUpper(lower[0]);
                var wordExceptFirstChar = lower.Substring(1);
                return upperCharacter + wordExceptFirstChar;
            }
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
            helloWorld = helloWorld.Insert(helloWorld.Length, " World");
            Console.WriteLine(helloWorld);//prints Howdy World
            helloWorld = helloWorld.Replace("Howdy", "Hello");
            Console.WriteLine(helloWorld);//prints Hello World
            
            Console.WriteLine(helloWorld);//prints HelloWorld
        }

        static string RemoveSpaces(string input)
        {
            var index = input.IndexOf(" ");
            while (index != -1)
            {
                input = input.Remove(index, 1);
                index = input.IndexOf(" ");
            }
            return input;
        }

        static void EqualsCase()
        {
            var string1 = "ja";
            var string2 = "Ja";

            if(string.Equals(string1, string2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Equals"); // Will be printed
            }
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
