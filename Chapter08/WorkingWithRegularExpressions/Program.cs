using System;
using static System.Console;
using System.Text.RegularExpressions;

namespace WorkingWithRegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking for digits entered as text.");

            WriteLine($"Please enter your age: ");
            string input = ReadLine();

            var ageChecker = new Regex(@"\d"); // @ character switches off the ability to use escape characters, so I can safely use "\d"
            var ageChecker2 = new Regex(@"^\d$");
            var ageChecker3 = new Regex(@"^\d+$");

            if (ageChecker.IsMatch(input))
            {
                WriteLine("Thank you!");
            }
            else
            {
                WriteLine($"This is not a valid age: {input}");
            }

            //

            //string films = "Monsters, Inc.","I, Tonya","Lock, Stock and Two Smoking Barrels"; // Doesnt work this way
            // we need to escape the "
            string films = "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock andTwo Smoking Barrels\"";

            string[] filmsDumb = films.Split(',');

            WriteLine("Dumb attempt at splitting:");

            foreach (string film in filmsDumb)
            {
                WriteLine(film);
            }

            //

            var csv = new Regex("(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)");
            MatchCollection filmsSmart = csv.Matches(films);
            WriteLine("Smart attempt at splitting:");

            foreach (Match film in filmsSmart)
            {
                WriteLine(film.Groups[2].Value);
            }

            // Storing multiple objects in collections

            // All collections implement the ICollection interface, thertefore they must implement the Count property
            // All collections implement the IEnumerable interface, therefore they must implement the GetEnumerator method

            // Lists

            // Dictionaries

            // Stacks
            // last-in, first-out (LIFO)

            // Queues
            // first-in, first-out (FIFO)



        }
    }
}
