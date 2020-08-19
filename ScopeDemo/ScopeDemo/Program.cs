using System;

namespace ScopeDemo
{
    class Program
    {//Class level scope
        static void Main(string[] args)
        {//Method level scope
            int methodVariable = 10;
            for (int intInFor = 0; intInFor < 2; intInFor++)//For level scope
            {
                int innerScope = methodVariable; //Accessible in lower scope
                if (intInFor == 1)
                {//If level scope
                    innerScope = methodVariable; //Accessible in all lower scopes
                }//Leaving if level scope
            }//Leaving for level scope
            //Console.WriteLine(intInFor); Not accessible in this scope
        }//Leaving method level scope
    }//Leaving class level scope
}
