using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays - Storing multiple values");

            string[] names = new string[4]; // variable names can reference any array of strings

            // or

            string[] _names;
            _names = new string[4];

            // storing items at the index positions
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";

            try
            {
                for (int i = 0; i <= names.Length - 1; i++)
                {
                    Console.WriteLine($" Name is {names[i]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()} says {ex.Message}");
            }
        }
    }
}
