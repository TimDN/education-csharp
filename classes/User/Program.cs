using System;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            // calls the constructor with one parameter
            User foo = new User("1");
        }
    }
    class User
    {
        string _id;
        string _name;

        // Constructors takes two parameters, one is optional
        public User(string id, string name = "") 
        {
            _id = id;
            _name = name;
        }
    }
}
