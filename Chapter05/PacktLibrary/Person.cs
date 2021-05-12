using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    /// <summary>
    /// The implicit access modifier for a class is internal
    /// So we use the access modifier public
    /// 
    /// Class menbers can be:
    /// - Fields (Constant, Read-only, Event)
    /// - Methods (Constructor, Property, Indexer, Operator)
    /// - Properties
    /// - Delegates
    /// 
    /// 
    /// </summary>
    public partial class Person : System.Object, IComparable<Person>
    {
        // Declaring some fields to store data
        // A member is implicitly private, so we need to declare it public
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>(); // List of Person instances. Making a collection strongly typed

        // constants
        public const string Species = "Homo Sapien";
        // read-only fields
        public readonly string HomePlanet = "Earth";
        // Use read-only fields over the const fields

        public readonly DateTime Instantiated;

        public string favoriteIceCream; // Not required though, because the auto-implemented property provides this instance field automatically.

        // constructors

        // first constructor
        public Person()
        {
            // set default values for fields
            // including read-only fields
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        // second constructor
        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        // methods
        public virtual void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }

        // Tuple Example
        public (string, int) GetFruit()
        {
            return ("Apples", 5);
        }

        public string SayHello()
        {
            return $"{Name} says 'Hello'!";
        }

        public string SayHelloTo(string name)
        {
            return $"{Name} says 'Hello {name}'";
        }
        // or we can overload methods, like this
        // because they have different signatures, i.e. the list of parameter types that can be passed

        public string SayHello(string name)
        {
            return $"{Name} says 'Hello, I am using method overloading to say Hello {name}!'";
        }

        public string OptionalParameters(string command = "Run!", double number = 0.0, bool active = true)
        {
            return string.Format(
                    format: "command is {0}, number is {1}, active is {2}",
                    arg0: command, arg1: number, arg2: active);

        }

        // Controlling how parameters are passed: by value, by reference, as an out param

        public void PassingParameters(int x, ref int y, out int z)
        {
            // out parameters cannot have a default
            // AND must be initialized inside the method
            z = 99;
            // increment each parameter
            x++;
            y++;
            y = 100;
            z++;
            WriteLine($" Inside: x = {x}, y = {y}, z = {z}");
        }

        // static method to "multiply"
        // static methods are actions the type does
        // therefore we don't need to instantiate the class to use it
        public static Person Procreate(Person p1, Person p2)
        {
            // baby is a reference to the baby Object, not the object itself
            var baby = new Person()
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };

            p1.Children.Add(baby);
            p2.Children.Add(baby);

            return baby;
        }

        // instance method to "multiply"
        // Instance methods are actions that an object does to itself
        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }

        // operator to "multiply"
        public static Person operator *(Person p1, Person p2)
        {
            return Person.Procreate(p1, p2);
        }


        // method with a local function
        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException(
                $"{nameof(number)} cannot be less than zero.");
            }
            return localFactorial(number);

            int localFactorial(int localNumber) // local function
            {
                if (localNumber < 1) return 1;
                return localNumber * localFactorial(localNumber - 1);
            }
        }


        // The alternative way to call a Class or an Instance Method is to use a delegate.  

        public int MethodIWantToCall(string input)
        {
            return input.Length; // it doesn't matter what this does
        }

        public int CompareTo(Person other)
        {

            return Name.CompareTo(other.Name);
            // we should add null checks throughout these examples.
        }

        delegate int DelegateWithMatchingSignature(string s);

        //

        // overridden methods
        public override string ToString()
        {
            return $"{Name} is a {base.ToString()}";
        }














    }
}
