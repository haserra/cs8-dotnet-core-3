using System;
using static System.Console;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Formatting strings");
            WriteLine($"There are {args.Length} arguments.");

            if (args.Length < 4)
            {
                WriteLine($"You are missing two colors and two dimensions");
                WriteLine($"For instance: dotnet run red yellow 80 40");
                return;
            }

            ForegroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[0], ignoreCase: true);
            BackgroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[1], ignoreCase: true);

            try
            {
                WindowWidth = int.Parse(args[2]);
                WindowHeight = int.Parse(args[3]);
            }
            catch (PlatformNotSupportedException ex)
            {
                WriteLine($"The current platform does not support changing the size of a console window: {ex.Message}");
            }

            int numberOfApples = 12;
            decimal pricePerApple = 0.35M;

            WriteLine(
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples);

            string formatted = string.Format(
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples);

            //WriteToFile(formatted);

            WriteLine("Formatting using interpolated strings");

            WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

            WriteLine($"Understanding format strings");

            // N0, C
            // C means Currency (automaticaly shows € or £ or $ depends of the region where the OS is running)
            // N0 means a number with thousand separators and no decimal places. For example: 9 223 372 036 854 775 807 , has 6 thousand separators
            // { index [, alignment ] [ : formatString ] }

            string applesText = new String("Apples");
            int applesCount = 1234;
            string bananasText = "Bananas";
            int bananasCount = 56789;

            WriteLine(
                format: "{0, -8} {1,6:N0}",
                arg0: "Name",
                arg1: "Count"
            );

            WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: applesText,
                arg1: applesCount
            );

            WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: bananasText,
                arg1: bananasCount
            );

            WriteLine($"Getting text input from the user.");
            Write("Type your first name and then press ENTER");
            string firstName = ReadLine();

            Write("Type your age and press ENTER");
            int age = Int32.Parse(ReadLine());

            WriteLine($"{firstName}, you look good for {age}");
            WriteLine($"Getting key input from the user");
            Write("Press any key combination: ");

            ConsoleKeyInfo key = ReadKey();
            ReadKey();
            WriteLine();

            WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
            arg0: key.Key,
            arg1: key.KeyChar,
            arg2: key.Modifiers);



        }

        private static void WriteToFile(string formatted)
        {
            throw new NotImplementedException();
        }

    }
}
