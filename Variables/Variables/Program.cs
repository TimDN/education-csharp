using System;
using System.Text;

namespace Variables
{
    class Program
    {
#pragma warning disable CS0219 // Variable is assigned but its value is never used
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            var stringB = new StringBuilder();
            var age = 20;
            var name = "Tim";
        }
    }
#pragma warning restore CS0219 // Variable is assigned but its value is never used
}

