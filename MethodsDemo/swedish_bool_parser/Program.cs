using System;

namespace swedish_bool_parser
{
    class Program
    {
        static bool TrySwedishBoolParser(string input)
        {
            if(input == "Ja" || input == "Sant")
            {
                return true;
            }
            else if(input == "Nej" || input == "Falskt")
            {
                return false;
            }
            else
            {
                throw new ArgumentException($"Error could not parse {input}");
            }
        }

        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            try
            {
                var result = TrySwedishBoolParser(input);
                Console.WriteLine(result);
            }
            catch (Exception e) when (e is ArgumentException || e is NullReferenceException)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
