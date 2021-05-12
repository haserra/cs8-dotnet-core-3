using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    /// <summary>
    /// A Class is implicitly internal.<!-- So we need to turn it public-->
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("People App Project! - How to instantiate the Type Person");
            BankAccount.InterestRate = 0.012M; // store a shared value. Because it's static don't need instantiate it

            Person bob = new Person();
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1965, 12, 22);
            bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            // bob.BucketList = (WondersOfTheAncientWorld)18;

            bob.Children.Add(new Person()
            {
                Name = "Alfred"
            }
                            );
            bob.Children.Add(new Person()
            {
                Name = "Zoe"
            }
                            );

            BankAccount jonesAccount = new BankAccount();
            jonesAccount.AccountName = "Mrs. Jones";
            jonesAccount.Balance = 2400;

            WriteLine(format: "{0} earned {1:C} interest.", arg0: jonesAccount.AccountName, arg1: jonesAccount.Balance * BankAccount.InterestRate);

            BankAccount gerrierAccount = new BankAccount();
            gerrierAccount.AccountName = "Ms. Gerrier";
            gerrierAccount.Balance = 98;

            WriteLine(format: "{0} earned {1:C} interest.", arg0: gerrierAccount.AccountName, arg1: gerrierAccount.Balance * BankAccount.InterestRate);



            WriteLine($"{bob.ToString()}"); // This works because every class in C# inherits from System.Object
                                            //The implementation of the ToString method in the System.Object type simply outputs the full namespace and type name

            WriteLine(format: "{0} was born on {1: dddd, d MMMM yyyy}", arg0: bob.Name, arg1: bob.DateOfBirth);

            WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

            Person alice = new Person()
            {
                Name = "Alice",
                DateOfBirth = new DateTime(1998, 3, 7)
            };

            Person blankPerson = new Person();

            WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.", arg0: blankPerson.Name, arg1: blankPerson.HomePlanet, arg2: blankPerson.Instantiated);

            WriteLine(format: "{0} was born on {1:dd MMM yy}", arg0: alice.Name, arg1: alice.DateOfBirth);

            //

            Person gunny = new Person("Gunny", "Mars");
            WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.", arg0: gunny.Name, arg1: gunny.HomePlanet, arg2: gunny.Instantiated);



            // 5.3.1 - Building Your Own Types with Object-Oriented Programming - Storing data within fields - Storing a value using an enum type

            WriteLine(format: "{0}'s favorite wonder is {1}. It's integer is {2}.", arg0: bob.Name, arg1: bob.FavoriteAncientWonder, arg2: (int)bob.FavoriteAncientWonder);

            WriteLine($"{bob.Name} has {bob.Children.Count} children:");

            for (int child = 0; child < bob.Children.Count; child++)
            {
                WriteLine($" {bob.Children[child].Name}");
            }

            foreach (var child in bob.Children)
            {
                WriteLine($" -- {child.Name}");
            }

            // 5.3.1 - Building Your Own Types with Object-Oriented Programming - Storing data within fields - Making a field static



            // 5.3.11 - Building Your Own Types with Object-Oriented Programming - Storing data within fields - Setting fields with default literals

            bob.WriteToConsole();
            WriteLine(bob.GetOrigin());

            // 5.3.12 - Combining multiple returned values using tuples

            // var fruit = bob.GetFruit();
            (string, int) fruit = bob.GetFruit();

            WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

            WriteLine(bob.SayHello());
            WriteLine(bob.SayHelloTo("Emily"));
            WriteLine(bob.SayHello("Betty"));

            // 5.3.13 - Passing optional parameters and naming arguments
            // A parameter is made optional by assigning a default value inside the method parameter list

            WriteLine(bob.OptionalParameters());
            WriteLine(bob.OptionalParameters("Jump! instead of running", 98.5));

            // Optional parameters are often combined with naming parameters

            WriteLine(bob.OptionalParameters(number: 100.09, command: "Change positions!"));
            WriteLine(bob.OptionalParameters("Poke!", active: false));

            // 5.4.6 - Controlling how parameters are passed

            // By value - in-only
            // By reference - in-and-out
            // As an out parameter out-only

            WriteLine($"Controlling how parameters are passed to methods.");

            int a = 10;
            int b = 20;
            int c = 30;

            WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            bob.PassingParameters(a, ref b, out c);
            WriteLine($"After: a = {a}, b = {b}, c = {c}");

            // 5.4.7 - Splitting classes using partial
            // On large projects, it is useful to be able to split the definition of a complex class across multiple files.



            // 5.5 - Building Your Own Types with Object-Oriented Programming - Controlling access with properties and indexers
            // 5.5.1 - Defining readonly properties (and auto implemented properties)

            var sam = new Person()
            {
                Name = "Sam",
                DateOfBirth = new DateTime(1972, 1, 27)
            };

            WriteLine($" Sam's origin is {sam.Origin}");
            WriteLine($"Sam is greeting you: {sam.Greeting}");
            WriteLine($"Sam's age is {sam.Age}");

            // 5.5.2 - Defining settable properties

            // Using the Property Setter to set the instance field value:
            sam.FavoriteIceCream = "Chocolate Fudge";

            // Using the very same Property Getter to get the instance field value:
            WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");

            sam.FavoritePrimaryColor = "Red";

            WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");


            // 5.5.3 - Defining indexers

            sam.Children.Add(new Person()
            {
                Name = "Charlie"
            });

            sam.Children.Add(new Person() { Name = "Ella" });

            WriteLine($"Sam's first child is {sam.Children[0].Name}");
            WriteLine($"Sam's second child is {sam.Children[1].Name}");
            WriteLine($"Sam's first child is {sam[0].Name} (using indexer)");
            WriteLine($"Sam's second child is {sam[1].Name} (using indexer)");


            // Chapter 06 - Implementing Interfaces and Inheriting Classes
            // 6.2.1 - Implementing functionality using methods

            Person harry = new Person() { Name = "Harry" };
            Person mary = new Person() { Name = "Mary" };
            Person jill = new Person() { Name = "Jill" };

            // call instance method

            var baby1 = mary.ProcreateWith(harry);

            // call static method
            var baby2 = Person.Procreate(harry, jill);

            // call an operator
            var baby3 = harry * mary;

            WriteLine($"{harry.Name} has {harry.Children.Count} children.");
            WriteLine($"{mary.Name} has {mary.Children.Count} children.");
            WriteLine($"{jill.Name} has {jill.Children.Count} children.");

            WriteLine(format: "{0}'s first child is named \"{1}\".", arg0: harry.Name, arg1: harry.Children[0].Name);

            // 6.2.2 - Implementing functionality using operators

            string s1 = "Hello ";
            string s2 = "World!";
            string s3 = string.Concat(s1, s2);
            WriteLine(s3); // => Hello World!

            string s4 = "Hello again";
            string s5 = "Beautiful World!";
            string s6 = s4 + s5;
            WriteLine(s6); // => Hello World!

            // 6.2.3 - Implementing functionality using local functions
            // local functions are nested or inner functions within a method.

            WriteLine($"5! is {Person.Factorial(5)}");

            // 6.2.4 - Raising and handling events
            // Methods are often described as actions that an object can perform, either on itself or to related objects.

            // Events are often described as actions that happen to an object.
            // Events are built on delegates.

            // The alternative way to call a Class or an Instance Method is to use a delegate.


            // Option 1            
            Person p1 = new Person();
            int answer = p1.MethodIWantToCall("Frog");

            // Option 2

            // create a delegate instance that points to the method

            //var d = new DelegateWithMatchingSignature(p1.MethodIWantToCall);


            // 6.4 - Implementing interfaces

            // An interface is a syntactic contract

            // If a type implements an interface, then it is making a promise to the rest of .NET that it supports a certain feature

            // IComparable
            // IComparer
            // IDisposable
            // IFormattable
            // IFormatter
            // IFormatProvider

            int[] testNumbers = new int[] { 2, 10, 3, 23, 17, 5, 4, 6 };
            int i = 0;
            WriteLine($"Initial list of testing numbers");
            foreach (var number in testNumbers)
            {
                WriteLine($"- number {i} is {number}");
                i++;
            };
            i = 0;

            WriteLine($"List of testing numbers after sorting: ");
            Array.Sort(testNumbers);
            foreach (var number in testNumbers)
            {
                WriteLine($"-- number {i} is {number}");
                i++;
            }


            Person[] people = new Person[]
            {
                new Person(){ Name = "Simon" },
                new Person(){ Name = "Jenny"},
                new Person(){ Name = "Adam"},
                new Person(){ Name = "Richard"}
            };

            WriteLine("Initial list of people:");
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            WriteLine($"Use Person's IComparable implementation to sort ");

            // Array.Sort(people);
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");

            };

            // Important: type Person must implement IComparable!

            // 6.4.4 - Comparing objects using a separate class

            WriteLine($"Use PersonComparer's IComparer implementation instead, to sort:");

            Array.Sort(people, new PersonComparer());
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }


            // 6.4.5 - Defining interfaces with default implementations
            // A language feature introduced in C# 8.0 is default implementations for an interface


            // 6.5 - Making types safely reusable with generics

            Thing t1 = new Thing();
            t1.Data = 42;

            WriteLine($"Thing with an integer: {t1.Process(42)}");

            var t2 = new Thing();
            t2.Data = "apple";
            WriteLine($"Thing with a string: {t2.Process("apple")}");

            var gt1 = new GenericThing<int>();
            gt1.Data = 42;
            WriteLine($"GenericThing with an integer: {gt1.Process(42)}");

            var gt2 = new GenericThing<string>();
            gt2.Data = "apple";
            WriteLine($"GenericThing with a string: {gt2.Process("apple")}");

            //

            string number1 = "4";
            WriteLine("{0} squared is {1}", arg0: number1, arg1: Squarer.Square<string>(number1));

            byte number2 = 3;
            WriteLine("{0} squared is {1}", arg0: number2, arg1: Squarer.Square(number2));


            // 6.7 - Inheriting from classes

            Employee john = new Employee // Inherits from Person
            {
                Name = "John Jones",
                DateOfBirth = new DateTime(1990, 7, 28)
            };

            john.WriteToConsole(); // Employee class has inherited all the members of Person 

            // 6.7.1 - Extending classes

            // calling the setters
            john.EmployeeCode = "JJ001";
            john.HireDate = new DateTime(2014, 11, 23);

            // calling the getter
            WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}");

            // 6.7.3 - Overriding members
            // Rather than hiding a method, it is usually better to override it.
            // !! It's only possible to override a method if the base class chooses to allow overriding, by applying the virtual keyword

            WriteLine(john.ToString());


            // 6.7.5 - Understanding polymorphism
            // 

            Employee aliceInEmployee = new Employee()
            {
                Name = "",
                EmployeeCode = "AA123"
            };

            Person aliceInPerson = new Person();
            aliceInPerson = aliceInEmployee;
            aliceInEmployee.WriteToConsole();

            aliceInPerson.WriteToConsole();
            WriteLine(aliceInEmployee.ToString());
            WriteLine(aliceInPerson.ToString());



















































        }
    }
}
