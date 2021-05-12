using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with Variables - Storing any type of object");
            Console.WriteLine("\r\n\n");

            object height = 1.88; // storing a double in an object
            object name = "Amir"; // storing a string in an object

            Console.WriteLine($"{name} is {height} metres tall.");

            //int length1 = name.Length; // this is a compiler error
            int length2 = ((string)name).Length; // cast , so tells the compiler it is a string

            Console.WriteLine($"{name} has {length2} characters.");

            // Storing dynamic types comes with a cost though and should be wrapped in a try-catch statement 

            dynamic anotherName = "Ahmed";

            int length = anotherName.Length;

            // Specifying and inferring the type of a local variable

            Console.WriteLine("Specifying and inferring the type of a local variable");
            Console.WriteLine("\r\n");

            int population = 10_174_260; // 10 million in Portugal
            long myStock = 250L;
            float myHeight = 1.79F;
            float myWeight = 82.7F;
            double weight = 1.88; // in Kg
            decimal price = 4.99M; // in pound sterling 
            string fruit = "Apples"; // double quotes!!
            char letter = 'Z'; // single quotes !
            bool happy = true;

            // I can use the var keyword to declare local variables. The compiler will
            // infer the type from the value that I assign after the assignment operator = 

            // instead of specifying the type lets use the keyword var

            var _population = 10_174_260; // 10 million in Portugal
            var _myStock = 250L;
            var _myHeight = 1.79F;
            var _myWeight = 82.7F;
            var _weight = 1.88; // in Kg
            var _price = 4.99M; // in pound sterling 
            var _fruit = "Apples"; // double quotes!!
            var _letter = 'Z'; // single quotes !
            var _happy = true;

            // Getting default values for types
            // Most primitive types are value types

            Console.WriteLine($"default(int) = {default(int)}.");
            Console.WriteLine($"default(bool) = {default(bool)}.");

            // Storing multiple values


        }
    }
}
