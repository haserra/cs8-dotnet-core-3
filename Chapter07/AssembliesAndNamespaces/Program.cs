using System;
using System.Xml.Linq;
using static System.Console;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Understanding and Packaging .NET Types!");

            var doc = new XDocument();

            // All C# type keywords are aliases for a .NET type in a class library assembly

            // For example: the string keyword, the compiler turns it into a System.String type

            string s1 = "Hello";
            // or
            System.String s2 = "World";

        }
    }
}
