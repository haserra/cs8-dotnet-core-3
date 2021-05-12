using System;
using System.Collections;
using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3.3.1 - LOOPING WITH THE WHILE STATEMENT
            WriteLine("Chapter 03 -- Controlling Flow and Converting Types - Understanding iterations statements.");

            int x = 0;

            while (x < 10)
            {
                WriteLine(x);
                x++;
            }

            // 3.3.2 - LOOPING WITH THE DO STATEMENT
            string password = string.Empty;
            int attempts = 0;

            do
            {
                Write("Enter your password: ");
                password = ReadLine();
                attempts++;
            }
            while (password != "Pa$$w0rd" && attempts <= 10);

            if (password == "Pa$$w0rd" && attempts <= 10)
            {
                WriteLine("Correct!");
            }
            else if (attempts > 10)
            {
                WriteLine($"You've reached the maximum number of attempts. Wait 10 mins and try again.");
            }

            // 3.3.3 - LOOPING WITH THE FOR STATEMENT

            for (int y = 1; y <= 10; y++)
            {
                WriteLine($"Currently y is {y}");
                WriteLine(y);
            }

            // 3.3.4 - LOOPING WITH THE FOREACH STATEMENT
            // it is meant to run over a collection of items

            string[] names = { "Adam", "Barry", "Charlie" };

            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }

            // IMPORTANT: the C# compiler turns the foreach statement into something like this:

            IEnumerator e = names.GetEnumerator();
            while (e.MoveNext())
            {
                string name = (string)e.Current; // Current is read-only!
                WriteLine($"{name} has {name.Length} characters.");
            }

            // 3.3.5 - CASTING AND CONVERTING BETWEEN TYPES
            // converting from one type to another is also known as casting, and it can be implicit (safe) or explicit (not safe)






        }
    }
}
