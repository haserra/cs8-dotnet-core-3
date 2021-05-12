using System;
using System.IO;
using static System.Console;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Chapter 03 -- Controlling Flow and Converting Types - Selection Statements.");

            // I should always use braces with if statements, even when there only one statement in each block.

            if (args.Length == 0)
            {
                WriteLine($"You have not entered any arguments!");
            }
            else
            {
                WriteLine($"This console app has {args.Length} input arguments.");
            }

            WriteLine($"Chapter 03 -- Controlling Flow and Converting Types - Pattern matching with the if statement.");

            // add and remove the "" to change the behavior
            object o = 3;

            int j = 4;

            if (o is int i)
            {
                WriteLine($"{i} x {j} = {i * j}");
            }
            else
            {
                WriteLine("o is not an int so it cannot multiply!");
            }

            // Branching with the switch statement

            WriteLine("Chapter 03 -- Controlling Flow and Converting Types - Branching with the switch statement.");

        A_label:
            var number = (new Random()).Next(1, 7);
            WriteLine($"My random number is {number}");

            switch (number)
            {
                case 1:
                    WriteLine($"One");
                    break; // jumps to the end of the switch statement
                case 2:
                    WriteLine($"two");
                    break;
                case 3:
                case 4:
                    WriteLine("Three or four");
                    goto case 1;
                case 5:
                    // go to sleep for a second
                    System.Threading.Thread.Sleep(1000);
                    goto A_label;
                default:
                    WriteLine($"Default");
                    break;
            }


            // 3.2.5 - PATTERN MATCHING WITH THE SWITCH STATEMENT
            WriteLine("Chapter 03 -- Controlling Flow and Converting Types - Pattern matching with the switch statement.");

            // string path = "/Users/markjprice/Code/Chapter03";
            string path = @"C:\Users\salgu\source\repos\C# 8.0 and .NET Core 3.0\Chapter03";

            Stream s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate);

            string message = String.Empty;

            switch (s)
            {
                case FileStream writeableFile when s.CanWrite:
                    message = "The stream is a file that I can write to.";
                    break;
                case FileStream readOnlyFile:
                    message = "The stream is a read-only file.";
                    break;
                case MemoryStream ms:
                    message = "The stream is a memory address.";
                    break;
                default: // always evaluated last despite its current position
                    message = "The stream is some other type.";
                    break;
                case null:
                    message = "The stream is null.";
                    break;
            }
            WriteLine(message);
        }
    }
}
