namespace Packt.Shared
{
    public partial class Person
    {
        // 5.5 - Building Your Own Types with Object-Oriented Programming - Controlling access with properties and indexers
        // 5.5.1 - Defining readonly properties (and auto implemented properties)

        // A property is simply a method (or a pair of methods) that acts and looks like a field when you want to get or set a value, thereby simplifying the syntax

        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }

        // two properties defined using C# 6+ lambda expression syntax
        public string Greeting => $"{Name} says 'Hello!'";
        public int Age => System.DateTime.Today.Year - DateOfBirth.Year;

        // 5.5.2 - Defining settable properties
        public string FavoriteIceCream { get; set; } // auto-syntax

        // IMPORTANT: Although I have not manually created a field to store the person's favorite ice cream, 
        // it is there, behind the scenes automatically created by the compiler for you

        private string favoritePrimaryColor;

        public string FavoritePrimaryColor
        {
            get
            {
                return favoritePrimaryColor;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favoritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException(
                        $"{value} is not a primary color. " +
                        "Choose from: red, green, blue.");
                }
            }
        }

        // 5.5.3 - Defining indexers

        // indexers
        public Person this[int index]
        {
            get
            {
                return Children[index];
            }
            set
            {
                Children[index] = value;
            }
        }


    }
}